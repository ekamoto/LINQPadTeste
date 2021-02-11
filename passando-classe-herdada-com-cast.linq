<Query Kind="Program" />

void Main()
{
	var pessoa = new Pessoa();
	pessoa.Nome = "Leandro";
	
	var processador = new Processador();
	processador.Processa1(pessoa);
	
	var funcionario = new Funcionario();
	funcionario.Cargo = "Analista de Sistemas";
	processador.Processa2<Funcionario>(funcionario);
	
	var cliente = new Cliente();
	cliente.CodigoCadastro = 123;
	cliente.Nome = "Cliente Leandro";
	processador.Processa2<Cliente>(cliente);
}

class Pessoa {

	public string Nome { get; set; }
}

class Funcionario: Pessoa
{
	public string Cargo { get; set; }
}

class Cliente: Pessoa
{
	public int CodigoCadastro { get; set; }
}

class Processador
{
	public void Processa1 (object objeto)
	{
		Console.WriteLine(((Pessoa)objeto).Nome);
	}
	
	public void Processa2<T> (Pessoa pessoa)
	{
		dynamic novaVariavel = (T)(object)pessoa;
         
        Console.WriteLine(novaVariavel.GetType().GetProperty("Cargo")!=null?novaVariavel.Cargo:novaVariavel.Nome);
	}
}
