using System;

namespace Structure_types2
{
    readonly struct Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public int Height { get; }

        public Student(string firstname, string lastname, int age, int height)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Height = height;
        }
        /*public Student(string fullname, int age)
        {
            var nameArray = fullname.Split(" ");
            FirstName = nameArray[0];
            LastName = nameArray[1];
            Age = age;
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            var student = CreateStudent();

            Console.WriteLine($"Name: {student.FirstName},LastName: {student.LastName}," +
                $" Age: {student.Age}, Height: {student.Height}cm");
        }

        static Student CreateStudent()
        {
            return new Student("Bolot", "Nurman", 23, 168);
        }
    }
}

/*static (string FirstName, string LastName, int Age, int Height)CreateStudent()
{
    return new Student("Bolot", "Nurman", 23, 168);

    //System.ValueTuple
    Структура представляет кортеж, не имеющий элементов.
    Он полезен в основном для своих статических методов,
    позволяющих создавать и сравнивать экземпляры типов кортежей значений. 
    Его вспомогательные методы позволяют создавать экземпляры кортежей значений
    без необходимости явно указывать тип каждого компонента кортежа значений. 
    Путем вызова его статических Create методов можно создавать кортежи значений,
    имеющие от нуля до восьми компонентов. Для кортежей значений, 
    имеющих более восьми компонентов, 
    необходимо вызвать ValueTuple<T1,T2,T3,T4,T5,T6,T7,TRest> конструктор.
}*/


/*
            //var date1 = new DateTime(2020, 7, 9);
            //var date2 = new DateTime(2020, 7, 9, 20, 53, 40);
            var dateNow = DateTime.Now;
            var fiveminuteslater = dateNow.AddMinutes(5);

            Console.WriteLine(dateNow.ToString());
            Console.WriteLine(fiveminuteslater.ToString());*/
