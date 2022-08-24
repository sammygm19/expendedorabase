using System;
using System.Threading;

namespace expendedorabase
{
    class expendedora
    {
        string marca;
        byte temperatura;
        string codigo;
        float precio;
        public expendedora()
        {
            saludo();
            marca = "AMS";
            Console.WriteLine("marca : " + marca);
            controlartiempodisplay();
            temperatura = 14;
            Console.WriteLine("la temperatura es de :" + temperatura+ "°C");
            controlartiempodisplay();
            codigo = mostrarcodigodeproductos();
            controlartiempodisplay();
            mostrarprecio(codigo);
            
        }
        void controlartiempodisplay()
        {
            Thread.Sleep(3000);
            Console.Clear();
        }
        void saludo()
        {
            Console.WriteLine("bienvenido a esta maquina");
        }

        string mostrarcodigodeproductos()
        {
            Console.WriteLine("A1 : kinder delice \t B2 : takis\t C3 : Panditas");
            Console.WriteLine("ingresa el codigo deseado ");
            string codigodo = Console.ReadLine(); // codigo es variable local
            return codigo;
        }
        void mostrarprecio(string codigo)
        {
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("el precio es de : {0}", precio);
                    break;
                case "B2":
                    Console.WriteLine("el precio es de : {0}", precio);
                    break;
                case "C3":
                    Console.WriteLine("el precio es de : {0}", precio);
                
                    break;
                



            }
        }
    }
}
