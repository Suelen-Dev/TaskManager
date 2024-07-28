
void PreencherEstoque()
{

    string? nomeProduto;
    int quantidadeProduto;
    double precoProduto;
    bool emEstoque;

    Console.WriteLine("Digite o nome do produto: ");
    nomeProduto = Console.ReadLine();
    if (nomeProduto.Length > 50)

    {
        Console.WriteLine($"O {nomeProduto} do produto não pode" +
            " ser maior do que 50 caracteres. ");
        return;
    }

    Console.WriteLine("Digite a quantidade do produto: ");
    quantidadeProduto = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Digite o preço do produto: ");
    precoProduto = Convert.ToDouble(Console.ReadLine());

    emEstoque = quantidadeProduto > 0;

    Console.Clear();

    Console.WriteLine("Informações do produto : ");
    Console.WriteLine($"Nome: {nomeProduto}\n" +
        $"Quantidade: {quantidadeProduto}\n" +
        $"Preço: {precoProduto:C}\n" +
        $"Em estoque: {emEstoque}");

    if (emEstoque)
    {
        Console.WriteLine("O produto está em estoque.");
    }else 
    {
        Console.WriteLine("O produto não está em estoque.");
    }

    Console.WriteLine("Lista de produtos em estoque:");
    for (int i = 0; i < quantidadeProduto; i++)
    {
        Console.WriteLine($"{i + 1}. {nomeProduto}");
    }
}
PreencherEstoque();