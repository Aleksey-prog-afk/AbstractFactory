using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Products.Linux
{
    class LinuxButton : AButton
    {
        public LinuxButton()
        {
            style = "linux";
        }
    }
}
