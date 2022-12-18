using System;
using CajeroAutomatico.Domain.Core;
using CajeroAutomatico.Domain.Entity;

namespace CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new();
            Atm atm = new Atm(user);
            atm.Init();     
        }
    }
}
