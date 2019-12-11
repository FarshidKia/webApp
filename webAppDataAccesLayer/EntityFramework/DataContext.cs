using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webApp.DataEntities;


namespace webAppDataAccesLayer.EntityFramework
{
    public class DataContext : DbContext
    {
        public DbSet<webApp.DataEntities.Author> author { get; set; }
        public DbSet<Article> article { get; set; }
    }
}
