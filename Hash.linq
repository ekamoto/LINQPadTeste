<Query Kind="Program" />

void Main()
{

	DateTime thisDate1 = DateTime.Now;
	var chave = thisDate1.ToString();
	Console.WriteLine(chave);

	string nome = "leandrokjljkjlkjlkjlkjçkj"+chave;
	string hashCode = String.Format("{0:X}", nome.GetHashCode());
	Console.WriteLine(hashCode);
}

// Define other methods and classes here
