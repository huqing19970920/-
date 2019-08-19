using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using IHRMDAO;
using HRMDAO;
using IHRMBLL;
namespace HRMIOC
{
    public class IocContanier
    {
        private static UnityContainer CreatIoc(string XmlName)
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ecfm = new ExeConfigurationFileMap();
            ecfm.ExeConfigFilename = @"E:\HR项目\HRMSys\HRMUI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecfm, ConfigurationUserLevel.None);
            UnityConfigurationSection ucs = (UnityConfigurationSection)cf.GetSection("unity");
            ioc.LoadConfiguration(ucs, XmlName);
            return ioc;
        }

        /*****/
        public static ICarDAO CreateCar_DAO()
        {
            UnityContainer ioc = CreatIoc("confDAL");
            return ioc.Resolve<CarDAO>("CarDAL");
        }
        public static ICarBLL CreateCar_BLL()
        {
            UnityContainer ioc = CreatIoc("confBLL");
            return ioc.Resolve<ICarBLL>("CarBLL");
        }

    }
}
