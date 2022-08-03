using MenorPreço;


Produto prod1 = new Produto();

prod1.nome = "Bola AntiStress";
prod1.fabricante = "Data Logic";
prod1.codigobarra = 12345678;
prod1.valorun = 180;
prod1.valorven = 200;
prod1.qtd = 85;


Console.WriteLine("Bem Vindo ao Menor Preço!\n");
Console.WriteLine("Nome do Item: " + prod1.nome);
Console.WriteLine("Nome do Fabricante: " + prod1.fabricante);
Console.WriteLine("Codigo de Barras: " + prod1.codigobarra);
Console.WriteLine("Quantidade: " + prod1.qtd);
Console.WriteLine("Preço Unitário: R$" + prod1.valorun);
Console.WriteLine("Preço de Compra: R$" + prod1.valorven);

Console.ReadKey();



