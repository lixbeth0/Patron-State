using System;

namespace MaquinaE
{
    /*
     Verifica si la máquina está disponible y permite iniciar interacción.
    */
    public class ValidaFuncionState : IEstado
    {
        public void Manejar(MaquinaContexto contexto)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("\n▶ Estado: Validación de máquina\n");
            Console.WriteLine("------------------------------\n");

            if (!contexto.MaquinaHabilitada)
            {
                Console.WriteLine("Máquina inhabilitada");
                contexto.CambiarEstado(new EnEsperaState());
                return;
            }

            Console.WriteLine("Máquina lista");

            Console.WriteLine("1. Insertar dinero");
            Console.WriteLine("2. Seleccionar producto");

            if (!int.TryParse(Console.ReadLine(), out int op))
            {
                Console.WriteLine("Entrada inválida");
                return;
            }

            if (op == 1)
                contexto.CambiarEstado(new AgregarCreditoState());
            else if (op == 2)
                contexto.CambiarEstado(new SeleccionProductoState());
        }
    }
}