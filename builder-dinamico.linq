<Query Kind="Program" />

void Main()
{

	List<Amigo> lista = new List<Amigo>();
	lista.Add(new Amigo(){
		NomeAmigo = "Amigo teste"
	});
	
	var pessoa2 = new Builder<Pessoa>()
						.Adiciona(x => x.Nome = "Leandro")
						.Adiciona(x => x.Telefone = 67985251112)
						.Adiciona(x => x.Endereco = new Builder<Endereco>()
							.Adiciona(x => x.Rua = "MajorVieira")
							.Constroi())
						.Adiciona(x => x.ListaAmigo = lista)
						.Constroi();
	
	Console.WriteLine("Nome: " + pessoa2.Nome);
	Console.WriteLine("Telefone: " + pessoa2.Telefone);
	Console.WriteLine("Rua" + pessoa2.Endereco?.Rua);
	Console.WriteLine("Nome:" + pessoa2.ListaAmigo[0].NomeAmigo);
}

public class Endereco {
	public string Rua { get; set; }
}

public class Amigo {
	public string NomeAmigo { get; set; }
}

public class Pessoa {
	public string Nome { get; set; }
	public long Telefone { get; set; }
	public Endereco Endereco { get; set; }
	public List<Amigo> ListaAmigo { get; set; }
	public Pessoa() {
	
		ListaAmigo = new List<Amigo>();
	}
}

public interface IBuilder<T> where T: class, new() {
    Builder<T> Adiciona(Func<T, object> func);
    T Constroi();
}

public class Builder<T>: IBuilder<T> where T : class, new()
{
    public T obj;
    private List<Func<T, object>> _itens;

    public Builder()
    {
        obj = new T();
        _itens = new List<Func<T, object>>();
    }

    public Builder<T> Adiciona(Func<T, object> func)
    {
        _itens.Add(func);
        return this;
    }

    public T Constroi()
    {
        foreach (var func in _itens)
            func.Invoke(obj);
        return obj;
    }
}
