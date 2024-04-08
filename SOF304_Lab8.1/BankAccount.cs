using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOF304_Lab8._1
{
    public class BankAccount
    {
        public interface IHostBank
        {
            bool AuthenticateAmount(string accountNumber,int amount);   //xác thực tài khoản trên số tiền cần rút
        }
        public interface IHSMModule
        {
            bool ValidatePin(string cardNumber, int pin);// xác thực mã pin
        }
        public class ATMCashWithdrawal
        {
            private readonly IHSMModule hsmModule;
            private readonly IHostBank hostbank;
            public ATMCashWithdrawal(IHSMModule hsmModule, IHostBank hostbank)
            {
                this.hsmModule = hsmModule;
                this.hostbank = hostbank;
            }
            public bool WithdrawAmount(string cardNumber,int amount,int pin)
            { 
                if(!hsmModule.ValidatePin(cardNumber, pin))
                {
                    return false;   
                }
                if(!hostbank.AuthenticateAmount(cardNumber, amount))
                {
                    return false;
                }
                return true;
            }
        }
    }
}
