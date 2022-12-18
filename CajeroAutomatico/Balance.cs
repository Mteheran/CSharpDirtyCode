using System;
using CajeroAutomatico.Domain.Abstract;

namespace CajeroAutomatico.Domain.Core;
public class Balance : BasicTransaction, ITransactionAtm
{
    public Balance()
    {
        _request = "CHECK BALANCE";
    }

    public int ExecuteTransaction(int balance)
    {
        Console.WriteLine(BuildTitle());
        Console.WriteLine($"YOUR BALANCE IS: ${balance}");
    
        return balance;
    }
}