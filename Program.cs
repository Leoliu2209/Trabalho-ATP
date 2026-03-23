double vinicial, vfinal = 0;
char pagamento, cliente;
Console.WriteLine("Informe o valor total da compra:");
vinicial = double.Parse(Console.ReadLine());
Console.WriteLine("Informe D para pagamento em dinheiro ou C para cartão.");
pagamento = Convert.ToChar(Console.ReadLine().ToUpper());

if (pagamento == 'D')
{
    Console.WriteLine("Pagamento em dinheiro.");
}
if (pagamento == 'C')
{
    Console.WriteLine("Pagamento em cartão.");
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
double desconto = 0;

// Desconto baseado no pagamento
if (pagamento == 'D')
{
    if (vinicial <= 100)
        desconto += 5; // 5% desconto em dinheiro
    else
        desconto += 10; // 10% desconto em dinheiro
}
else if (pagamento == 'C')
{
    if (vinicial <= 100)
        desconto += 0; // sem desconto em cartão
    else if (vinicial <= 300)
        desconto += 5; // 5% para cartão acima de 100
    else
        desconto += 10; // 10% para cartão acima de 300
}

// Desconto adicional para cliente fidelidade
if (cliente == 'F' && vinicial > 200)
{
    desconto += 5; // 5% adicional
}
if (pagamento == 'D' && cliente == 'F')
{
    desconto += 2; // 2% de desconto
}
if (desconto > 15)
{
    desconto = 15;
}
vfinal = vinicial * (1 - desconto / 100);

double vdesconto = vinicial - vfinal;

Console.WriteLine("O valor original da sua compra seria de R$ " + vinicial);
Console.WriteLine("O percentual de desconto aplicado na sua compra é " + desconto + "%");
Console.WriteLine("O valor do desconto foi R$ " + vdesconto);
Console.WriteLine("O valor final da sua compra é de R$ " + vfinal);