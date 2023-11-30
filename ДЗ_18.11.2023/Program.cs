using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ДЗ_18._11._2023.BankAccountFactory;
using static ДЗ_18._11._2023.Buildings;
using static ДЗ_18._11._2023.Books;


namespace ДЗ_18._11._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 1 Создать новый класс, который будет являться фабрикой объектов класса банковский счет. ");
            BankAccount bankAccount = new BankAccount();
            int accountNumber = bankAccount.CreateAccount(383298,2000000);
            Console.WriteLine("Создан счёт с номером:" + accountNumber);
            bankAccount.DeleteAccount(accountNumber);
            Console.WriteLine("Закрыт счёт с номером:" + accountNumber);
            Console.WriteLine("Упражнение 2. Для реализованного класса из домашнего задания 7.1 создать новый класс Creator, который будет являться фабрикой объектов класса здания.");
            BuildingFactory buildings = new BuildingFactory();
            Buildings buildingNumber = BuildingFactory.CreateBuild(27, 20,5,20,6);
            Console.WriteLine("Создано здание с номером:"+buildingNumber);
            buildings.RemoveBuildings(buildingNumber);
            Console.WriteLine("Удалён объект здания с номером:"+buildingNumber);
            Console.WriteLine("Упражнение 3.  Создать класс рациональных чисел. В классе два поля – числитель и знаменатель.");
            RationalNumbers left = new RationalNumbers(1,8);
            RationalNumbers right = new RationalNumbers(2, 9);
            Console.WriteLine(right.ToString());
            Console.WriteLine(left.ToString());
            Console.WriteLine(left==right);
            Console.WriteLine(left!=right);
            Console.WriteLine("Упражнение 4. Описать класс комплексных чисел.Реализовать операцию сложения, умножения, вычитания, проверку на равенство двух комплексных чисел.");
            ComplexNumbers a = new ComplexNumbers(1, 1);
            ComplexNumbers b = new ComplexNumbers(2, 3);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine("Упражнение 5. Создать класс, являющийся контейнером для множества книг (массив книг).");
            Books[] book = new Books[]
            {
                new Books("Мастер и Маргарита", "Булгаков","Материк"),
                new Books("ЕГЭ2024","Цыбулько","Просвещение")
            };
            BookContain bookContain = new Books.BookContain(book);
            Comparison<Books> sortByTitle = (book1, book2) => book1.Title.CompareTo(book2.Title);
            bookContain.SortBooks(sortByTitle);
            foreach (var book in Books)
            {
                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Издательство: {book.Publisher}");
            }
            Console.WriteLine("У каждого есть хобби. Написать программу для слежения за интересующим вас событием (выход сериала, концерт и т.д.)");
            List<Person> person = new List<Person>
            {
                new Person("Екатерина","сериалы"),
                new Person("Иван","концерты"),
                new Person("Алексей","футбол")
            };
            Console.WriteLine("Введите интересующее вас событие(сериалы, концерты, футбол)");
            string event1 = Console.ReadLine();
            foreach(var person in people)
            {
                person.Event(person.Hobby, event1);
            }
        }
    }
}
