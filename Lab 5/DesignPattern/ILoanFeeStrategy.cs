using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal interface ILoanFeeStrategy
    {
        decimal CalculateFee(int days);
    }

    public class BookLoanFee : ILoanFeeStrategy
    {
        public decimal CalculateFee(int days) => days * 1.5m;  
    }

    public class MagazineLoanFee : ILoanFeeStrategy
    {
        public decimal CalculateFee(int days) => days * 1.0m;  
    }

    public class NewspaperLoanFee : ILoanFeeStrategy
    {
        public decimal CalculateFee(int days) => days * 0.5m;  
    }

    internal class Loan
    {
        private readonly ILoanFeeStrategy _loanFeeStrategy;

        public Loan(ILoanFeeStrategy loanFeeStrategy)
        {
            _loanFeeStrategy = loanFeeStrategy;
        }

        public decimal GetLoanFee(int days)
        {
            return _loanFeeStrategy.CalculateFee(days);
        }
    }

}
