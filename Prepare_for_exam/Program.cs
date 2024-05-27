using System.Runtime.Intrinsics.X86;

namespace Prepare_for_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------- Задача 1 - Список студентов -----------
            // У нас есть список студентов, каждый из которых имеет св-ва: имя, возраст, средний балл
            // С помощью LINQ: 
            // 1. Вывести список студентов старше 20 лет, отсортированных по среднему баллу по убыванию
            // 2. Найти студента с самым высоким средним баллом
            // 3. Рассчитать средний возраст студентов
            // 4. Посчитать общее кол-во стедунтов
            /*List<Student> students = new List<Student>() 
            { 
                new Student{Name = "Вася", Age = 22, AverageGrade = 8.5},
                new Student{Name = "Маша", Age = 32, AverageGrade = 9.15},
                new Student{Name = "Петя", Age = 25, AverageGrade = 7.35},
                new Student{Name = "Надя", Age = 19, AverageGrade = 8.85},
            };
            var studentsOver20 = students.Where(s => s.Age > 20).OrderByDescending(s => s.AverageGrade);
            foreach (var el in  studentsOver20)
            {
                Console.WriteLine($"{el.Name}, age: {el.Age}, Общий балл: {el.AverageGrade}");
            }
            var hight = students.OrderByDescending(s => s.AverageGrade).First();
            Console.WriteLine($"Студент с самым высоким средним баллом: {hight.Name}, age: {hight.Age}, Общий балл: {hight.AverageGrade}");
            var average = students.Average(s => s.Age);
            Console.WriteLine("Средний возраст студентов: " + average);            
            Console.WriteLine("Кол-во студентов = " + students.Count);
            
            // Самый старший студент
            var older = students.OrderByDescending(s => s.Age).First();
            Console.WriteLine($"Самый страший студент: {older.Name}, age: {older.Age}, Общий балл: {older.AverageGrade}");

            // Список студентов старше 20 с оценкой больше 4,5
            var studentsOver20Over45 = students.Where(s => s.Age > 20 && s.AverageGrade > 4.5);
            Console.WriteLine("\nСписок студентов страше 20 с оценкой больше 4,5:");
            foreach (var el in studentsOver20Over45)
            {
                Console.WriteLine($"{el.Name}, age: {el.Age}, Общий балл: {el.AverageGrade}");
            }

            // Сортировка студентов по убыванию среднего балла
            Console.WriteLine("\nСписок студетов по убыванию среднего балла:");
            var res = students.OrderByDescending(s => s.AverageGrade);
            foreach (var el in res)
            {
                Console.WriteLine($"{el.Name}, age: {el.Age}, Общий балл: {el.AverageGrade}");
            }
            Console.WriteLine();

            // ---------------- Задача 2 - Система управленния книжным магазином -----------------
            BookStore<IBook> bookStore = new BookStore<IBook>();
            var book1 = new Book1
            {
                Title = "Book1",
                Author = "Author1",
                Genre = "Fiction",
                Price = 19.99,
                PublicationYear = 2020
            };
            var book2 = new Book2
            {
                Title = "Book2",
                Author = "Author2",
                Genre = "Fiction",
                Price = 29.99,
                PublicationYear = 2018
            };
            bookStore.AddBook(book1);
            bookStore.AddBook(book2);
            // Поиск книг определённог автора
            var booksByAuthor = bookStore.FindBooksByAutor("Author1");
            var booksByName = bookStore.FindBooksByName("Book1");
            Console.WriteLine("Книги по авторам:");
            foreach(var book in booksByAuthor)
            {
                Console.WriteLine($"{book.Title} by {book.Author}\n");
            }
            Console.WriteLine("Книги по названиям:");
            foreach (var book in booksByName)
            {
                Console.WriteLine($"{book.Title} by {book.Title}");
            }
            var sortedBooks = bookStore.GetBooksSortedBy(b => b.Price);
            Console.WriteLine("\nКниги, отсортированные по цене:");
            foreach (var book in sortedBooks)
            {
                Console.WriteLine($"{book.Title} - {book.Price}");
            }
            Console.WriteLine($"\nОбщая стоимость всех книг в магазине = {bookStore.CalculateTotalPriece()}");            
            var mostExpensiveBook = bookStore.GetMostExpensiveBook();
            Console.WriteLine($"\nСамая дорогая книга в магазине = {mostExpensiveBook.Price}");*/

            // ------------ Задача 3 - Хранение данных о студентах -------------------
            StudentCollection<IStudent> studentCollection = new StudentCollection<IStudent>();
            var s1 = new Student1()
            {
                Name = "Вася",
                Age = 37,
                Major = "Водитель"
            };
            var s2 = new Student1()
            {
                Name = "Маша",
                Age = 17,
                Major = "Дизайнер"
            };
            var s3 = new Student1()
            {
                Name = "Петя",
                Age = 25,
                Major = "Программист"
            };
            studentCollection.AddStudent(s1);
            studentCollection.AddStudent(s2);
            studentCollection.AddStudent(s3);
            Console.WriteLine("\nСтуденты:");
            studentCollection.PrintAllStudent();
            Console.WriteLine($"\nСамый молодой студент: {studentCollection.Yanger().Name}, {studentCollection.Yanger().Age} лет");
            Console.WriteLine($"\nСамый старший студент: {studentCollection.Older().Name}, {studentCollection.Older().Age} лет");
            Console.WriteLine("Ищем водителя:");
            // Первый способ без IEnumerable
            /*if (studentCollection.Special("Водитель") == 0)
                Console.WriteLine("Специальность не найдена!");
            else
                foreach (var s in studentCollection.Special("Водитель"))
                    Console.WriteLine($"Имя: {s.Name}, возраст {s.Age}, специальность {s.Major}");*/
            // Второй способ с IEnumerable
            var special = studentCollection.Special("Дизайнер");
            if (special.Count() == 0)
                Console.WriteLine("Специальность не найдена!");
            else
                foreach (var s in special)
                    Console.WriteLine($"Имя: {s.Name}, возраст {s.Age}, специальность {s.Major}");
        }
    }
}
