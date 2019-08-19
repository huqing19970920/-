using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMModel;
using System.Linq.Expressions;

namespace IHRMBLL
{
    public interface ICarBLL
    {
        int Add(CarModel c);
        int Update(CarModel c);
        int Delete(CarModel c);
        List<CarModel> QueryAll();
        List<CarModel> SelectByx(Expression<Func<CarModel, bool>> where);
        List<CarModel> Paging<K>(Expression<Func<CarModel, K>> order, Expression<Func<CarModel, bool>> where, ref int rows, int currentPage, int pageSize);

    }
}
