using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReferanceManager
    {
        void Add(Referance referance);
        void Delete(Referance referance);
        void Update(Referance referance);
        List<Referance> GetAll();
        Referance Get(int id);

    }
}
