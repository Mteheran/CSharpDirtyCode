using System;
using System.Collections.Generic;
using CajeroAutomatico.Domain.Abstract;
using CajeroAutomatico.Domain.Entity;
using CajeroAutomatico.Transversal.Constants;

namespace CajeroAutomatico.Domain.Core;
public class Atm
{
    private User _user;
    private IDictionary<TypeTransaction, ITransactionAtm> _transactions = new Dictionary<TypeTransaction,ITransactionAtm> (){
        {TypeTransaction.Deposit,new Deposit()},
        {TypeTransaction.Balance,new Balance()},
        {TypeTransaction.Withdraw,new Withdraw()},
        {TypeTransaction.Exit,null}
    };

    public Atm(User user)
    {
        _user = user;
    }

    public void Init()
    {
        TypeTransaction option;
        do
        {
            Console.WriteLine(AtmConstants.Menu);
            string value = Console.ReadLine();
            bool valid = int.TryParse(value, out int optionSelected);
            option = Enum.Parse<TypeTransaction>(optionSelected);

            if (valid && _transactions.Keys.Contains(option))
            {
                Func<int,int> operation = GetOperation(option);
                _user.Balance = operation(_user.Balance);
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            Console.ReadKey();
        } while (option != TypeTransaction.Exit);
    }

    private Func<int,int> GetOperation(TypeTransaction option){
        ITransactionAtm operation = _transactions[option];
        if(operation is not null) return operation.ExecuteTransaction;

        return ExitApp;
    }

    private int ExitApp(int balance)
    {
        Console.WriteLine("           THANK YOU FOR USING THE ATM SYSTEM");
        Console.WriteLine("             SYSTEM MANICH, COME BACK SOON");

        return 0;
    }
}