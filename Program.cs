
void PreencherEstoque()
{

    string? nomeProduto;
    int quantidadeProduto;
    double precoProduto;
    bool emEstoque;

    Console.WriteLine("Digite o nome do produto: ");
    nomeProduto = Console.ReadLine();

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
}
PreencherEstoque();