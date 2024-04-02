<Query Kind="Program" />

void Main()
{
	// Ainda é um Enumerável
	var nomes = new List<Pessoa>();
	
	for(int i = 0 ; i < 100 ; i++)
	{
		nomes.Add(new Pessoa("leandro_"+i, "ekamoto.leandro@gmail.com_"+1, i));	
	}
	nomes.Add(new Pessoa("leandro_5", "ekamoto.leandro@gmail.com_"+1, 200));	
	
	var listaPessoas5 = nomes.Where(t=>t.Pessoa5(t.id));
	// Se eu colocar tolist ele irá enumerar todos os registros, mas eu não preciso enumerar tudo
	
	var primeira = listaPessoas5.FirstOrDefault();
}

class Pessoa {
		
	public string nome;
	public string email;
	public int id;
	
	public Pessoa(string nome, string email, int id) 
	{
		this.nome = nome;
		this.email = email;
		this.id = id;
		//Console.WriteLine("Construtor: "+ nome);
	}
	
	public bool Pessoa5(int id)
	{
		Console.WriteLine("Procurando pessoa 5..."+"["+id+"]");
		return this.nome.Equals("leandro_5");
	}
}