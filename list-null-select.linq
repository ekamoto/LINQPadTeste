<Query Kind="Program" />

void Main()
{
	var processador = new Processador();
	processador.AddPessoa(new Pessoa{
		Nome = "Leandro",
		Codigo = 1
	});
	processador.AddPessoa(new Pessoa{
		Nome = "Priscila",
		Codigo = 2
	});
	
	List<Pessoa> lPessoa = new List<Pessoa>();
	// Dando select e toArray em uma lista vazia
	// e passando para um método que executa contains
	// não dá erro
	int[] codigos = lPessoa.Select(x => x.Codigo).ToArray();
	Console.WriteLine(codigos);
	
	processador.Processa(codigos);
	
	
	List<Pessoa> listaNula = null;
	// Esse código abaixo da erro
	//listaNula.Select(x=>x.Nome=="");
}

public class Pessoa
{
	public string Nome { get; set; }
	public int Codigo { get; set; }
}

class Processador
{
	public List<Pessoa> listaPessoas{ get; set; }
	
	public Processador()
	{
		listaPessoas = new List<Pessoa>();
	}
	
	public void AddPessoa(Pessoa pessoa)
	{
		listaPessoas.Add(pessoa);
	}
	
	public void Processa(int[] codigos)
	{
		var itens = listaPessoas.Where(x=> codigos.Contains(x.Codigo)).ToList();
		foreach(var item in itens)
		{
			Console.WriteLine(item.Nome);
		}
	}
}

// You can define other methods, fields, classes and namespaces here
