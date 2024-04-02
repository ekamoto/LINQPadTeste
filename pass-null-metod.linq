<Query Kind="Program" />

void Main()
{
	
	var processaPessoa = new Processa();
	processaPessoa.ProcessaPessoa(null);
	
}

class Pessoa
{
	public string Nome { get; set; }
}

class Processa
{
	public void ProcessaPessoa(Pessoa pessoa)
	{
		Console.WriteLine(pessoa?.Nome);
	}
}

// You can define other methods, fields, classes and namespaces here
