using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formation.Data.Infrastructures;
using Formation.Domain.Entity;
using Service.Pattern;

namespace Formation.Service
{
    public class FilmService : Service<Film>, IFilmService
    {
        public FilmService(IUnitOfWork utk) : base(utk)
        {
        }
    }
}
