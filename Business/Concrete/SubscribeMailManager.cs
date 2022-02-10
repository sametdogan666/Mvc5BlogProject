using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SubscribeMailManager
    {
        Repository<SubscribeMail> repositorySubscribeMail =new Repository<SubscribeMail>();
        public void Add(SubscribeMail subscribeMail)
        {
            //if (subscribeMail.Mail.Length<=10 || subscribeMail.Mail.Length >=50)
            //{
            //    return -1;
            //}

            repositorySubscribeMail.Insert(subscribeMail);
        }
    }
}
