using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace atmMachine
{


    public class ATMMachine
    {
        private ATMState hasCard;
        private ATMState noCard;
        private ATMState hasCorrectPin;
        private ATMState atmOutOfMoney;

        private ATMState atmState;
        public int cashInMachine = 2000;
        public bool correctPinEntered = false;

        public ATMMachine()
        {
            hasCard = new HasCard(this);
            noCard = new NoCard(this);
            hasCorrectPin = new HasPin(this);
            atmOutOfMoney = new NoCash(this);

            atmState = noCard;

            if (cashInMachine < 0)
            {
                atmState = atmOutOfMoney;
            }
        }

        public void SetATMState(ATMState newATMState)
        {
            atmState = newATMState;
        }

        public void SetCashInMachine(int newCashInMachine)
        {
            cashInMachine = newCashInMachine;
        }

        public void InsertCard()
        {
            atmState.InsertCard();
        }

        public void EjectCard()
        {
            atmState.EjectCard();
        }

        public void RequestCash(int cashToWithdraw)
        {
            atmState.RequestCash(cashToWithdraw);
        }

        public void InsertPin(int pinEntered)
        {
            atmState.InsertPin(pinEntered);
        }

        public ATMState GetYesCardState() { return hasCard; }
        public ATMState GetNoCardState() { return noCard; }
        public ATMState GetHasPin() { return hasCorrectPin; }
        public ATMState GetNoCashState() { return atmOutOfMoney; }
    }

}
