using AbstractFactory.Products;
using AbstractFactory.Products.Mac;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    class MacFactory : IFactory
    {
        public AButton createButton()
        {
           return new MacButton();
        }

        public ACheckBox createCheckBox()
        {
            return new MacCheckBox();
        }

        public ARadioButton createRadioButton()
        {
            return new MacRadioButton();
        }
    }
}
