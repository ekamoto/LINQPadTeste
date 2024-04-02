<Query Kind="Program" />

void Main()
{
	var pessoas = new List<Pessoa> {
		new Pessoa("Leandro", false), 
		new Pessoa("Priscila", true), 
		new Pessoa("Marina", true),
		new Pessoa("João", true),
		new Pessoa("Francisco", true),
	};
	
	var novaLista = pessoas.Where(t=> t.Status).Take(3);
	
	Console.WriteLine(novaLista.Count());
	
	foreach(var pessoa in novaLista) {
		Console.WriteLine(pessoa.Nome);
	}
}

public class Pessoa {

	public Pessoa(string nome, bool status)
	{
		this.Nome = nome;
		this.Status = status;
	}

	public string Nome { get; set; }
	public bool Status { get; set; }
}

// You can define other methods, fields, classes and namespaces here