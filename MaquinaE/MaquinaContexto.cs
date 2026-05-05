using System;

namespace MaquinaE
{
    /*
     Contexto del patrón State.

     Contiene:
     - El estado actual
     - Los datos compartidos entre estados
     - La lógica para cambiar de estado

     Además guarda información clave como:
     - Crédito
     - Si el usuario ya seleccionó un producto
    */
    public class MaquinaContexto
    {
        public IEstado EstadoActual { get; set; }

        public int Credito { get; set; } = 0;
        public int PrecioProducto { get; set; } = 20;

        public bool MaquinaHabilitada { get; set; } = true;
        public bool ProductoDisponible { get; set; } = true;

        // Variable clave para mantener el flujo de compra
        public bool ProductoSeleccionado { get; set; } = false;

        public MaquinaContexto(IEstado estadoInicial)
        {
            EstadoActual = estadoInicial;
        }

        public void Ejecutar()
        {
            EstadoActual.Manejar(this);
        }

        public void CambiarEstado(IEstado nuevoEstado)
        {
            EstadoActual = nuevoEstado;
        }
    }
}