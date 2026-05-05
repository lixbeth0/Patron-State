using System;

namespace MaquinaE
{
    /*
     Permite ingresar dinero a la máquina.
     Mantiene la intención del usuario.
    */
    public class AgregarCreditoState : IEstado
    {
        public void Manejar(MaquinaContexto contexto)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n▶ Estado: Agregar crédito\n");
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("\nIngrese la cantidad a agregar:");

            if (!int.TryParse(Console.ReadLine(), out int dinero))
            {
                Console.WriteLine("Entrada inválida");
                return;
            }

            contexto.Credito += dinero;

            // Si ya había intención de compra, continúa el flujo
            if (contexto.ProductoSeleccionado)
                contexto.CambiarEstado(new EsperaCancelacionState());
            else
                contexto.CambiarEstado(new CreditoDisponibleState());
        }
    }
}