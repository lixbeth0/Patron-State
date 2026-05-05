using System;

namespace MaquinaE
{
    /*
     Valida crédito y disponibilidad.
    */
    public class ValidacionCompraState : IEstado
    {
        public void Manejar(MaquinaContexto contexto)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n▶ Estado: Validación de compra\n");  
            Console.WriteLine("------------------------------\n");

            if (!contexto.ProductoDisponible)
            {
                contexto.CambiarEstado(new ProductoNoDisponibleState());
                return;
            }

            if (contexto.Credito < contexto.PrecioProducto)
            {
                Console.WriteLine("Crédito insuficiente");
                contexto.CambiarEstado(new AgregarCreditoState());
                return;
            }

            contexto.CambiarEstado(new ProcesoEntregaState());
        }
    }
}