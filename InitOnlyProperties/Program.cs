




//Declarações permitidas
var pessoa = new Pessoa()
{
    Nome = "Douglas"
};

var pessoa2 = new Pessoa("Bufão");

Console.WriteLine("Init-Only");
Console.WriteLine("---------------------------------");
Console.WriteLine($"Nome da pessoa: {pessoa.Nome}");
Console.WriteLine($"Nome da pessoa: {pessoa2.Nome}");
Console.WriteLine();

//Operação não permitida
//pessoa.Nome = "André";



#region Classes
public class Pessoa
{
    public string Nome { get; init; }

    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
    }
}

public class Carro
{
    private readonly string _modelo;

    public string Modelo
    {
        get => _modelo;
        init => _modelo = value;
    }

    // Atribuição não permitida (erro de compilação),
    // public string Modelo2
    //{
    //    get => _modelo;
    //    set => _modelo = value;
    //}
}
#endregion