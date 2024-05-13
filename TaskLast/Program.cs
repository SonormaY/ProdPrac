//7.	Задано текстовий файл з інформацією про навчальні програми. Кожний запис містить назву курсу, прізвище викладача, кількість годин… 
//Розробити програму з графічним інтерфейсом Windows Forms, додати необхідні пункти меню та елементи керування (кнопки, перемикачі..)  Передбачити:
//-зчитування даних з текстового файлу;
//-можливість додавання нових об’єктів з клавіатури;
//-пошук елемента за заданим полем;
//-запис даних у вказаний файл;
//-сортування даних за певним критерієм;
//-перевірку даних на коректність;
//-обробку виключних ситуацій .

namespace TaskLast
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}