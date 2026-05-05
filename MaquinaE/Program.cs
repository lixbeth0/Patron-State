using System;

namespace MaquinaE
{
    /*
     Punto de entrada del programa.
     Inicializa el contexto y ejecuta el ciclo continuo.
    */
    class Program
    {
        static void Main()
        {
            MaquinaContexto maquina = new MaquinaContexto(new EnEsperaState());

            while (true)
            {
                maquina.Ejecutar();
            }
        }
    }
}