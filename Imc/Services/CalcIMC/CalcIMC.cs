namespace Imc.Services.CalcIMC;

public class CalcIMC: ICalcIMC
{
    public double? CalcularIMC(double? altura, double? peso)
    {
        if (peso == null)
            return null;

        if (altura == null)
            return null;

        var alturaOK = (double)altura;
        if (altura > 2)
            alturaOK = (double)altura / 100;
        
        var _imc = (double)peso / ((double)alturaOK * (double)alturaOK);
        return Math.Round(_imc , 2);


    }
}