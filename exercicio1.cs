Produto p = new Produto("Celular", 1500);

p.ExibirDetalhes();

p.AlterarPreco(-200); 

p.AlterarPreco(1200);
p.ExibirDetalhes();

class Produto
{
    private string nome;
    private decimal preco;

    public Produto(string nome, decimal preco)
    {
        this.nome = nome;

        if (preco < 0)
        {
            Console.WriteLine("Erro: o preço não pode ser negativo. Preço definido como 0.");
            this.preco = 0;
        }
        else
        {
            this.preco = preco;
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {nome} | Preço: {preco:C2}");
    }

    public void AlterarPreco(decimal novoPreco)
    {
        if (novoPreco < 0)
        {
            Console.WriteLine("Erro: o preço não pode ser negativo.");
            return;
        }

        preco = novoPreco;
    }
}
