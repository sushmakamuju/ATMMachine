using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmMachine
{
    using System;

    public class HasPin : ATMState
    {
        private ATMMachine atmMachine;

        public HasPin(ATMMachine newATMMachine)
        {
            atmMachine = newATMMachine;
        }

        public void InsertCard()
        {
            Console.WriteLine("Alert! you cannot enter more than 1 card at a time , please wait");
        }

        public void EjectCard()
        {
            Console.WriteLine("Your card is taken out  successfully");
            atmMachine.SetATMState(atmMachine.GetNoCardState());
        }

        public void RequestCash(int cashToWithdraw)
        {
            if (cashToWithdraw > atmMachine.cashInMachine)
            {
                Console.WriteLine("You don't have that much cash available");
                Console.WriteLine("Your card is taken out  successfully");
                atmMachine.SetATMState(atmMachine.GetNoCardState());
            }
            else
            {
                Console.WriteLine(cashToWithdraw + " is provided by the machine");
                atmMachine.SetCashInMachine(atmMachine.cashInMachine - cashToWithdraw);
                Console.WriteLine("Your card is taken out  successfully");
                atmMachine.SetATMState(atmMachine.GetNoCardState());

                if (atmMachine.cashInMachine <= 0)
                {
                    atmMachine.SetATMState(atmMachine.GetNoCashState());
                }
            }
        }

        public void InsertPin(int pinEntered)
        {
            Console.WriteLine("You already entered a PIN");
        }
    }

}






