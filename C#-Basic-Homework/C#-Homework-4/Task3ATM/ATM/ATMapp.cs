

namespace Task3.ATM
{
    public class ATMapp
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        private int Pin { get; set; }
        private int Money { get; set; }


        public ATMapp()
        {

        }
        public ATMapp(string firstName, string lastName, long cardNumber, int pin, int money)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Money = money;
            Pin = pin;
        }

        public int NumberPin()
        {
            return Pin;
        }

        public int MoneyBalance()
        {
            return Money;

        }






    }
}