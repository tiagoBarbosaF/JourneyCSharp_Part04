﻿using System;
using System.IO;

namespace ByteBank
{
  public class LeitorDeArquivo : IDisposable
  {
    public string Arquivo { get; }

    public LeitorDeArquivo(string arquivo)
    {
      Arquivo = arquivo;

      // throw new FileNotFoundException();
      Console.WriteLine($"Abringo arquivo: {arquivo}");
    }

    public string LerProximaLinha()
    {
      Console.WriteLine("Lendo linha...");

      // throw new IOException();
      return "Linha do arquivo";
    }

    public void Dispose()
    {
      Console.WriteLine("Fechando arquivo.");
    }
  }
}