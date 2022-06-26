using RbacRepository.FenYe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RbacRepository
{
    public interface IBaseDTO<T,TKey>
        where T:class
        where TKey : struct
    {
        int Add(T list);
        int Del(TKey k);
        List<T> GetAll();
        T GetEntity(Expression<Func<T, bool>> predicate);
        shuju GetFen(TiaoJian j);
        T Get(int id);
        int Upd(T t);
    }
}
