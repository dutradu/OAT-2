using System;

public class Program {
  public static void Main() {
    double peso, altura, imc;

    Console.Write("Informe o peso em kg: ");
    peso = double.Parse(Console.ReadLine());

    Console.Write("Informe a altura em metros: ");
    altura = double.Parse(Console.ReadLine());

    imc = peso / (altura * altura);

    Console.Write("IMC = " + imc.ToString("F2") + " - Condição: ");

    if (imc < 18.5) {
      Console.WriteLine("Abaixo do peso");
    } else if (imc < 25) {
      Console.WriteLine("Peso normal");
    } else if (imc < 30) {
      Console.WriteLine("Acima do peso");
    } else {
      Console.WriteLine("Obeso");
    }
  }
}
