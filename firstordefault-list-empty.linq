<Query Kind="Program" />

void Main()
{
	
	List<Pessoa> lista = null;
	
	lista?.FirstOrDefault(x => x.Nome =="leandro");
}

class Pessoa {
	
	public string Nome { get; set; }
}

// You can define other methods, fields, classes and namespaces here
