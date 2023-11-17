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

        public override bool Equals(object obj)
        {
            // Vérifier si l'objet en paramètre est nul ou n'est pas du type Client
            if (obj is Client otherClient)
            {
                // Comparer chaque attribut
                return
                    _idClient == otherClient._idClient &&
                    _civilite == otherClient._civilite &&
                    _nom == otherClient._nom &&
                    _prenom == otherClient._prenom &&
                    _adresse == otherClient._adresse &&
                    _ville == otherClient._ville &&
                    _cp == otherClient._cp &&
                    _mail == otherClient._mail &&
                    _tel == otherClient._tel;
            }
            return false;
        }

        // ChatGPT
        public override int GetHashCode()
        {
            // Utiliser XOR (^) pour combiner les codes de hachage des attributs
            return _idClient.GetHashCode() ^
                   (Civilite?.GetHashCode() ?? 0) ^
                   (Nom?.GetHashCode() ?? 0) ^
                   (Prenom?.GetHashCode() ?? 0) ^
                   (Adresse?.GetHashCode() ?? 0) ^
                   (Ville?.GetHashCode() ?? 0) ^
                   (Cp?.GetHashCode() ?? 0) ^
                   (Mail?.GetHashCode() ?? 0) ^
                   (Tel?.GetHashCode() ?? 0);
        }
        
        public override string ToString()
        {
            return $"Client {{ IdClient: {_idClient}, Civilite: {_civilite}, Nom: {_nom}, Prenom: {_prenom}, Adresse: {_adresse}, Ville: {_ville}, Cp: {_cp}, Mail: {_mail}, Tel: {_tel} }}";
        }
    }
}