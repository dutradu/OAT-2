using System;
public class Program {
  public static void Main() {
    Console.Write("Informe o valor da variável: ");
    int var = int.Parse(Console.ReadLine());

    if (var % 2 == 0) {
      var += 5;
    } else {
      var += 8;
    }

    Console.WriteLine("Resultado: " + var);
  }
}
