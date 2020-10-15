using AbstractFactory.Products;
using AbstractFactory.Products.Linux;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    class LinuxFactory : IFactory
    {
        public AButton createButton()
        {
            return new LinuxButton();
        }

        public ACheckBox createCheckBox()
        {
            return new LinuxCheckBox();
        }

        public ARadioButton createRadioButton()
        {
            return new LinuxRadioButton();
        }
    }
}
