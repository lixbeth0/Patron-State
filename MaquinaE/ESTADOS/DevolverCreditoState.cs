using System;

namespace MaquinaE
{
    /*
     Devuelve el dinero restante.
    */
    public class DevolverCreditoState : IEstado
    {
        public void Manejar(MaquinaContexto contexto)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n▶ Estado: Devolver crédito\n");
            Console.WriteLine("------------------------------\n");

            if (contexto.Credito > 0)
            {
                Console.WriteLine($"Cambio devuelto: {contexto.Credito}");
                contexto.Credito = 0;
            }

            contexto.ProductoSeleccionado = false;

            contexto.CambiarEstado(new EnEsperaState());
        }
    }
}