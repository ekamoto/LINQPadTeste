<Query Kind="Program" />

void Main()
{
	Dictionary<int, string> valor = new Dictionary<int, string>();
	valor.Add(1, "Leandro");
	valor.Add(2, "Shindi");
	valor.Add(3, "Ekamoto");
	
	var descricao = string.Empty;
	
	valor.TryGetValue(2, out descricao);
	
	Console.WriteLine(descricao);
}
// Define other methods and classes here