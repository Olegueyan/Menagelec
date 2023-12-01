using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menagelec.Data;
using Menagelec.Entity;
using Menagelec.Repository;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Menagelec.Component;

public static class PdfPackagingListGenerator
{
    public static async Task GeneratePdfPackagingListOf(Commande commande, Collection<LigneCommande> ligneCommandes)
    {
        var packagingListStack = new Queue<PdfPackagingListRowStruct>();

        var packagingSize = 0;

        foreach (var ligneCommande in ligneCommandes)
        {
            var produit = await ProduitRepository.Read(ligneCommande.Produit);
            packagingListStack.Enqueue(new PdfPackagingListRowStruct
            {
                IdProduit = produit.IdProduit,
                Designation = produit.Designation,
                Quantite = ligneCommande.Quantite
            });
            packagingSize += ligneCommande.Quantite;
            Console.WriteLine(produit.IdProduit);
        }
        
        var document = Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(2, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(20));

                page.Content().Column(column =>
                {
                    column.Item().Text(descriptor =>
                    {
                        descriptor.AlignCenter();
                        descriptor.Span($"Liste de colisage de la commande n°{commande.Id}");
                    });
                    
                    column.Spacing(25);

                    column.Item()
                        .MinimalBox()
                        .Border(1)
                        .Table(async table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            table.Cell().Row(1).Column(1).Border(1).Padding(6).Text("Réf du produit").Underline();
                            table.Cell().Row(1).Column(2).Border(1).Padding(6).Text("Désignation").Underline();
                            table.Cell().Row(1).Column(3).Border(1).Padding(6).Text("Quantité").Underline();

                            uint index = 2;

                            while (packagingListStack.Count > 0)
                            {
                                var packagingRow = packagingListStack.Dequeue();
                                table.Cell().Row(index).Column(1).Border(1).Padding(3).Text(packagingRow.IdProduit.ToString());
                                table.Cell().Row(index).Column(2).Border(1).Padding(3).Text(packagingRow.Designation);
                                table.Cell().Row(index).Column(3).Border(1).Padding(3).Text(packagingRow.Quantite.ToString());
                                index++;
                            }
                        });
                    
                    column.Spacing(5);

                    column.Item().Text(descriptor =>
                    {
                        descriptor.AlignCenter();
                        descriptor.Span("Veillez à bien contrôler le contenu du colis à l'aide de cette liste devant le transporteur.")
                            .FontSize(8)
                            .FontColor("#ED1010");
                    });
                    
                    column.Spacing(10);

                    column.Item().Text(descriptor =>
                    {
                        descriptor.AlignLeft();
                        descriptor.Span(packagingSize > 1
                            ? $"Le colis contient {packagingSize} articles"
                            : $"Le colis contient {packagingSize} article");
                    });
                });
            });
        });

        var path = $"pdf/liste_colisage_n{commande.Id}-{DateTime.Now:yyyy-MM-dd-HHmm}.pdf";
        document.GeneratePdf(path);
        System.Diagnostics.Process.Start(Application.StartupPath + "/" + path);
    }
}