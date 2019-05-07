<Query Kind="Program">
  <Connection>
    <ID>1e83cce1-1df7-4fdb-ad7f-8e914a2effce</ID>
    <Persist>true</Persist>
    <Server>(local)</Server>
    <Database>SGPF</Database>
  </Connection>
</Query>

void Main()
{
	// Ainda é um Enumerável
	var nomes = new List<Pessoa>();
	
	for(int i = 0 ; i < 100 ; i++)
	{
		nomes.Add(new Pessoa("leandro_"+i, "ekamoto.leandro@gmail.com_"+1));	
	
	}
	
	Console.WriteLine("Teste1");
	// Se colocar ToList() ele enumera o enumerável apenas uma vez, e chama a função Pessoa50 somente uma vez
	var nome50 = nomes.Where(t=>t.nome.Equals("leandro_50") && t.Pessoa50());
	
	Console.WriteLine("Teste2");
	// Enumerou o Enumerável
	Console.WriteLine("Nome50: " + nome50.First().nome); // Materializa primeira vez
	
	Console.WriteLine("Teste3");
	// Enumerou o Enumerável Duas vezes Ouuu Merda
	Console.WriteLine("Email50: " + nome50.First().email); // Materializa segunda vez
	
	Console.WriteLine("Teste4");
	if(nome50.Any()){} // Materializa terceira vez
	
	Console.WriteLine("Teste5");
	var emailBuscado = nome50.Where(t=>t.email.Equals("buscado@gmail.com")).FirstOrDefault(); // Materializa quarta vez
	
	Console.WriteLine("Teste6");
	nome50.Count();// Materializa quinta vez
	
	Console.WriteLine("Teste7");
	var primeiro = nome50.SingleOrDefault();// Materializa sexta vez
	
	Console.WriteLine("Teste8");
	// Não Materializa
	var emailBuscado2 = nome50.Where(t=>t.email.Equals("buscado@gmail.com")); // Não Materializa
	
}
	
class Pessoa {
		
	public string nome;
	public string email;
	
	public Pessoa(string nome, string email) 
	{
		this.nome = nome;
		this.email = email;
		//Console.WriteLine("Construtor: "+ nome);
		
	}
	
	public bool Pessoa50()
	{
		Console.WriteLine("Procurando pessoa 50...");
		return this.nome.Equals("leandro_50");
	}
}