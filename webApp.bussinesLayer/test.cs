using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webAppDataAccesLayer.EntityFramework;

namespace webApp.bussinesLayer
{
    public class test
    {
        public test()
        {
            DataContext db = new DataContext();
            db.Database.CreateIfNotExists();
        }
    }
}
