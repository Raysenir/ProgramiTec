using Lab_1_2kurs.Validators;
using System;
namespace Lab_1_2kurs
{
    class Person
    {
        /// <summary>
        /// Констуктор, 4 параметра
        /// </summary>
        /// <param name="height">Рост</param>
        /// <param name="weight">Вес</param>
        /// <param name="BirthDay">Дата Рождения</param>
        /// <param name="FullName">Полное имя</param>
        public Person(int height, int weight, DateTime BirthDay, string FullName)
        {
            try
            {

                if (ChangeHeight(height) == false)
                    throw new Exception("Неправильно указано значение");
                if (ChangeWeight(weight) == false)
                    throw new Exception("Неправильно указано значение");
                this.Birthday = BirthDay;
                string fullName = FullName; // копия строки FullName
                if (!fullName.Contains(' ') || fullName[0] == ' ' || fullName[fullName.Length - 1] == ' ')
                    throw new Exception("Указано только одно значение - имя или фамилия ");

                string firstNam = fullName.Substring(0, fullName.IndexOf(' ', 0)); // имя - подстрока (с - 0-го символа до индекса, где пробел)
                if (ChangeFirstName(firstNam) == false)
                    throw new Exception("Неправильно указано значение");

                string lastNam = fullName.Substring(fullName.IndexOf(' ', 0) + 1, fullName.Length - fullName.IndexOf(' ', 0) - 1); // фамилия - подстрока с индекса, где пробел + 1 до длины строки полного имени минус индекс позиции пробела - 1
                if (ChangeLastName(lastNam) == false)
                    throw new Exception("Неправильно указано значение");



                // this.FullName = FullName;
                Console.WriteLine("Рост " + this.Height);
                Console.WriteLine("Вес " + this.Weight);
                Console.WriteLine("Дата рождения " + this.Birthday);
                Console.WriteLine("Полное имя " + this.FullName);
                Console.WriteLine("Имя " + this.FirstName);
                Console.WriteLine("Фамилия " + this.LastName);

            }
            catch (IOException e)
            {
                Console.WriteLine($"Ошибка.{e.Message}");
            }

        }
        // Рост
        public int Height { get; private set; /* автоматическое свойство*/ }
        // Вес
        public double Weight { get; private set; }
        // Дата рождения
        public DateTime Birthday { get; }
        // Имя
        public string FirstName { get; private set; }
        // Фамилия
        public string LastName { get; private set; }
        // Полное имя - Имя и фамилия
        public string FullName
        {
            get // Не автоматическое свойство
            {
                return FirstName + " " + LastName;
            }
        }
        /// <summary>
        /// Изменение роста
        /// </summary>
        /// <param name="Height">Рост</param>
        /// <returns>true или false</returns>
        public bool ChangeHeight(int Height)
        {
            bool flag = IntValidator.Validate(Height);
            if (flag)
                this.Height = Height;
            return flag;
        }
        /// <summary>
        /// Изменение веса
        /// </summary>
        /// <param name="weight">Вес</param>
        /// <returns>true или false</returns>
        public bool ChangeWeight(int weight)
        {
            bool flag = IntValidator.Validate(weight);
            if (flag)
                Weight = weight;
            return flag;
        }
        /// <summary>
        /// Изменение имени
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <returns>true или false</returns>
        public bool ChangeFirstName(string firstName)
        {
            bool flag = StringValidators.Validate(firstName);
            if (flag)
                FirstName = firstName;
            return flag;
        }
        /// <summary>
        /// Изменение фамилии
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns>true или false</returns>
        public bool ChangeLastName(string lastName)
        {
            bool flag = StringValidators.Validate(lastName);
            if (flag)
                this.LastName = lastName;
            return flag;
        }



    }
}
