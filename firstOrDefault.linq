<Query Kind="Program" />

void Main()
{
	//List<Pessoa> lista = new List<Pessoa>();
	List<Pessoa> lista = null;
	
	var ret = lista?.FirstOrDefault();
	Console.WriteLine(ret);
	
	
}

class Pessoa {

	public string Nome { get; set; }
}
// You can define other methods, fields, classes and namespaces here
