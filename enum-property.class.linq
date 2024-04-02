<Query Kind="Program" />

void Main()
{
	
	var pessoa = new Pessoa();
	
	pessoa.TipoDocumento = TIPO_DOCUMENTO.CPF;
	
	Console.WriteLine((int)pessoa.TipoDocumento);
	Console.WriteLine(pessoa.TipoDocumento);
}

public class Pessoa
{

	public TIPO_DOCUMENTO TipoDocumento{ get; set; }
}

public enum TIPO_DOCUMENTO
{
	RG,
	CPF
}
// Define other methods, classes and namespaces here
