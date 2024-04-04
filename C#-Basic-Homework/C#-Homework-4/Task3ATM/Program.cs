using Task3.ATM;

Console.WriteLine("Hello, World!");


ATMapp[] customers = new ATMapp[]
{
    new ATMapp("Bob","Bobsky",1234123412341234,1234,1000),
    new ATMapp("John", "Johnsky", 4321432143214321, 4321, 2000)

};


static void ATM(ATMapp[] customers)
{
    Console.WriteLine("Welcome to the ATM app");
    Console.WriteLine("Do you want to enter your card or register new card.Enter card 1,Register new card 2.");
    int logOrReg = int.Parse(Console.ReadLine());

    if (logOrReg == 1)
    {
        Account(customers);
    }
    else if (logOrReg == 2)
    {
        RegisterACC(customers);
    }

}


static void Account(ATMapp[] customers)
{
    bool repeat = false;
    while (!repeat)
    {
        Console.WriteLine($"Please enter your card number:");
        string cardNumberInput = Console.ReadLine();
        long cardNumber = long.Parse(cardNumberInput.Replace("-", ""));
        Console.WriteLine("Enter your pin:");
        int pinNumber = int.Parse(Console.ReadLine());
        bool customerExists = false;
        foreach (ATMapp Customer in customers)
        {
            if (cardNumber == Customer.CardNumber && pinNumber == Customer.NumberPin())
            {
                Console.WriteLine($"Welcome {Customer.FirstName} {Customer.LastName}");
                bool anotherTransaction = true;
                while (anotherTransaction)
                {
                    Console.WriteLine("What would you like to do:\r\n a.Check Balance\r\n b.Cash Withdrawal\r\n c.Cash Deposit");
                    char abc = char.Parse(Console.ReadLine());
                    if (abc == 'a')
                    {
                        Console.WriteLine($"Your balance is: {Customer.MoneyBalance()}");
                    }
                    else if (abc == 'b')
                    {
                        Console.WriteLine("Cash Withdrawal");
                        Console.Write("Enter amount to winthdrawal:");
                        int getMoney = int.Parse(Console.ReadLine());

                        if (getMoney <= Customer.MoneyBalance())
                        {
                            int moneyLeft = Customer.MoneyBalance() - getMoney;
                            Console.WriteLine($"You withdrew {getMoney}. You have {moneyLeft} left on your account.");
                            Console.WriteLine("Thank you for using the ATM app.");
                        }
                        else if (getMoney >= Customer.MoneyBalance())
                        {
                            Console.WriteLine("You dont have enought money");
                        }

                    }
                    else if (abc == 'c')
                    {
                        Console.WriteLine("Cash Deposit");
                        Console.Write("Enter amount to deposit:");
                        int cashDeposit = int.Parse(Console.ReadLine());
                        int deopsited = Customer.MoneyBalance() + cashDeposit;
                        Console.WriteLine($"You withdrew {cashDeposit}. You have {deopsited} left on your account.");
                        Console.WriteLine("Thank you for using the ATM app.");
                    }
                    if (anotherTransaction)
                    {
                        Console.WriteLine("Do you want to perform another transaction? (yes/no)");
                        string response = Console.ReadLine().ToLower();
                        if (response != "yes")
                        {
                            anotherTransaction = false;
                            Console.WriteLine("Thank you for using the ATM app.");
                        }
                    }
                }
                customerExists = true;
                repeat = true;
                break;
            }
        }
        if (!customerExists)
        {
            Console.WriteLine("Invalid card number or pin. Please try again.");
            Console.WriteLine("Do you want to try again? (yes/no)");
            string tryAgain = Console.ReadLine().ToLower();
            if (tryAgain != "yes")
            {
                break;
            }
        }
    }
}

static void RegisterACC(ATMapp[] customers)
{
    Console.WriteLine("Rgister a new card:");
    Console.WriteLine("Enter your first name:");
    string firstName = Console.ReadLine();
    Console.WriteLine("Enter your last name:");
    string lastName = Console.ReadLine();
    Console.WriteLine("Enter card number:");
    long cardNumber = long.Parse(Console.ReadLine().Replace("-", ""));
    Console.WriteLine("Enter pin:");
    int pin = int.Parse(Console.ReadLine());
    bool userExists = false;

    foreach (ATMapp Customer in customers)
    {
        if (cardNumber == Customer.CardNumber)
        {
            Console.WriteLine("Alredy a card number like that");
            userExists = true;
        }
    }
    if (!userExists)
    {
        Array.Resize(ref customers, customers.Length + 1);
        customers[customers.Length - 1] = new ATMapp(firstName, lastName, cardNumber, pin, 0);
        Console.WriteLine("You caccessfuly created new card");

    }

}

ATM(customers);


