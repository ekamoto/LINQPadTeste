<Query Kind="Program" />

void Main()
{
	
	var core = new Core(new EntradaAdapter()); 
	
	core.ProcessData();
}

public interface IInput
{
    void ReceiveData(string data);
}

public class Entrada: IInput {
	
	public void ReceiveData(string data)
	{
		Console.WriteLine("Entrada");
	}
}

public class EntradaCustomizada {
	
	public string Entrada { get; set; }
	
	public EntradaCustomizada(string inicioString) {
		this.Entrada = inicioString;
	}
	
	public void ReceiveDataAntes(string data)
	{
		this.Entrada += data;
	}
}

public class EntradaAdapter : IInput {

	public EntradaCustomizada newInput { get; set; }
	
	public EntradaAdapter() {
		this.newInput = new EntradaCustomizada("entrada customizada");
	}
	
	public void ReceiveData(string data)
	{
		newInput.ReceiveDataAntes(" adicionando mais informação");
		Console.WriteLine(newInput.Entrada);
	}
}


public class Core
{
    private IInput _input;

    public Core(IInput input)
    {
        _input = input;
    }

    public void ProcessData()
    {
        // Lógica de processamento usando a interface IInput
        _input.ReceiveData("Dados de entrada para o núcleo");
    }
}
// You can define other methods, fields, classes and namespaces here