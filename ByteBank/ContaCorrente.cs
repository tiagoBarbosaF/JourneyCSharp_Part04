// using _05_ByteBank;

using System;

namespace ByteBank
{
  public class ContaCorrente
  {
    public static int TotalDeContasCriadas { get; private set; }
    private static int _taxaOperacao;
    public int ContadorSaquesNaoPermitidos { get; private set; }
    public int ContadorTransferenciasNaoPermitidas { get; private set; }

    public Cliente Titular { get; set; }

    public int Agencia { get; }
    public int Numero { get; }

    private decimal _saldo = 100;

    public decimal Saldo
    {
      get { return _saldo; }
      set
      {
        if (value < 0)
          return;

        _saldo = value;
      }
    }


    public ContaCorrente(int agencia, int numero)
    {
      if (agencia <= 0)
        throw new ArgumentException("O argumento agenda deve ser maior que 0.", nameof(agencia));

      if (numero <= 0)
        throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));

      Agencia = agencia;
      Numero = numero;

      TotalDeContasCriadas++;
      _taxaOperacao = 30 / TotalDeContasCriadas;
    }


    public void Sacar(decimal valor)
    {
      if (valor < 0)
        throw new ArgumentException("Valor de saque não pode ser negativo", nameof(valor));

      if (_saldo < valor)
      {
        ContadorSaquesNaoPermitidos++;
        throw new SaldoInsuficienteException(_saldo, valor);
      }

      _saldo -= valor;
    }

    public void Depositar(decimal valor)
    {
      _saldo += valor;
    }


    public void Transferir(decimal valor, ContaCorrente contaDestino)
    {
      if (_saldo < valor)
        throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));

      try
      {
        Sacar(valor);
      }
      catch (SaldoInsuficienteException e)
      {
        ContadorTransferenciasNaoPermitidas++;
        throw new OperacaoFinanceiraException("Operação não realizada.", e);
      }

      contaDestino.Depositar(valor);
    }
  }
}