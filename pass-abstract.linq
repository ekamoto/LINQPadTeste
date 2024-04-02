<Query Kind="Program" />

void Main()
{
	var ligacaoNovaPessoaFisica = new LigacaoNovaPessoaFisica();
	ligacaoNovaPessoaFisica.nome = "leandro";
	ligacaoNovaPessoaFisica.cpf = 123;
	
	var ligacaoNovaPessoaJuridica = new LigacaoNovaPessoaJuridica();
	ligacaoNovaPessoaJuridica.nome = "priscila";
	ligacaoNovaPessoaJuridica.cnpj = 321;
	
	var facade = new LigacaoNovaFacade();
	
	facade.Processa(ligacaoNovaPessoaFisica);
	facade.Processa(ligacaoNovaPessoaJuridica);
}

class LigacaoNova {

	public int numero { get; set; }
	public string nome { get; set; }
	
	
}

class LigacaoNovaPessoaFisica: LigacaoNova {

	public int cpf { get; set; }
}

class LigacaoNovaPessoaJuridica: LigacaoNova {

	public int cnpj { get; set; }
}

class LigacaoNovaFacade {

	public void Processa(LigacaoNova ligacaoNova)
	{
		Console.WriteLine(ligacaoNova.nome);
		
		// Isso não funciona
		// Console.WriteLine(ligacaoNova.cpf);
		// Console.WriteLine(ligacaoNova.cnpj);
	}
}
