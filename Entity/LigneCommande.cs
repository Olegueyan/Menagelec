using System;

namespace Menagelec.Entity
{
    public class LigneCommande
    {
        private int _produit;
        private int _commande;
        private int _quantite;
        
        public int Produit
        {
            get => _produit;
            set => _produit = value;
        }
        
        public int Commande
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