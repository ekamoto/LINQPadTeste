<Query Kind="Program" />

void Main()
{
	
	// Protected é o mesmo que private só que estende seu encapsulamento para as 
	// classes derivadas
	Funcionario funcionario = new Funcionario("Leandro");
	funcionario.setNome("Priscila");
	
	Console.WriteLine(funcionario.getNome());
	
}

class Pessoa {

	protected string Nome;
	
	public Pessoa(string nome)
	{
		this.Nome = nome;
	}
}

// Classe herdada tem a permissão para manipular um campo protected
class Funcionario: Pessoa {
	
	public Funcionario(string nome): base(nome) {
		
	}
	
	public void setNome(string nome)
	{
		this.Nome = nome;
	}
	
	public string getNome()
	{
		return this.Nome;
	}
}


// Define other methods, classes and namespaces here
