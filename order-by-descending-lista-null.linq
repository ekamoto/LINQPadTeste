<Query Kind="Program" />

void Main()
{
	
	List<Pessoa> lista = null;
	
	lista.OrderByDescending(x => x.nome)
    .ThenByDescending(y => y.nome)
    .FirstOrDefault();
	
}

public class Pessoa {

	public string nome { get; set; }
}

// You can define other methods, fields, classes and namespaces here
