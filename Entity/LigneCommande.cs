using System;

namespace Menagelec.Entity
{
    public class LigneCommande
    {
        private Produit _produit;
        private Commande _commande;
        private int _quantite;
        
        public Produit Produit
        {
            get => _produit;
            set => _produit = value;
        }
        
        public Commande Commande
        {
            get => _commande;
            set => _commande = value;
        }

        public int Quantite
        {
            get => _quantite;
            set => _quantite = value;
        }
    }
}