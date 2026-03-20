double vcompra, vfinal = 0;
char pagamento, cliente;
Console.WriteLine("Informe o valor total da compra:");
vcompra = double.Parse(Console.ReadLine());

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

if (pagamento == 'D')
{
    if (vcompra <= 100)
        vfinal = vcompra * 0.95; // 5% desconto
    else
        vfinal = vcompra * 0.90; // 10% desconto
}
else if (pagamento == 'C')
{
    if (vcompra <= 100)
        vfinal = vcompra; // sem desconto
    else if (vcompra <= 300)
        vfinal = vcompra * 0.95; // exemplo de desconto para cartão
    else
        vfinal = vcompra * 0.90; // exemplo de desconto maior
}
else
{
    Console.WriteLine("Opção de pagamento inválida, saída do programa.");
    return;
}
Console.WriteLine("O valor final da sua compra é de R$ " + vfinal);

