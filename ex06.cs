using System;
public class Program {
  public static void Main() {
    Console.Write("Informe o primeiro valor booleano (true/false): ");
    bool valor1 = bool.Parse(Console.ReadLine());
    Console.Write("Informe o segundo valor booleano (true/false): ");
    bool valor2 = bool.Parse(Console.ReadLine());

    if (valor1 && valor2) {
      Console.WriteLine("Ambos os valores são VERDADEIROS");
    } else if (!valor1 && !valor2) {
      Console.WriteLine("Ambos os valores são FALSOS");
    } else {
      Console.WriteLine("Os valores são diferentes");
    }
  }
}