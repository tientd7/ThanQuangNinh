using Business.Interface;
using Unity;
using DAL;

namespace Business
{
    public class BsUnityHelper
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IAuthenBusiness, AuthenticateBusiness>();

            DlUnityConfig.RegisterTypes(container);
        }
    }
}
