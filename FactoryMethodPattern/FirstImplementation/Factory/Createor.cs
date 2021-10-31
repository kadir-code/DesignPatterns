using FactoryMethodPattern.Concrete;
using FactoryMethodPattern.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factory
{
    /// <summary>
    /// Creator Class
    /// </summary>
    class Createor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="screenModel"></param>
        /// <returns>reference of product</returns>
        #region First implementation return Screen
        public Screen ScreenFactory(ScreenModel screenModel)
        {
            if (screenModel==ScreenModel.Desktop)
            {
                return new DesktopScreen();
            }
            else if (screenModel==ScreenModel.Mobile)
            {
                return new MobileScreen();
            }
            else
            {
                return new WebScreen();
            }
           
        }
        #endregion

    }
}
