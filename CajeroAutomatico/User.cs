using CajeroAutomatico.Transversal.Constants;

namespace CajeroAutomatico.Domain.Entity;

public class User
{
    public User()
    {
        Balance =AtmConstants.IntialAmout;    
    }

    public int Balance { get; set; }
}