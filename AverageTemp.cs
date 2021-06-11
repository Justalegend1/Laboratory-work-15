using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_15
{
    [Serializable]//даем право сериализации объекта, без него нелзя представить объект в виде байтов и потом восстановить
    public class AverageTemp
    {
        public AverageTemp(int numDay, double temp)
        {
            NumDay = numDay;
            Temperature = temp;
        }

        public int NumDay { get; set; }//автосвойство с номером дня
        public double Temperature { get; set; }//автосвойство с температурой

        public bool Deleted { get; set; }//проверка на то, удален ли элемент

        public override string ToString()
        {
            return string.Format("День: {0}, Температура: {1}", NumDay, Temperature);
        }

    }
}
