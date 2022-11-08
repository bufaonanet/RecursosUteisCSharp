

using Delegates2;

CalculaImposto imposto = new();
RetornaCobranca aplica_icms = imposto.RetornaCobrancaICMS;
RetornaCobranca aplica_irrf = imposto.RetornaCobrancaIRRF;

var metodoSemRetorno = imposto.MetodoComretorno;
var metodovoid = imposto.MetodoVoid;


double icms = aplica_icms(300,false);

double irrf = aplica_irrf(300,false);

Console.WriteLine($"icms = {icms}");
Console.WriteLine($"irrf = {irrf}");