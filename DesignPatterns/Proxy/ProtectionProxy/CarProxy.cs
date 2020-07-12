using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy.ProtectionProxy
{
    public class CarProxy : ICar
    {
        private readonly Driver _driver;
        private readonly Car _car = new Car();

        public CarProxy(Driver driver)
        {
            _driver = driver;
        }

        public string Drive()
        {
            if (_driver.Age > 18)
            {
                return _car.Drive();
            } else
            {
                return "too young";
            }
        }
    }
}
