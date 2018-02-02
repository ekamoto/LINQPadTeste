<Query Kind="Program" />

void Main()
{
	Dictionary<int, Pessoa> origemDestinoContas = new Dictionary<int, Pessoa>();
	
	origemDestinoContas.Add(1, new Pessoa("leandro","ekamoto.leandro@gmail.com"));
	
	var teste = origemDestinoContas.Values.Select(e => e.Nome);
	
	Console.WriteLine(teste);
}

class Pessoa {
	
	public Pessoa(string Nome, string Email) {
		this.Nome = Nome;
		this.Email = Email;
	}
	
	public string Nome{get;set;}
	public string Email{get;set;}
	
}

// Define other methods and classes here
