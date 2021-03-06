﻿using Autofac;
using Autofac.Integration.Mvc;
using BusinessLogic;
using Domain;
using EjemploTestIntegration.Controllers;
using EjemploTestIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace EjemploTestIntegration.App_Start
{
    public class AutoFacConfig
    {
        public static void Register(Action<IDependencyResolver> resolver)
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            builder.RegisterType<UserContext>().As<IContextBase>().As<IUnitOfWork>().InstancePerHttpRequest();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            
        }
    }
}