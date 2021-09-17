using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AboutManager
    {
        Repository<About> repositoryAbout = new Repository<About>();

        public List<About> GetAll()
        {
            return repositoryAbout.List();
        }
    }
}
