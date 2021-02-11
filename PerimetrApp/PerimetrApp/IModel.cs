using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetrApp
{
    /// <summary>
    /// Протокол для разработки подсчета периметра прямоугольника
    /// </summary>
    /// <param name="a"> Одна сторона прямоугольника </param>
    /// <param name="b"> Одна сторона прямоугольника </param>
    /// <returns> </returns>

    interface IModel
    {
        int GetP(int a, int b);
    }
}
