using System;
using CajeroAutomatico.Domain.Abstract;

namespace CajeroAutomatico.Domain.Core;

internal class Withdraw : BasicTransaction, ITransactionAtm
{
    public Withdraw()
    {
        this._request = "ENTER THE AMOUNT YOU WANT TO WITHDRAW";
    }

    public int ExecuteTransaction(int balance)
    {
        Console.WriteLine(BuildTitle());
        int.TryParse(Console.ReadLine(), out int withdraw);
        if (balance >= withdraw)
        {
            int newBalance = balance - withdraw;
            Console.WriteLine("YOUR WITHDRAWAL OF {0} WAS DONE SUCCESSFULLY", withdraw);
            return newBalance;
        }

        Console.WriteLine("INSUFFICIENTE FUNDS");
        return balance;
    }
}