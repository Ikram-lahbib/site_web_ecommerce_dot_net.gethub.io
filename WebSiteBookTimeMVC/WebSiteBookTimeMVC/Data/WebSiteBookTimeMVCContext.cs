using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSiteBookTimeMVC.Models;

namespace WebSiteBookTimeMVC.Data
{
    public class WebSiteBookTimeMVCContext : DbContext
    {
        public WebSiteBookTimeMVCContext (DbContextOptions<WebSiteBookTimeMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebSiteBookTimeMVC.Models.Book> Book { get; set; }

        public DbSet<WebSiteBookTimeMVC.Models.User> User { get; set; }
    }
}
