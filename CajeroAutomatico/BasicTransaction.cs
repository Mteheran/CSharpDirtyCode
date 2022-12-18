namespace CajeroAutomatico.Domain.Abstract;

public class BasicTransaction
{
    protected string _request;

    protected string BuildTitle() =>
        $"""
        ______________________________________________________________________
        
                        {_request}
        ______________________________________________________________________
            
        """;
}