<Query Kind="Program" />

void Main()
{
	var pessoa = new Pessoa();
	var processador = new ProcessadorComida();
	processador.Processa(pessoa.Comer);
	
	string fruta = "banana";
	if(processador.ProcessaBanana(fruta, pessoa.ComerSomenteBanana))
	{
		Console.WriteLine("Comeu uma banana");
	} 
	else
	{
		Console.WriteLine("Fruta não é banana");
	}
}

interface IPessoa 
{
	void Comer(int quantidade, string nomeAlimento);
	bool ComerSomenteBanana(string nomeFruta);
}

class Pessoa: IPessoa
{
	public void Comer(int quantidade, string nomeAlimento)
	{
		Console.WriteLine($"Comendo: { nomeAlimento }");		
	}
	
	public bool ComerSomenteBanana(string nomeFruta)
	{
		if(nomeFruta.Equals("banana"))
			return true;
			
		return false;
	}
}

class ProcessadorComida
{
	public void Processa(Action<int, string> pessoa)
	{
		pessoa(1, "Maçã");
	}
	
	public bool ProcessaBanana(string fruta, Func<string, bool> processaFruta)
	{
		return processaFruta(fruta);
	}
}