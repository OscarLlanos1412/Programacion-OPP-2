using System;

namespace ProgramacionPOOnum2
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carrito = new Carro();
            Console.WriteLine(carrito.getInfoCarro());
            Carro carro = new Carro(300.12, 122.11);
            Console.WriteLine(carro.getInfoCarro());

            Carro carro_viejo = new Carro();
            carro_viejo.setExtras(true, "cuero");
            Console.WriteLine(carro_viejo.getExtras());
            Console.WriteLine(carro_viejo.getExtras());
        }
    }

    partial class Carro //Lo que hace el partial es para que la clase tenga trozos o se divida
        //En las partes que sea necesario, es para ver mucho mejor 
    {
        public Carro()//Constructor sin param
        {
            ruedas = 4;
            largo = 2210.21;
            ancho = 0.123;
        }
        public Carro(double largoCarro, double anchoCarro)//Constructor con param
        {
            ruedas = 4;
            largo = largoCarro;
            ancho = anchoCarro;
        }
    }
    //Segundo trozo de la clase
    partial class Carro { 
        public String getInfoCarro()
        {
            return "Las ruedas son: " + ruedas + " El largo es: " + largo + " El ancho es: " + ancho;
        }
        public void setExtras(bool aire_acondicionado, String tapiz)
        {
            this.aire_acondicionado = aire_acondicionado;//Lo que hace este this es buscar DENTRO de la clase
            //La vble que esta fuera del metodo o el setter 
            //Referencia la vble que es el campo de la clase
            this.tapiz = tapiz;
        }
        public String getExtras()
        {
            return "Extras: \n Tapiceria: " + tapiz + " Aire Acondicionado: " + aire_acondicionado;
        }
        private int ruedas;
        private double largo;
        private double ancho;
        private bool aire_acondicionado;
        private String tapiz;

        /*El constructor es el que repite la clase pero se coloca los parentesis de param
         se puede hacer una sobrecarga o repetir un constructor PERO se le debera asginar
        parametros o dejarlos vacios, todo depende lo que necesite*/

    }
}
