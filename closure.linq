<Query Kind="Program" />

void Main()
{
	var processador = new Processador();
	
	// Por mais que a variável nome perde o escopo 
	// ela ainda é mantida na memória
	processador.Processa();
	
	// Dessa forma conseguimos acessar a variável interna de um método
	processador.funcao();
}

public class Processador{

	public Action funcao;
	
	public Processador()
	{

	}
	
	public void Processa()
	{
		var nome = "Leandro";
		funcao = () => { Console.WriteLine(nome); };
	}

}

// You can define other methods, fields, classes and namespaces here
