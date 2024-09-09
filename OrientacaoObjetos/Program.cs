namespace OrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando um objeto Carro
            Carro meuCarro = new Carro("Vermelho", "Sedan", 0);

            // Chamando os métodos do objeto
            meuCarro.Acelerar();
            meuCarro.Frear();

        }
    }
}
