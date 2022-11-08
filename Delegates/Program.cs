namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            Mensagem1();
            Mensagem2();
        }

        public static void Mensagem1()
        {          

            var mensagemCompleta = ObterMensagem(minhaMensage);
            Console.WriteLine(mensagemCompleta);
        }

        public static void Mensagem2()
        {

            var mensagemCompleta = ObterMensagem(outraMensage);
            Console.WriteLine(mensagemCompleta);
        }

        public static string minhaMensage()
        {
            return "minhaMensage";
        }

        public static string outraMensage()
        {
            return "outraMensage";
        }

        public delegate string ObterMensagemEspecifica();

        static string ObterMensagem(ObterMensagemEspecifica mensagemEspecifica)
        {
            string mensagem = string.Empty;
            mensagem += "Início da mensagem\r\n\r\n";
            mensagem += mensagemEspecifica();
            mensagem += "\r\n\r\n";
            mensagem += "Final da mensagem\r\n";
            mensagem += "-----------------------------------------\r\n";

            return mensagem;
        }
    }
}