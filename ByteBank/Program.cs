using System;
using System.IO;

namespace ByteBank
{
  static class Program
  {
    static void Main(string[] args)
    {
      CarregarContas();
    }

    private static void CarregarContas()
    {
      using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
      {
        leitor.LerProximaLinha();
        leitor.LerProximaLinha();
        leitor.LerProximaLinha();
      }
      // LeitorDeArquivo leitor = null;
      // try
      // {
      //   leitor = new LeitorDeArquivo("contas.txt");
      //   leitor.LerProximaLinha();
      //   leitor.LerProximaLinha();
      //   leitor.LerProximaLinha();
      // }
      // catch (IOException e)
      // {
      //   Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
      // }
      // finally
      // {
      //   if (leitor != null) leitor.Fechar();
      // }
    }

    private static void CreateConta()
    {
      try
      {
        ContaCorrente conta1 = new ContaCorrente(654, 654987);
        ContaCorrente conta2 = new ContaCorrente(654, 654321);

        // conta1.Transferir(10000, conta2);
        conta2.Sacar(10000);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);

        Console.WriteLine("\nInformações da INNER EXCEPTION:");
        Console.WriteLine(e.InnerException.Message);
        Console.WriteLine(e.InnerException.StackTrace);
      }
    }

    private static void Metodo()
    {
      TestaDivisao(0);
    }

    private static void TestaDivisao(int divisor)
    {
      Dividir(10, divisor);
    }

    private static int Dividir(int numero, int divisor)
    {
      try
      {
        return numero / divisor;
      }
      catch (Exception)
      {
        Console.WriteLine($"Exceção com número = {numero} e divisor = {divisor}");
        throw;
      }
    }
  }
}