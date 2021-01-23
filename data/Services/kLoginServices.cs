using data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data.Services
{
    public class kLoginServices
    {
        public List<KLogin> GetAllList()
        {
            using (var liste=new usersContext())
            {
                return liste.KLogins.ToList();

            }
        }
        public int Login(string kullaniciadi,string sifre)
        {
            int result = 0;
            using (var baglanti=new usersContext())
            {
                //linq kosulu 
                var userLogin = baglanti.KLogins.FirstOrDefault(i => i.KullaniciAdi == kullaniciadi && i.Sifre == sifre);
                result = userLogin != null && userLogin.Id > 0 ? userLogin.Id : 0;
                
            }
            
            return result;

        }
        public KLogin GetById(int Id)
        {
            KLogin result = new KLogin();
            using (var srv=new usersContext())
            {
                result = srv.KLogins.FirstOrDefault(x => x.Id == Id);
            }
            return result;
        }

        public int Save(KLogin dt)
        {
            int result = 0;
            using (var srv=new usersContext())
            {
                if(dt.Id>0)
                {
                    var currentModel = srv.KLogins.FirstOrDefault(x => x.Id == dt.Id);
                    currentModel.KullaniciAdi = dt.KullaniciAdi;
                    currentModel.Sifre = dt.Sifre;
                }
                else
                {
                    srv.KLogins.Add(dt);
                }
                srv.SaveChanges();
            }
            return result;
        }
        public void Delete(int Id)
        {
            using (var services=new usersContext())
            {
                var _user = services.KLogins.Find(Id);
                services.KLogins.Remove(_user);
                services.SaveChanges();


            }
        }
    }
}
