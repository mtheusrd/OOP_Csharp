using System;
using Lanchonete;

Lanchonete.Cliente cliente1 = new Cliente();
cliente1.nome_cli = "Matheus Luiz";
cliente1.end_cli = "Rua Paracaima, 123";
cliente1.bairro_cli = "Pechincha";


Lanchonete.Artigo artigo1 = new Artigo();
artigo1.sand_nome = "X-Tudão";
artigo1.sand_preço = 8.00;

Console.WriteLine(cliente1.nome_cli);
Console.WriteLine(cliente1.end_cli);
Console.WriteLine(cliente1.bairro_cli);
Console.WriteLine();
Console.WriteLine(artigo1.sand_nome);
Console.WriteLine("R$" + artigo1.sand_preço);
