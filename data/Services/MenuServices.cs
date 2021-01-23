using data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace data.Services
{
  public class MenuServices
    {
        public ICollection<Menu> GetAllMenu()
        {
            using (var context = new usersContext())
            {

             var data = context.Menus.Include(p => p.Parent).ToList().Where(p => p.ParentId == null).ToList();
                return data;
                
            }

           

        }
    }
}
