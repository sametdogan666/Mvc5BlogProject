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
        Repository<About> aboutRepository = new Repository<About>();

        public List<About> GetAll()
        {
            return aboutRepository.List();
        }

        public void UpdateAbout(About about)
        {
            About _about = aboutRepository.Find(x => x.AboutId == about.AboutId);
            _about.AboutContent1 = about.AboutContent1;
            _about.AboutContent2 = about.AboutContent2;
            _about.AboutImage1 = about.AboutImage1;
            _about.AboutImage2 = about.AboutImage2;
            _about.AboutId = about.AboutId;

            aboutRepository.Update(_about);
        }
    }
}
