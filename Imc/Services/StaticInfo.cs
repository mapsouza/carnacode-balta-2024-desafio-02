using System.Globalization;

namespace Imc.Services;

public static class StaticInfo
{
    public enum Sexo
    {
        Masculino, Feminino
    }

    public static double? ToDouble(this string valor)
    {
        try
        {
            var x = double.Parse(valor);
            return x;
        }
        catch
        {
            return null;
        }
    }
}