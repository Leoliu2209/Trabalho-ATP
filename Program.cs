double vcompra, vfinal;
char pagamento, cliente;
Console.WriteLine("Informe o valor total da compra:");
if (!double.TryParse(Console.ReadLine(), out vcompra) || vcompra <= 0)
{
    Console.WriteLine("Valor inválido. Encerrando.");
    return;
}

Console.WriteLine("Informe D para pagamento em dinheiro ou C para cartão.");
pagamento = Convert.ToChar(Console.ReadLine().ToUpper());

if (pagamento == 'D')
{
    Console.WriteLine("Pagamento em dinheiro.");
}
else if (pagamento == 'C')
{
    Console.WriteLine("Pagamento em cartão.");
}
else
{
    Console.WriteLine("Opção de pagamento inválida, saída do programa.");
    return;
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
    Console.WriteLine("Opção de cliente inválida, saída do programa.");
    return;
}

double desconto = 0;

// Desconto pelo tipo de pagamento
if (pagamento == 'D')
{
    desconto += vcompra <= 100 ? 5 : 10;
}
else if (pagamento == 'C')
{
    if (vcompra <= 100)
        desconto += 0;
    else if (vcompra <= 300)
        desconto += 5;
    else
        desconto += 10;
}

// Descontos adicionais para fidelidade
if (cliente == 'F' && vcompra > 200)
{
    desconto += 5;
}
if (pagamento == 'D' && cliente == 'F')
{
    desconto += 2;
}

if (desconto > 15)
{
    desconto = 15;
}

vfinal = vcompra * (1 - desconto / 100);

double vdesconto = vcompra - vfinal;

Console.WriteLine($"O valor original da sua compra seria de R$ {vcompra:F2}");
Console.WriteLine($"O percentual de desconto aplicado na sua compra é {desconto:F2}%");
Console.WriteLine($"O valor do desconto foi R$ {vdesconto:F2}");
Console.WriteLine($"O valor final da sua compra é de R$ {vfinal:F2}");
