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
            Screen screen = null;//Get the screen reference
            switch (screenModel)
            {
                case ScreenModel.Desktop:
                    break;
                case ScreenModel.web:
                    break;
                case ScreenModel.Mobile:
                    break;
                default:
                    break;
            }
            return screen;
        }
        #endregion

    }
}
