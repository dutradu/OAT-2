using System;

public class Program {
  public static void Main() {
    Console.Write("Informe o nome da pessoa: ");
    string nome = Console.ReadLine();

    Console.Write("Informe o sexo da pessoa [[M ou F]]: ");
    char sexo = char.Parse(Console.ReadLine());

    Console.Write("Informe o estado civil da pessoa [[SOLTEIRO / CASADO / DIVORCIADO]]: ");
    string eCivil = Console.ReadLine();

    if (sexo == 'F' && eCivil == "CASADO") {
      Console.Write("Informe o tempo de casamento em anos: ");
      int tempCas = int.Parse(Console.ReadLine());

      Console.WriteLine("A pessoa {0} está casada há {1} anos.", nome, tempCas);
    } else {
      Console.WriteLine("A pessoa {0} é do sexo {1} e estado civil {2}.", nome, sexo, eCivil);
    }
  }
}