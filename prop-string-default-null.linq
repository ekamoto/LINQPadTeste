<Query Kind="Program" />

void Main()
{
	var pessoa = new Pessoa();
	
	if(pessoa.Nome is null)
		Console.WriteLine("é nulo");
	else
		Console.WriteLine("não é nulo");
}

public class Pessoa {
	public string Nome { set; get; }
}
// You can define other methods, fields, classes and namespaces here