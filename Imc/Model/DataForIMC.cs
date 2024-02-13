using System.ComponentModel.DataAnnotations;
using Imc.Services;

namespace Imc.Model;

public class DataForIMC
{
    [Required(ErrorMessage = "É necessário digitar a altura para fazer o cálculo.")]
    public double? Altura { get; set; }
    [Required(ErrorMessage = "É necessário digitar o peso para fazer o cálculo.")]
    public double? Peso { get; set; }
    public StaticInfo.Sexo? Sexo { get; set; }
    public bool Idade65 { get; set; }
}