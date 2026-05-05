using System;

namespace MaquinaE
{
    /*
     Estado donde el usuario tiene crédito disponible
     y puede decidir qué hacer.
    */
    public class CreditoDisponibleState : IEstado
    {
        public void Manejar(MaquinaContexto contexto)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n▶ Estado: Crédito disponible\n");
            Console.WriteLine("------------------------------\n");
            Console.WriteLine($"Crédito actual: {contexto.Credito}");

            Console.WriteLine("1. Insertar crédito");
            Console.WriteLine("2. Seleccionar producto");

            if (contexto.Credito > 0)
                Console.WriteLine("3. Cancelar");

            if (!int.TryParse(Console.ReadLine(), out int op))
            {
                Console.WriteLine("Entrada inválida");
                return;
            }

            if (op == 1)
                contexto.CambiarEstado(new AgregarCreditoState());
            else if (op == 2)
                contexto.CambiarEstado(new SeleccionProductoState());
            else if (op == 3 && contexto.Credito > 0)
                contexto.CambiarEstado(new DevolverCreditoState());
            else
                Console.WriteLine("Opción no válida");
        }
    }
}