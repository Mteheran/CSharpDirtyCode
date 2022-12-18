using System;
using CajeroAutomatico.Domain.Abstract;

namespace CajeroAutomatico.Domain.Core;
public class Deposit :BasicTransaction, ITransactionAtm
{
    public Deposit()
    {
        this._request = "ENTER THE AMOUNT YOU WANT TO DEPOSIT";
    }

    public int ExecuteTransaction(int balance)
    {
        Console.WriteLine(BuildTitle());
        int.TryParse(Console.ReadLine(), out int deposit);
        deposit = Math.Abs(deposit);
        int newBalance = balance + deposit;
        Console.WriteLine("YOUR DEPOSIT OF {0} WAS DONE CORRECTLY!!!!", deposit);

        return newBalance;
    }
}