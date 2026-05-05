using System;

namespace MaquinaE
{
    /*
     Estado inicial del sistema.
     Representa la máquina sin interacción activa.
    */
    public class EnEsperaState : IEstado
    {
        public void Manejar(MaquinaContexto contexto)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n▶ Estado: En espera\n");
            Console.WriteLine("------------------------------\n");

            contexto.CambiarEstado(new ValidaFuncionState());
        }
    }
}