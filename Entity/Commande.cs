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
    }
}