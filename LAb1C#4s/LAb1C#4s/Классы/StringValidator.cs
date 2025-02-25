using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2kurs.Validators
{
    /// <summary>
    /// Класс проверки строковых значений
    /// </summary>
    class StringValidators
    {
        /// <summary>
        /// Проверка, есть ли в строке цифры, пустые строки
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns>Возвращает true, в случае, если нет ошибок</returns>
        static public bool Validate(string value)
        {
            bool flag1 = true;

            if (String.IsNullOrWhiteSpace(value))
            {
                return true/*String.IsNullOrWhiteSpace(value)*/;
            }

            else
            {
                foreach (char cch in value)
                {
                    if (!char.IsLetter(cch))
                    {
                        flag1 = false;

                    }

                }
                return flag1;
            }

        }
    }
}
