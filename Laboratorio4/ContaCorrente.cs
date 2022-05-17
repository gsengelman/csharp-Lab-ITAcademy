using System;

class ContaCorrente {
    private decimal saldo;
    private DateTime criacaoConta;
    private string nomeTitular;
    private decimal acumulador;
    private decimal saldoAcumulado;
    private decimal saldoMedio;
    public void Depositar(decimal val)
    {
        saldo = saldo + val;
        acumulador += 1;
        saldoAcumulado += saldo;
    }
    public void Sacar(decimal val)
    {
        saldo = saldo - val;
        acumulador += 1;
        saldoAcumulado += saldo;
    }
    public void CriarConta(string nome)
    {
        criacaoConta = DateTime.Now;
        nomeTitular = nome;
        acumulador = 1;
        saldoAcumulado = saldo;
    }
    public decimal Saldo => saldo;
    public DateTime CriacaoConta => criacaoConta;
    public string NomeTitular => nomeTitular;
    public ContaCorrente(decimal val)
    {
        saldo = val;
    }
    public decimal SaldoMedio
    {
        get {
            saldoMedio = saldoAcumulado/acumulador;
            return saldoMedio;
        }
    }

}
