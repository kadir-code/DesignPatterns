using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Concrete
{
    /// <summary>
    /// Concrete Class
    /// </summary>
    class DesktopScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Desktop Screen");
        }
    }
}
