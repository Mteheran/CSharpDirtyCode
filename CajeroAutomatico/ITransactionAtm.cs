namespace CajeroAutomatico.Domain.Abstract;

public interface ITransactionAtm{

    int ExecuteTransaction(int saldo);
}