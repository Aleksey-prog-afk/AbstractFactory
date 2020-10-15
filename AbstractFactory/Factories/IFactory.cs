using AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    interface IFactory
    {
        AButton createButton();
        ARadioButton createRadioButton();
        ACheckBox createCheckBox();
    }
}
