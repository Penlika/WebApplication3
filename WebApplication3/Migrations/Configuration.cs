namespace WebApplication3.Migrations
{
    using Microsoft.Ajax.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;
    using WebApplication3.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication3.Models.ProductDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication3.Models.ProductDB context)
        {

            IList<Category> lstCategories = new List<Category>();
            lstCategories.Add(new Category {NameCat = "Mobiles" });
            lstCategories.Add(new Category {NameCat = "Laptops" });
            lstCategories.Add(new Category {NameCat = "TVs" });
            lstCategories.Add(new Category {NameCat = "Fans" });
            lstCategories.Add(new Category {NameCat = "others" });
            lstCategories.ForEach(x=> context.Categories.AddOrUpdate(x));
            base.Seed(context);
        }
    }
}
