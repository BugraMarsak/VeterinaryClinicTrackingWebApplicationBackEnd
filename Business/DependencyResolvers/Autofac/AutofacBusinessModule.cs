using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module //using Autofac
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<SurgeriesManager>().As<ISurgeriesService>();
            builder.RegisterType<EfSurgeriesDal>().As<ISurgeriesDal>();

            builder.RegisterType<VaccinationCardManager>().As<IVaccinationCardService>();
            builder.RegisterType<EfVaccinationCardDal>().As<IVaccinationCardDal>();

            builder.RegisterType<AnimalsManager>().As<IAnimalsService>();
            builder.RegisterType<EfAnimalsDal>().As<IAnimalsDal>();
            
            builder.RegisterType<AnimalInformationManager>().As<IAnimalInformationService>();
            builder.RegisterType<EfAnimalInformationDal>().As<IAnimalInformationDal>();

            builder.RegisterType<PersonnelManager>().As<IPersonnelService>();
            builder.RegisterType<EfPersonnelDal>().As<IPersonnelDal>();

            builder.RegisterType<SupplyManager>().As<ISupplyService>();
            builder.RegisterType<EfSupplyDal>().As<ISupplyDal>();


            //builder.RegisterType<AuthManager>().As<IAuthService>();
            //builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
