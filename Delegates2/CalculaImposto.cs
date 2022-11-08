namespace Delegates2;



public delegate double RetornaCobranca(double montante, bool isento);

public class CalculaImposto
{

    public double RetornaCobrancaICMS(double montante, bool isento)
    {
        double valorCobrado = 0;

        if (!isento)
            valorCobrado = montante * 0.20;

        return valorCobrado;
    }

    public double RetornaCobrancaIRRF(double montante, bool isento)
    {
        double valorCobrado = 0;

        if (!isento)
        {
            if (montante > 2000 && montante <= 4000)
                valorCobrado = montante * 0.15;

            if (montante > 4000)
                valorCobrado = montante * 0.35;
        }
        return valorCobrado;
    }

    public int MetodoComretorno(bool parametro)
    {
        return 0;
    }

    public void MetodoVoid(bool parametro)
    {
        
    }
}
