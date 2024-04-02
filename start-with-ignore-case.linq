<Query Kind="Program" />

void Main()
{
	string nome = "Leandro";
	Console.WriteLine(nome.StartsWith("LE", StringComparison.CurrentCultureIgnoreCase));
	
	Console.WriteLine(nome.Contains("Leandro"));
}