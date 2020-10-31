using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependancyResolver.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MahalleManager>().As<IMahalleService>();
            builder.RegisterType<EfMahalleDal>().As<IMahalleDal>();

            builder.RegisterType<KapiManager>().As<IKapiService>();
            builder.RegisterType<EfKapiDal>().As<IKapiDal>();
        }
    }
}
