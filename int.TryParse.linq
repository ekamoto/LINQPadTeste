<Query Kind="Program" />

void Main()
{
	string contaContabilCodigo = string.Empty;
	var classificacaoSemMascara = Regex.Replace(contaContabilCodigo, "[?\\)?\\(_./-]", "");
	
    int classificacao;

	if (!int.TryParse(classificacaoSemMascara, out classificacao))
	{
		Console.WriteLine("Não deu erro, mas tenho que ver como tratar esse cara");
	}
}

// Define other methods and classes here
