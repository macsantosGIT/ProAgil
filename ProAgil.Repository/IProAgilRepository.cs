using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface IProAgilRepository
    {
        //GERAL
         void Add<T>(T entity) where T: class;
         void Update<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveChangesAsync();

         //EVENTOS
         Task<Evento[]> GetAllEventoAsyncByTema(string tema, bool incluirPalestrantes);
         Task<Evento[]> GetAllEventoAsync(bool incluirPalestrantes);
         Task<Evento> GetEventoAsyncById(int EventoId, bool incluirPalestrantes);
        
        //PALESTRANTES
         Task<Palestrante> GetPalestranteAsync(int PalestranteId, bool incluirEventos);
         Task<Palestrante[]> GetAllPalestranteAsyncByName(string nome, bool incluirEventos);
    }
}