namespace Banking.Models;
    public class Account
    {
    public int AccountNo {get; set;}
    public string Description { get; set; } = string.Empty;
    public decimal Balance { get; set; }

    public void Deposit(int accountNo, int amount)          //Asking for the account no and the amount they want to deposit
        {
        List<Account> accounts = new();

        var targaccounts = from t in accounts               //Finding the account they are looking for
                        where t.AccountNo == accountNo
                        select t;

        var targetaccount = targaccounts.FirstOrDefault();  //Pulling that account out of the list (should be only one)

        if (targetaccount is null)  //If it was unable to find a account, it will come back null
        {
        System.Console.WriteLine("No account matching that account number");
        }
        targetaccount.Balance =+ amount; //Adding the amount to the target account's balance

        System.Console.WriteLine($"The new balance is {targetaccount.Balance}");    //Returning the account balance

        }


        public void Withdraw(int accountNo, int amount)          //Asking for the account no and the amount they want to deposit
        {
        List<Account> accounts = new();

        var targaccounts = from t in accounts               //Finding the account they are looking for
                        where t.AccountNo == accountNo
                        select t;

        var targetaccount = targaccounts.FirstOrDefault();  //Pulling that account out of the list (should be only one)

        if (targetaccount is null)  //If it was unable to find a account, it will come back null
        {
        System.Console.WriteLine("No account matching that account number");
        }
        targetaccount.Balance =- amount; //Removing the amount to the target account's balance

        System.Console.WriteLine($"The new balance is {targetaccount.Balance}");    //Returning the account balance

        }

         public void Transfer(int accountNo,int ogaccount, int amount)          //Asking for the account no and what they want to transgfer
        {
        List<Account> accounts = new();
        var takeaccountl =from t in accounts               //Finding the account to take from
                        where t.AccountNo == ogaccount
                        select t;

        var targaccounts = from t in accounts               //Finding the account they are looking for
                        where t.AccountNo == accountNo
                        select t;

        var targetaccount = targaccounts.FirstOrDefault();  //Pulling that account out of the list (should be only one)
        var takeaccount = takeaccountl.FirstOrDefault();
        if (takeaccount is null)
        {
            System.Console.WriteLine("The account you are trying to send money from was not found");


        }
        if (targetaccount is null)
        {
            System.Console.WriteLine("The account you were attempting to send money to did not exisit");
        }

        

        }
        


    }
    
