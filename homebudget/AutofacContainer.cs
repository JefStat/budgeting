using System;
using Autofac;

namespace homebudget
{
    public static class ContainerInstance
    {
        static IContainer _container;
        public static IContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = new AutofacContainer().builder.Build();
                }
                return _container;
            }
        }
    }

    public class AutofacContainer
    {
        public readonly ContainerBuilder builder;
        public AutofacContainer()
        {
            builder = new ContainerBuilder();
            Register();
        }

        void Register(){
            builder.RegisterType<ReceiptStorage>().As<IReceiptStorage>();
            builder.RegisterType<AddReceiptController>().As<IAddReceiptController>();
        }
    }
}
