using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    // Definindo a classe Carro
    public class Carro
    {
        // Atributos (propriedades) do carro
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        // Construtor para inicializar o carro
        public Carro(string cor, string modelo, int velocidade)
        {
            Cor = cor;
            Modelo = modelo;
            Velocidade = velocidade;
        }

        // Método para acelerar
        public void Acelerar()
        {
            Velocidade += 10;
            Console.WriteLine("O carro está acelerando. Velocidade atual: " + Velocidade + " km/h");
        }

        // Método para frear
        public void Frear()
        {
            Velocidade -= 10;
            Console.WriteLine("O carro está freando. Velocidade atual: " + Velocidade + " km/h");
        }
    }

}
