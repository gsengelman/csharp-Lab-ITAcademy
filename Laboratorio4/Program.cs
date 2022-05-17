ContaCorrente minhaConta = new ContaCorrente(340);
minhaConta.CriarConta("Marcos");
Console.WriteLine("Data de criacao da conta: {0}", minhaConta.CriacaoConta);
Console.WriteLine("Nome do titular: {0}", minhaConta.NomeTitular);

minhaConta.Depositar(100);
minhaConta.Depositar(200);
minhaConta.Sacar(300);
minhaConta.Sacar(40);

Console.WriteLine("Saldo atual: {0}", minhaConta.Saldo);
Console.WriteLine("Saldo medio: {0}", minhaConta.SaldoMedio);