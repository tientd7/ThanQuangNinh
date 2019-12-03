﻿using DAL.Interface;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DAL
{
    public static class DlUnityConfig
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IDbContext, AuthenticationDB>();
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
