using System;

namespace MaquinaE
{
    /*
     Permite cancelar antes de validar la compra.
    */
    public class EsperaCancelacionState : IEstado
    {
        public void Manejar(MaquinaContexto contexto)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n▶ Estado: Espera de cancelación\n");
            Console.WriteLine("------------------------------\n");

            Console.WriteLine("1. Continuar");
            Console.WriteLine("2. Cancelar");

            if (!int.TryParse(Console.ReadLine(), out int op))
            {
                Console.WriteLine("Entrada inválida");
                return;
            }

            if (op == 2)
                contexto.CambiarEstado(new DevolverCreditoState());
            else
                contexto.CambiarEstado(new ValidacionCompraState());
        }
    }
}