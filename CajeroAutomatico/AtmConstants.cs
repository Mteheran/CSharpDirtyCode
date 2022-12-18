using System.Text;

namespace CajeroAutomatico.Transversal.Constants;

public static class AtmConstants
{
    public const int IntialAmout = 5000;
    public static string Menu = BuildMenu();

    private static string BuildMenu()
    {
        StringBuilder menuBuilder = new StringBuilder();
        menuBuilder.AppendLine("______________________________________________________________________");
        menuBuilder.AppendLine("");
        menuBuilder.AppendLine("                   BIENVENIDO AL CAJERO AUTOMÁTICO");
        menuBuilder.AppendLine("______________________________________________________________________");
        menuBuilder.AppendLine("");
        menuBuilder.AppendLine("      1.- DESEA DEPOSITAR");
        menuBuilder.AppendLine("      2.- DESEA CONSULTAR SU SALDO");
        menuBuilder.AppendLine("      3.- DESEA RETIRAR");
        menuBuilder.AppendLine("      4.- DESEA SALIR");
        menuBuilder.AppendLine("______________________________________________________________________");
        menuBuilder.AppendLine("");

        return menuBuilder.ToString();
    }
}