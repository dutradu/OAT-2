using System;
public class Program {
  public static void Main() {
    Console.Write("Informe um número: ");
    int num = int.Parse(Console.ReadLine());

    int result;

    if (num >= 0) {
      result = num * 2;
    } else {
      result = num * 3;
    }

    Console.WriteLine("O result é: {0}", result);
  }
}