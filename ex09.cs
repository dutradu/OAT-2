using System;

public class Program {
  public static void Main() {
    Console.Write("Informe a altura da pessoa (em metros): ");
    double altura = double.Parse(Console.ReadLine());

    Console.Write("Informe o sexo da pessoa (M para masculino e F para feminino): ");
    string sexo = Console.ReadLine();

    double pesoIdeal;
    if (sexo == "M") {
      pesoIdeal = (72.7 * altura) - 58;
    } else if (sexo == "F") {
      pesoIdeal = (62.1 * altura) - 44.7;
    } else {
      Console.WriteLine("Sexo inválido.");
      return;
    }

    Console.WriteLine("O peso ideal da pessoa é " + pesoIdeal + " kg.");
  }
}
