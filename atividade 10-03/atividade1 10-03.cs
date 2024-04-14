using System;

class Aluno
{
    // Atributos
    public int RA { get; set; }
    public string Nome { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public double NotaFinal { get; set; }

    // Métodos

    // Calcula a média aritmética da nota final do aluno
    public void CalcularMedia()
    {
        NotaFinal = (NotaProva + NotaTrabalho) / 2;
    }

    // Calcula quanto o aluno precisa para a prova final e retorna se está aprovado
    public bool CalcularNotaFinal()
    {
        double mediaFinal = (NotaFinal + NotaProva) / 2;
        double notaNecessaria = 10 - mediaFinal;
        
        if (mediaFinal >= 7)
        {
            Console.WriteLine("Aluno Aprovado!");
            return true;
        }
        else if (mediaFinal < 6)
        {
            Console.WriteLine($"Aluno Reprovado! Média final: {mediaFinal}");
            return false;
        }
        else
        {
            Console.WriteLine($"Aluno de Prova Final! Nota necessária na prova final: {notaNecessaria}");
            return false;
        }
    }

    // Imprime a nota final na tela
    public void ImprimirNotaFinal()
    {
        Console.WriteLine($"Nota Final: {NotaFinal}");
    }

    // Recebe os dados digitados pelo usuário
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
        // Criando um objeto aluno
        Aluno aluno = new Aluno();

        // Recebendo os dados do aluno
        aluno.ReceberDados();

        // Calculando a média
        aluno.CalcularMedia();

        // Calculando a nota final e verificando se está aprovado
        bool aprovado = aluno.CalcularNotaFinal();

        // Imprimindo a nota final na tela
        aluno.ImprimirNotaFinal();
    }
}
