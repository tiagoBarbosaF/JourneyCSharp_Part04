using System;

namespace ByteBank
{
  static class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Metodo();
      }
      catch (DivideByZeroException)
      {
        Console.WriteLine("Não é possível divisão por 0!");
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);
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