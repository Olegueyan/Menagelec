using System;

namespace Menagelec.Entity
{
    public class Client
    {
        private readonly int? _idClient;
        private string _civilite;
        private string _nom;
        private string _prenom;
        private string _adresse;
        private string _ville;
        private string _cp;
        private string _mail;
        private string _tel;

        public Client(int? idClient)
        {
            _idClient = idClient;
        }
        
        public Client() : this(null)
        {
            // NOTHING TO IMPLEMENT
        }
        
        public int? IdClient => _idClient;

        public string Civilite
        {
            get => _civilite;
            set => _civilite = value;
        }
        
        public string Nom
        {
            get => _nom;
            set => _nom = value;
        }
        
        public string Prenom
        {
            get => _prenom;
            set => _prenom = value;
        }
        
        public string Adresse
        {
            get => _adresse;
            set => _adresse = value;
        }
        
        public string Ville
        {
            get => _ville;
            set => _ville = value;
        }
        
        public string Cp
        {
            get => _cp;
            set => _cp = value;
        }
        
        public string Mail
        {
            get => _mail;
            set => _mail = value;
        }
        
        public string Tel
        {
            get => _tel;
            set => _tel = value;
        }
    }
}