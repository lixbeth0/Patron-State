using System;

namespace MaquinaE
{
    /*
     El usuario elige producto.
     Si no hay dinero, lo redirige a agregar crédito.
    */
    public class SeleccionProductoState : IEstado
    {
        public void Manejar(MaquinaContexto contexto)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n▶ Estado: Selección de producto\n");
            Console.WriteLine("------------------------------\n");

            contexto.ProductoSeleccionado = true;

            if (contexto.Credito <= 0)
            {
                Console.WriteLine("Debe ingresar crédito primero");
                contexto.CambiarEstado(new CreditoDisponibleState());
                return;
            }

            contexto.CambiarEstado(new EsperaCancelacionState());
        }
    }
}