<Query Kind="Program" />

void Main()
{
	List<Pessoa> listaPessoa;
	List<Pessoa> listaPessoa2 = null;
	
	Processador proc = new Processador();
	
	proc.Processa(listaPessoa2);
}

class Processador
{
	public void Processa(IList<Pessoa> lista)
	{
		foreach(var pessoa in lista)
		{
			Console.WriteLine("teste");
		}
	}
}

class Pessoa
{
	public string Nome { get; set; }
}

// Define other methods, classes and namespaces here
