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
            container.RegisterType<ICourseBusiness, CourseBusiness>();
            container.RegisterType<ILessonBusiness, LessonBusiness>();
            container.RegisterType<ITopicBusiness, TopicBusiness>();

            DlUnityConfig.RegisterTypes(container);
        }
    }
}
