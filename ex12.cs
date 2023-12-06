using System;

public class Program
{
    public static void Main()
    {
        int idAluno;
        double nota1, nota2, nota3, mediaExercicios, mediaAproveitamento;
        string conceito;

        Console.Write("Informe o número de identificação do aluno: ");
        idAluno = int.Parse(Console.ReadLine());

        Console.Write("Informe a primeira nota: ");
        nota1 = double.Parse(Console.ReadLine());

        Console.Write("Informe a segunda nota: ");
        nota2 = double.Parse(Console.ReadLine());

        Console.Write("Informe a terceira nota: ");
        nota3 = double.Parse(Console.ReadLine());

        Console.Write("Informe a média dos exercícios: ");
        mediaExercicios = double.Parse(Console.ReadLine());

        mediaAproveitamento = (nota1 + nota2 * 2 + nota3 * 3 + mediaExercicios) / 7;

        if (mediaAproveitamento >= 90)
        {
            conceito = "A";
        }
        else if (mediaAproveitamento >= 75)
        {
            conceito = "B";
        }
        else if (mediaAproveitamento >= 60)
        {
            conceito = "C";
        }
        else if (mediaAproveitamento >= 40)
        {
            conceito = "D";
        }
        else
        {
            conceito = "E";
        }

        Console.WriteLine("Número de identificação: " + idAluno);
        Console.WriteLine("Nota 1: " + nota1);
        Console.WriteLine("Nota 2: " + nota2);
        Console.WriteLine("Nota 3: " + nota3);
        Console.WriteLine("Média dos exercícios: " + mediaExercicios);
        Console.WriteLine("Média de aproveitamento: " + mediaAproveitamento.ToString("F2"));
        Console.WriteLine("Conceito: " + conceito);

        if (conceito == "A" || conceito == "B" || conceito == "C")
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}
