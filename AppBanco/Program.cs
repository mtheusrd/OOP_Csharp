using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank");


// Classe é um modelo para criar objetos.
// Criar objeto dentro de uma classe

//ContaCorrente conta1 = new ContaCorrente();
//conta1.Titular = "Matheus R.";
//conta1.conta = "10123-X";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agencia Central";
//// conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Ivy Gabriel";
//conta2.conta = "12345-Y";
//conta2.numero_agencia = 30;
//conta2.nome_agencia = "Agencia Central";
////conta2.saldo = 300;

//Console.WriteLine("Saldo da Ivy pré transferencia:  " + conta2.saldo);
//Console.WriteLine("Saldo do Matheus pré transferencia:  " + conta1.saldo);
//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferencia Executada com sucesso? " +  transferencia);
//Console.WriteLine("Saldo da Ivy pós transferencia:  " + conta2.saldo);
//Console.WriteLine("Saldo do Matheus pós transferencia:  " + conta1.saldo);


//Console.WriteLine("Saldo do Matheus pos saque " + conta1.saldo);

//conta1.Depositar(60);
//Console.WriteLine("Saldo do Matheus pos deposito: " + conta1.saldo);


// Console fica esperando apertar uma tecla para sair.

//Cliente cliente = new Cliente();
//cliente.nome = "Matheus Luiz";
//cliente.cpf = "123456789";
//cliente.profissao = "Tecnico";

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = cliente;
//conta3.conta = "2513252-X";
//conta3.numero_agencia = 35;
//conta3.nomeagencia = "Agencia Central";


//Cliente sarah = new Cliente();

//ContaCorrente conta4 = new ContaCorrente(235, "123456-X");
//conta4.Saldo= -150;
//conta4.Titular = sarah;

//Console.WriteLine(conta4.Titular.Nome);
//Console.WriteLine(conta4.Numero_Agencia);
//Console.WriteLine(conta4.Conta);

ContaCorrente conta5 = new ContaCorrente(200, "123456-X");
ContaCorrente conta6 = new ContaCorrente(210, "123456-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();
