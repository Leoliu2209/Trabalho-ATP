double vtotal, vfinal;
char pagamento, cliente;
Console.WriteLine("Informe o valor total da compra:");
vtotal = double.Parse(Console.ReadLine());

Console.WriteLine("Informe D para pagamento em dinheiro ou C para cartão.");
pagamento = Convert.ToChar(Console.ReadLine().ToUpper());

if (pagamento == 'D')
{
    Console.WriteLine("Pagamento em dinheiro.");
}
if (pagamento== 'C')
{
    Console.WriteLine("Pagamento em cartão.");
}
else
{
    Console.WriteLine("Opção Inválida. Tente novamente");
}


Console.WriteLine("Informe N para cliente normal ou F para cliente fidelidade.");
cliente = Convert.ToChar(Console.ReadLine().ToUpper());

if (cliente == 'N')
{
    Console.WriteLine("Cliente Normal");
}
else if (cliente == 'F')
{
    Console.WriteLine("Cliente Fidelidade");
}
else
{
    Console.WriteLine("Opção Inválida. Tente novamente");
}

if (pagamento == 'D' && vtotal < 100)
{
 vtotal = vfinal * 0.95; // 5% de desconto
}