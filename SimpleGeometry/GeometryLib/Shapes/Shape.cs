using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    public interface IPrintable
    {
        string Print();
    }
    /// <summary>
    /// Абстрактный класс формы
    /// </summary>
    public abstract class Shape : IPrintable
    {
        public abstract string Print();
    }
}
