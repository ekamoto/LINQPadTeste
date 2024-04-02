<Query Kind="Program" />

void Main()
{
	string nome = null;
	TesteString teste = new TesteString();
	teste.Teste(nome);
}

class TesteString {

	public void Teste(string nome)
	{
		Console.WriteLine("Nome:" + nome.Length);
		Console.WriteLine("Nome:" + nome);
	}
}

// Define other methods and classes here
