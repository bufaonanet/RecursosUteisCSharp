
// Comparação de records
// Comparando dois registros criados com dados iguais
var documento1 = new Documento
{
    Numero = 123456
};

var documento2 = new Documento
{
    Numero = 123456
};

var igual = documento1.Equals(documento2);
Console.WriteLine("******* Value-based equality - Igualdade baseada em valor *******");
Console.WriteLine();
Console.WriteLine($"Comparação de objetos diferentes (do mesmo registro) com dados iguais: {igual}");
igual = documento1.GetHashCode().Equals(documento2.GetHashCode());
Console.WriteLine($"Comparação de Hash Codes de objetos diferentes (do mesmo registro) com dados iguais: {igual}");

// Comparando um registro criado pela registro base e outro criado pelo registro derivado
var rg1 = new Documento
{
    Numero = 123456
};

var rg2 = new RG
{
    Numero = 123456    
};

igual = rg1.Equals(rg2);
Console.WriteLine($"Comparação de objetos diferentes (registro base X registro derivado) com dados iguais: {igual}");






#region Records
public record Documento
{
    public long Numero { get; init; }
}

public record RG : Documento
{    
}

#endregion
