using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //entityframework
using Projeto.DAL.Context; //acesso ao banco de dados
using Projeto.DAL.Contracts; //interfaces

namespace Projeto.DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        public void Insert(T obj)
        {
            using (DataContext con = new DataContext())
            {
                con.Entry(obj).State = EntityState.Added;
                con.SaveChanges();
            }
        }

        public void Update(T obj)
        {
            using (DataContext con = new DataContext())
            {
                con.Entry(obj).State = EntityState.Modified;
                con.SaveChanges();
            }
        }

        public void Delete(T obj)
        {
            using (DataContext con = new DataContext())
            {
                con.Entry(obj).State = EntityState.Deleted;
                con.SaveChanges();
            }
        }

        public List<T> FindAll()
        {
            using (DataContext con = new DataContext())
            {
                return con.Set<T>().ToList();
            }
        }

        public T FindById(int id)
        {
            using (DataContext con = new DataContext())
            {
                return con.Set<T>().Find(id);
            }
        }
    }
}
