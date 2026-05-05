using System;

namespace MaquinaE
{
    /*
     Entrega el producto y descuenta crédito.
    */
    public class EntregaProductoState : IEstado
    {
        public void Manejar(MaquinaContexto contexto)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n▶ Estado: Entrega de producto\n");
            Console.WriteLine("------------------------------\n");

            contexto.Credito -= contexto.PrecioProducto;
            contexto.ProductoSeleccionado = false;

            contexto.CambiarEstado(new DevolverCreditoState());
        }
    }
}