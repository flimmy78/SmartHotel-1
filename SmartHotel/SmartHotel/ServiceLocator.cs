using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using SmartHotel.Services.Navigation;
using SmartHotel.ViewModels;

namespace SmartHotel
{
    public class ServiceLocator
    {
        private IContainer _container;
        private readonly ContainerBuilder _containerBuilder;

        public static ServiceLocator Instance { get; }

        static ServiceLocator()
        {
            Instance = new ServiceLocator();
        }

        public ServiceLocator()
        {
            _containerBuilder = new ContainerBuilder();

            RegisterInstance<INavigationService, NavigationService>();

            _containerBuilder.RegisterType<ConciergeViewModel>();
            _containerBuilder.RegisterType<SuggesstionsViewModel>();
            _containerBuilder.RegisterType<MyRoomViewModel>();
            _containerBuilder.RegisterType<BookingViewModel>();
            _containerBuilder.RegisterType<HomeViewModel>();
            _containerBuilder.RegisterType<MainViewModel>();
            _containerBuilder.RegisterType<LoginViewModel>();
        }

        public void Register<T, U>() where U : T
        {
            _containerBuilder.RegisterType<U>().As<T>();
        }

        public void RegisterInstance<T, U>() where U : T
        {
            _containerBuilder.RegisterType<U>().As<T>().SingleInstance();
        }



        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        public void Build()
        {
            _container = _containerBuilder.Build();
        }
    }
}
