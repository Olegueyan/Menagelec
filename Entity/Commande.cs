using System;

namespace Menagelec.Entity
{
    public class Commande
    {
        private readonly int? _id;
        private DateTime _date;
        private int _estPayee;
        private int _estExpediee;
        private int _client;

        public Commande(int? id)
        {
            _id = id;
        }
        
        public Commande() : this(null)
        {
            // NOTHING TO IMPLEMENT
        }
        
        public int? Id => _id;

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }
        
        public int EstPayee
        {
            get => _estPayee;
            set => _estPayee = value;
        }
        
        public int EstExpediee
        {
            get => _estExpediee;
            set => _estExpediee = value;
        }

        public int Client
        {
            get => _client;
            set => _client = value;
        }
        
        public override bool Equals(object obj)
        {
            // Vérifier si l'objet en paramètre est nul ou n'est pas du type Commande
            if (obj is Commande otherCommande)
            {
                // Comparer chaque attribut
                return
                    _id == otherCommande._id &&
                    _date == otherCommande._date &&
                    _estPayee == otherCommande._estPayee &&
                    _estExpediee == otherCommande._estExpediee &&
                    _client == otherCommande._client;
            }
            return false;
        }

        public override int GetHashCode()
        {
            // Utiliser XOR (^) pour combiner les codes de hachage des attributs
            return _id.GetHashCode() ^
                   Date.GetHashCode() ^
                   EstPayee.GetHashCode() ^
                   EstExpediee.GetHashCode() ^
                   Client.GetHashCode();
        }

        public override string ToString()
        {
            return $"Commande {{ Id: {_id}, Date: {_date}, EstPayee: {_estPayee}, EstExpediee: {_estExpediee}, Client: {_client} }}";
        }
    }
}