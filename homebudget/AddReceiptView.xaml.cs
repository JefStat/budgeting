using System;
using System.Collections.Generic;
using Autofac;
using Xamarin.Forms;

namespace homebudget
{
    public partial class AddReceiptView : ContentView
    {
        readonly IAddReceiptController controller;
        readonly ILifetimeScope lifetime;
        public AddReceiptView()
        {

            InitializeComponent();
            lifetime = ContainerInstance.Container.BeginLifetimeScope();
            this.controller = lifetime.Resolve<IAddReceiptController>();
        }
        ~AddReceiptView(){
            lifetime.Dispose();
        }
    }
}
