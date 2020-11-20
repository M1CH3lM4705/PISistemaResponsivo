using PISistemaResponsivo.Infraestrutura.Context;

namespace PISistemaResponsivo.Infraestrutura.Dao
{
    public class DaoBase
    {
        protected readonly DataContext _contexto;

        public DaoBase()
        {
            _contexto = new DataContext();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}