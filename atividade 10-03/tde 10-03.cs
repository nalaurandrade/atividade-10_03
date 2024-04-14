using System;

class Aluno
{
    public int RA { get; set; }
    public string Nome { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public double NotaFinal { get; set; }

    public void CalcularMedia()
    {
        NotaFinal = (NotaProva + NotaTrabalho) / 2;
    }

    public bool CalcularNotaFinal()
    {
        double mediaFinal = (NotaFinal + NotaProva) / 2;
        double notaProvaFinal = 10 - mediaFinal;
        Console.WriteLine($"Nota necessária na prova final: {notaProvaFinal}");
        if (notaProvaFinal <= 3 && mediaFinal >= 5)
        {
            Console.WriteLine("Aluno Aprovado!");
            return true;
        }
        else
        {
            Console.WriteLine("Aluno Reprovado!");
            return false;
        }
    }

    public void ImprimirNotaFinal()
    {
        Console.WriteLine($"Nota Final: {NotaFinal}");
    }

    public void ReceberDados()
    {
        Console.Write("Digite o RA do aluno: ");
        RA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o Nome do aluno: ");
        Nome = Console.ReadLine();
        Console.Write("Digite a Nota da Prova: ");
        NotaProva = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a Nota do Trabalho: ");
        NotaTrabalho = Convert.ToDouble(Console.ReadLine());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        aluno.ReceberDados();
        aluno.CalcularMedia();
        bool aprovado = aluno.CalcularNotaFinal();
        aluno.ImprimirNotaFinal();
    }
}
