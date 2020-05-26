namespace Reflaction.ConsoleApp
{
    public class PersistenciaFactory
    {
        public Persistencia Instanciar()
        {
            return new PersistenciaFB();
        }
    }
}
