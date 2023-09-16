using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmMachine
{


    public class HasCard : ATMState
    {
        private ATMMachine atmMachine;

        public HasCard(ATMMachine newATMMachine)
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
            Console.WriteLine("please enter your PIN number first, THANK YOU");
        }

        public void InsertPin(int pinEntered)
        {
            if (pinEntered == 1234)
            {
                Console.WriteLine("Your PIN is accepted ");
                atmMachine.correctPinEntered = true;
                atmMachine.SetATMState(atmMachine.GetHasPin());
            }
            else
            {

                Console.WriteLine("WRONG PIN, please cheack it");
                atmMachine.correctPinEntered = false;
                Console.WriteLine("Your card is takeout successfully");
                atmMachine.SetATMState(atmMachine.GetNoCardState());
            }
        }
    }

}








