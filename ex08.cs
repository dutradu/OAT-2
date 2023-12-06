using System;
public class Program {
  public static void Main() {
    Console.Write("Digite o primeiro valor: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo valor: ");
    int b = int.Parse(Console.ReadLine());

    Console.Write("Digite o terceiro valor: ");
    int c = int.Parse(Console.ReadLine());

    if (a > b) {
      int temp = a;
      a = b;
      b = temp;
    }

    if (b > c) {
      int temp = b;
      b = c;
      c = temp;
    }

    if (a > b) {
      int temp = a;
      a = b;
      b = temp;
    }

    Console.WriteLine("Valores em ordem decrescente: " + c + ", " + b + ", " + a);
  }
}
