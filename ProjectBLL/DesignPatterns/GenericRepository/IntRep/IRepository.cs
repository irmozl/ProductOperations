using ProjectENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
         //List commands

        List<T> GetAll();
        List<T> GetModifieds();
        List<T> GetDeleteds();
        List<T> GetActives();
        
        //Modify Commands
        void Add(T item);
        void AddRange(List<T> list);
        void Delete(T item);
        void DeleteRange(List<T> list);
        void Update(T item);
        void UpdateRange(List<T> list);
        void Destroy(T item);
        void DestroyRange(List<T> list);

        //Lİnq Commands

        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, object>> exp);

        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);

        //Find Command
        T Find(int id);
    }
}
