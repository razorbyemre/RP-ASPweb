using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using BLL.Interfaces;
using BLL;

namespace RP_ASPweb.Ninject
{
    public class NinjectRegister:NinjectModule
    {
        public override void Load()
        {
            Bind<IDbCrud>().To<DbOperations>();
        }
    }
}