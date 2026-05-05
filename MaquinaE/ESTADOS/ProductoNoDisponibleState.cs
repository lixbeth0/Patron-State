using System;

namespace MaquinaE
{
    /*
     Maneja el caso donde no hay producto disponible.
    */
    public class ProductoNoDisponibleState : IEstado
    {
        public void Manejar(MaquinaContexto contexto)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n▶ Estado: Producto no disponible\n");
            Console.WriteLine("------------------------------\n");

            Console.WriteLine("1. Elegir otro");
            Console.WriteLine("2. Cancelar");

            if (!int.TryParse(Console.ReadLine(), out int op))
            {
                Console.WriteLine("Entrada inválida");
                return;
            }

            if (op == 1)
                contexto.CambiarEstado(new SeleccionProductoState());
            else
                contexto.CambiarEstado(new DevolverCreditoState());
        }
    }
}