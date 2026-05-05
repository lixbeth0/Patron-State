using System;

namespace MaquinaE
{
    /*
     Simula la entrega del producto.
    */
    public class ProcesoEntregaState : IEstado
    {
        public void Manejar(MaquinaContexto contexto)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n▶ Estado: Proceso de entrega\n");
            Console.WriteLine("------------------------------\n");

            bool fallo = false;

            if (fallo)
                contexto.CambiarEstado(new DevolverCreditoState());
            else
                contexto.CambiarEstado(new EntregaProductoState());
        }
    }
}