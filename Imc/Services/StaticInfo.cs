using System.Globalization;
using Imc.Model;

namespace Imc.Services;

public static class StaticInfo
{
    public enum Sexo
    {
        Masculino,
        Feminino
    }

    public static List<HistoryText> ListaTextoIMC()
    {
        return
        [
            new HistoryText()
            {
                Id=1,
                Title = "Baixo peso muito grave ☠️",
                Text = "Você precisa de um tratamento urgente! Procure um médico ou psicólogo"
            },

            new HistoryText()
            {
                Id=2,
                Title = "Grave ⛔️",
                Text = "Anorexia e Bulimia são doenças graves!! Procure um especialista e cuide da sua saúde!"
            },

            new HistoryText()
            {
                Id=3,
                Title = "Baixo peso ⚠️",
                Text = "Você precisa comer mais feijão com arroz meu amigo!"
            },

            new HistoryText()
            {
                Id=4,
                Title = "Peso normal ✅",
                Text = "Parabéns, você está no seu peso ideal, continue mantendo este estilo!"
            },
            new HistoryText()
            {
                Id=5,
                Title = "Sobrepeso ⚠️", 
                Text = "Estamos quase lá! Faça alguns ajustes para ficar no peso ideal!"
            },
            new HistoryText()
            {
                Id=6,
                Title = "Obesidade grau I ⛔️", 
                Text = "O que você está fazendo aí? Vai já pra academia e para de comer!"
            },
            new HistoryText()
            {
                Id=7,
                Title = "Obesidade grau II 😈", 
                Text = "Mais um pouco vou te indicar meu médico para cortar o seu estomago!"
            },
            new HistoryText()
            {
                Id=8,
                Title = "Obesidade grau III 💀☢️🪦", 
                Text = "Situação ficou crítica para você! Procura um médico e vai cuidar dessa pança !!"
            }

        ];
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

    public static string? DateFormat(this DateTime date)
    {
        var ts = new TimeSpan(DateTime.Now.Ticks - date.Ticks);
        double delta = Math.Abs(ts.TotalSeconds);

        if (delta < 60)
        {
            return "< 1 min";
        }

        if (delta < 60 * 2)
        {
            return "1 min";
        }

        if (delta < 45 * 60)
        {
            return ts.Minutes + " min";
        }

        if (delta < 90 * 60)
        {
            return "1h";
        }

        if (delta < 24 * 60 * 60)
        {
            return ts.Hours + " hs";
        }

        if (delta < 48 * 60 * 60)
        {
            return "ontem";
        }

        if (date.Date >= DateTime.Now.Date.AddDays(-6))
        {
            var cultureDate = new System.Globalization.CultureInfo("pt-BR");
            return cultureDate.DateTimeFormat.GetAbbreviatedDayName(date.DayOfWeek);
        }

        if (date.Year.Equals(DateTime.Now.Year))
        {
            var cultureDate = new System.Globalization.CultureInfo("pt-BR");
            return string.Format(cultureDate, "{0:dd MMM}", date);
        }

        return string.Format("{0:dd/MM/yy}", date);
    }
}