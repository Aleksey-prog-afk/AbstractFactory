using AbstractFactory.Products;
using AbstractFactory.Products.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    class WinFactory : IFactory
    {
        public AButton createButton()
        {
            return new WinButton();
        }

        public ACheckBox createCheckBox()
        {
            return new WinCheckBox();
        }

        public ARadioButton createRadioButton()
        {
            return new WinRadioButton();
        }
    }
}
