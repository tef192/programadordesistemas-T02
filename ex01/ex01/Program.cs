Console.WriteLine("Escolha uma opção de pagamento: 1 - Pix; 2- Débito ou 3 - Crédito");
int pagamento = int.Parse(Console.ReadLine());
switch (pagamento)
{
    case 1:
        Console.WriteLine("Pagar com pix");
        break;

    case 2:
        Console.WriteLine("Pagar com débito");
        break;

    case 3:
        Console.WriteLine("Pagar com crédito");
        break;

    default:
        break;
}

