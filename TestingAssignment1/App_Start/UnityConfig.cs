using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business;
using Business.Interface;
using Unity;

namespace Assignment1.App_Start
{
    public class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IPassengerManager, PassengerManager>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }       
    }
}