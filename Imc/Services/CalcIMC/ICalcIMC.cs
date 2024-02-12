namespace Imc.Services.CalcIMC;
using Imc.Services;

public interface ICalcIMC
{
    public double? CalcularIMC(double? altura, double? peso);
}