namespace MaquinaE
{
    /*
     Interfaz del patrón State.
     Obliga a todos los estados a implementar el método Manejar,
     que contiene el comportamiento del estado y decide la transición.
    */
    public interface IEstado
    {
        void Manejar(MaquinaContexto contexto);
    }
}