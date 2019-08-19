using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMIOC;
using IHRMDAO;
using HRMModel;
using IHRMBLL;
using System.Linq.Expressions;

namespace HRMBLL
{
    public class CarBLL : ICarBLL
    {
        ICarDAO icd = IocContanier.CreateCar_DAO();
        public int Add(CarModel c)
        {
            return icd.Add(c);
        }

        public int Delete(CarModel c)
        {
            return icd.Delete(c);
        }

        public List<CarModel> Paging<K>(Expression<Func<CarModel, K>> order, Expression<Func<CarModel, bool>> where, ref int rows, int currentPage, int pageSize)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> QueryAll()
        {
            return icd.QueryAll(); 
        }

        public List<CarModel> SelectByx(Expression<Func<CarModel, bool>> where)
        {
            throw new NotImplementedException();
        }

        public int Update(CarModel c)
        {
            return icd.Update(c);
        }
    }
}
