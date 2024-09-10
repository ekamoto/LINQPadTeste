<Query Kind="Program" />

void Main()
{
	Pessoa pessoa = new Pessoa();
	pessoa.DadosCliente = "ekamoto@gmail.com,leandro";
	
	Console.WriteLine(pessoa.DadosCliente);
	
}

public class Pessoa {

	private string Nome;
	private string Email;
	
	public Pessoa() {
	}
	
	public string DadosCliente { get { return $"Os dados do seu usuário são: {Nome} - {Email}"; } 
	set { 
	
		string[] result = value.Split(','); 
		Email = result[0];
		Nome = result[1];
	} }
}