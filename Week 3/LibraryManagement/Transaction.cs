using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal abstract class Transaction
    {
        private string _transactionId;
        private DateTime _transactionDate;
        private Member _member;

        public string TransactionID
        {
            get { return _transactionId; }
            set { _transactionId = value; }
        }

        public DateTime TransactionDate
        {
            get { return _transactionDate; }
            set { _transactionDate = value; }
        }

        public Member Member { 
            get { return _member; }
            set { _member = value; }
        }

        protected Transaction(string transactionID, DateTime transactionDate, Member member)
        {
            _transactionId = transactionID;
            _transactionDate = transactionDate;
            _member = member;
        }

        public abstract void Excute();

    }
}
