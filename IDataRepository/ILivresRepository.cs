using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataRepository
{
    public interface  ILivresRepository:IDisposable
    { 
        IQueryable<Livre> GetLivres();
        Livre PostLivre(Livre book);
    }
}
