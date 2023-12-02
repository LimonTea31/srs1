using ConsoleAddUser.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAddUser
{
    class Helper
    {
    //    private static Models.Model_RE s_firstDBEntities;

        
    //    public static Models.ModelRE GetContext()
    //    {
    //        if (s_firstDBEntities == null)
    //        {
    //            s_firstDBEntities = new Models.ModelRE();
    //        }
    //        return s_firstDBEntities;
    //    }

    //    public void CreateUser(Models.Users users)
    //    {
    //        GetContext().Users.Add(users);
    //        GetContext().SaveChanges();
    //    }

    //    public void EditUser(Models.Users users)
    //    {
    //        s_firstDBEntities.Entry(users).State = EntityState.Modified;
    //        s_firstDBEntities.SaveChanges();
    //    }

    //    public void DeleteUder(int idUser)
    //    {
    //        var users = s_firstDBEntities.Users.Find(idUser);
    //        s_firstDBEntities.Users.Remove(users);
    //        s_firstDBEntities.SaveChanges();
    //    }
    //    public void FiltrUser()
    //    {
    //        var Users = s_firstDBEntities.Employee.Where(x => x.FirstName.StartsWith("М") || x.SecondName.StartsWith("А"));
    //    }
    //    public void SortUser()
    //    {
    //        var users = s_firstDBEntities.Employee.OrderBy(x => x.FirstName);
    //    }

    }
}
