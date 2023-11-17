using System;

namespace Menagelec.Entity
{
    public class Produit
    {
        private readonly int? _idProduit;
        private string _designation;
        private string _description;
        private DateTime _dateAjout;
        private int _qte;
        private double _prix;
        private string _fichierImage;
        private int _pk_fournisseur;

        public Produit(int? idProduit)
        {
            _idProduit = idProduit;
        }
        
        public Produit() : this(null)
        {
            // NOTHING TO IMPLEMENT
        }
        
        public int? IdProduit => _idProduit;
        
        public string Designation
        {
            get => _designation;
            set => _designation = value;
        }
        
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public DateTime DateAjout
        {
            get => _dateAjout;
            set => _dateAjout = value;
        }
        
        public int Qte
        {
            get => _qte;
            set => _qte = value;
        }
        
        public double Prix
        {
            get => _prix;
            set => _prix = value;
        }
        
        public string FichierImage
        {
            get => _fichierImage;
            set => _fichierImage = value;
        }

        public int PkFournisseur
        {
            get => _pk_fournisseur;
            set => _pk_fournisseur = value;
        }
    }
}