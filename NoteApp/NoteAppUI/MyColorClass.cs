using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace NoteAppUI
{
    /// <summary>
    /// Класс, предоставляющий цвета радуги
    /// </summary>
    public class MyColorClass
    {
        /// <summary>
        /// Список цветов
        /// </summary>
        public enum Colors
        {
            Red,
            Orange,
            Yellow,
            Green,
            LightBlue,
            Blue,
            Violet
        }

        /// <summary>
        /// Получает текущий цвет
        /// </summary>
        public Colors CurrentColor { get; private set; } = Colors.Red;

        /// <summary>
        /// Задает следующий цвет в списке
        /// </summary>
        public void ColorNext() => CurrentColor = CurrentColor is Colors.Violet ? Colors.Red : ++CurrentColor;
        
    }
}
