<Query Kind="Program" />

void Main()
{
	
	var listaProduto = new List<Produto>();
	
	for(int i = 0 ; i < 100 ; i++)
	{
		string categoria = i%2==0?"Perecível":"Limpeza";
		
		listaProduto.Add(new Produto("produto_"+i, 100, categoria));	
	}
	
	Dictionary<string, List<Produto>> listDictionary = listaProduto.GroupBy(t => t.categoria).ToDictionary(p => p.Key, p=>p.ToList());
	
	foreach(var produto in listDictionary)
	{
		Console.WriteLine("------------------" + produto.Key + "------------------");
		foreach(var prod in produto.Value)
		{
			Console.WriteLine(prod.nome);	
		}
	}
}

class Produto {

	public string nome;
	public double valor;
	public string categoria;
	
	public Produto(string nome, double valor, string categoria) {
	
		this.nome = nome;
		this.valor = valor;
		this.categoria = categoria;
	}
}