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
        private int _pkFournisseur;

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
            get => _pkFournisseur;
            set => _pkFournisseur = value;
        }
        
        private const double Epsilon = 1e-10;
        
        public override bool Equals(object obj)
        {
            // Vérifier si l'objet en paramètre est nul ou n'est pas du type Produit
            if (obj is Produit otherProduit)
            {
                // Comparer chaque attribut
                return
                    _idProduit == otherProduit._idProduit &&
                    _designation == otherProduit._designation &&
                    _description == otherProduit._description &&
                    _dateAjout == otherProduit._dateAjout &&
                    _qte == otherProduit._qte &&
                    Math.Abs(_prix - otherProduit._prix) < Epsilon &&
                    _fichierImage == otherProduit._fichierImage &&
                    _pkFournisseur == otherProduit._pkFournisseur;
            }
            return false;
        }

        public override int GetHashCode()
        {
            // Utiliser XOR (^) pour combiner les codes de hachage des attributs
            return _idProduit.GetHashCode() ^
                   (Designation?.GetHashCode() ?? 0) ^
                   (Description?.GetHashCode() ?? 0) ^
                   DateAjout.GetHashCode() ^
                   Qte.GetHashCode() ^
                   Prix.GetHashCode() ^
                   (FichierImage?.GetHashCode() ?? 0) ^
                   PkFournisseur.GetHashCode();
        }

        public override string ToString()
        {
            return $"Produit {{ IdProduit: {_idProduit}, Designation: {_designation}, Description: {_description}, DateAjout: {_dateAjout}, Qte: {_qte}, Prix: {_prix}, FichierImage: {_fichierImage}, PkFournisseur: {_pkFournisseur} }}";
        }
    }
}