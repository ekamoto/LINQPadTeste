<Query Kind="Program" />

// Padrão para criar objetos: named constructor

void Main()
{
	var aluno = Aluno.ComNomeEmail("Leandro Shindi Ekamoto","ekamoto.leandro@gmail.com");
	Console.WriteLine(aluno.nome +"-"+ aluno.email);
}

public class Aluno {

	public string nome { get; set; }
	public string email { get; set; }
	
	public static Aluno ComNomeEmail(string nome, string email)
	{
		var aluno = new Aluno();
		aluno.nome = nome;
		aluno.email = email;
		
		return aluno;
	}
}