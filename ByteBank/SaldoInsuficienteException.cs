using System;

namespace ByteBank
{
  public class SaldoInsuficienteException : OperacaoFinanceiraException
  {
    public decimal Saldo { get; }
    public decimal ValorSaque { get; }

    public SaldoInsuficienteException()
    {
    }

    public SaldoInsuficienteException(string message) : base(message)
    {
    }

    public SaldoInsuficienteException(decimal saldo, decimal valorSaque) : this(
      $"Tentativa de saque de {valorSaque}, com saldo de {saldo}")
    {
      Saldo = saldo;
      ValorSaque = valorSaque;
    }
  }
}