using MovieStoreApplication.Models.Domain;
using MovieStoreApplication.Models.DTO;

namespace MovieStoreApplication.Repositories.Abstract
{
    public interface IGenreService
    {
        bool Add(Genre model);
        bool Update(Genre model);
        Genre GetById(int id);
        bool Delete(int id);
        IQueryable<Genre> List();

    }
}
