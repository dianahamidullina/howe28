using hwon28;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwon28
{
    abstract public class Entertainment
    {
        protected int colvogorok;
        protected int srlength;
        protected int tempwater;

        public int Colvogorok
        { get { return colvogorok; } set { colvogorok = value; } }
        public int Srlength
        { get { return srlength; } set { srlength = value; } }
        public int TempWater
        { get { return tempwater; } set { tempwater = value; } }

        public Entertainment(int Colvogorok, int Srlength)
        {
            this.Colvogorok = Colvogorok;
            this.Srlength = Srlength;
        }
        public Entertainment(int TempWater, int Colvogorok, int Srlength) : this(Colvogorok, Srlength)
        {
            this.TempWater = TempWater;
        }
        public virtual void nachphrase()
        {

        }
    }
    public class Watermiuntine : Entertainment
    {
        public override void nachphrase()
        {
            Console.WriteLine("Немного иофнрмации о водных горках нашего аквапарка");
        }
        protected int timeofwork;
        protected int sryears;
        protected int tempwater;
        public int Timeofwork
        { get { return timeofwork; } set { timeofwork = value; } }
        public int Sryears
        { get { return sryears; } set { sryears = value; } }
        public int TempWater
        { get { return tempwater; } set { tempwater = value; } }

        public Watermiuntine(int Timeofwork, int Colvogorok, int Srlength) : base(Colvogorok, Srlength)
        {
            this.Timeofwork = Timeofwork;
        }
        public Watermiuntine(int Sryears, int Timeofwork, int Colvogorok, int Srlength, int TempWater) : this(Timeofwork, Colvogorok, Srlength)
        {
            this.Sryears = Sryears;
            this.TempWater = Timeofwork;
        }
        public int countofgorki()
        {
            int count = Colvogorok * 1;
            Console.WriteLine($"Наш аквапарк представляет {count}" + " " + "горок");
            return count;
        }
        public int srdlina()
        {
            int length = Srlength * 2;
            Console.WriteLine($"Средняя длина всех горок:{length}" + " " + "метров");
            return length;
        }
        public int graduswater()
        {
            int temperatura = TempWater * Colvogorok;
            Console.WriteLine($"Температура воды в горках:{temperatura}");
            return temperatura;
        }
        public int timeofworking()
        {
            int timee = Timeofwork - 4;
            Console.WriteLine($"Время работы каждый день взависимости от потока людей:{timee}");
            return timee;
        }
        public int srvozrast()
        {
            int vozrast = Sryears;
            Console.WriteLine($"Средний возраст посетителей данного аквапарка:{vozrast}");
            return vozrast;
        }
    }
    public class Bar : Entertainment
    {
        private string drink;
        protected int purchaseexpenses;
        private int incomes;

        public string Drink { get { return drink; } set { drink = value; } }
        public int Purchaseexpenses { get { return purchaseexpenses; } set { purchaseexpenses = value; } }
        public int Incomes { get { return incomes; } set { incomes = value; } }

        public Bar(string Drink, int Colvogorok, int Srlength) : base(Colvogorok, Srlength)
        {
            this.Drink = Drink;

        }
        public Bar(int Purchaseexpenses, int Incomes, string Drink, int Colvogorok, int Srlength) : this(Drink, Colvogorok, Srlength)
        {
            this.Purchaseexpenses = Purchaseexpenses;
            this.Incomes = Incomes;
        }
        public void napitok()
        {
            string themost = Drink;
            Console.WriteLine($"Самый популярный напиток в баре:{themost}");
        }
        public int trats()
        {
            int tratonzakyp = Incomes - Purchaseexpenses;
            Console.WriteLine($"Траты на закупку товара:{tratonzakyp}");
            return tratonzakyp;
        }
        public int pribl()
        {
            int pr = Incomes * 10;
            Console.WriteLine($"Ежемесячная прибль от бара: {pr}");
            return pr;
        }
        public int coasts()
        {
            int coast = Incomes + Purchaseexpenses;
            Console.WriteLine($"Издержки аквапарка:{coast}");
            return coast;
        }
        public int arenda()
        {
            int arend = 200000;
            Console.WriteLine($"Аренда здания аквапарка в месяц стоит:{arend}");
            return arend;
        }

    }








    public class Employers
    {
        protected int people = 1000;
        public int temp;
        protected int time = 6;
        protected int salarry = 20000;



        public Employers()
        {

        }

        public Employers(int temp) : this()
        {
            this.temp = temp;
        }
    }
    public class Instructors : Employers
    {
        public int colvodays;
        public int lanchtime;
        public string duties;

        public Instructors(int colvodays) : base()
        {
            this.colvodays = colvodays;

        }
        public Instructors(int colvodays, int lanchtime) : this(colvodays)
        {
            this.lanchtime = lanchtime;

        }



        public int salarymethod()
        {
            int payment = people * salarry;
            Console.WriteLine($"Зарплата всех сотрудников суммарно:{payment}");
            return payment;
        }
        public int timemethod()
        {
            int worktime = people * time - 5991;
            Console.WriteLine($"Общие часы работы в день :{worktime}" + " " + "часовой рабочий день ");
            return worktime;
        }

        public void chargemethod()
        {
            string path = @"C:\Users\Diana\source\repos\howe28\howe28\duties.txt";

            string text = File.ReadAllText(path);
            Console.WriteLine($"Обязанности работников:{text}");
        }


        public int incomemethod()
        {
            int income = salarry * 100;
            Console.WriteLine($"Ежегодный доход от содержания аквапарка :{income}");
            return income;
        }
        public int colvopeoplemethod()
        {
            int colvopeople = people * time;
            Console.WriteLine($"Ежедневное колличество посетителей:{colvopeople}");
            return colvopeople;
        }

    }
    public class Cliningtime : Employers
    {
        protected int count;
        public int freetime;
        public string cliningproducts;//через файл
        public int cliningper;


        public Cliningtime(int count) : base()
        {
            this.count = count;
        }
        public Cliningtime(int count, int freetime, int cliningper) : this(count)
        {
            this.freetime = freetime;
            this.cliningper = cliningper;
        }
        public int avercliningtimemethod()
        {
            int timeforperroom = cliningper * 10;
            Console.WriteLine($"Время выделенное на уборку каждой комнаты(в минутах):{timeforperroom}");
            return timeforperroom;
        }
        public int avarcliningtimeall()
        {
            int timeforcleaningall = cliningper * 10;
            Console.WriteLine($"Cреднее время на уборку всего аквапарка(в минутах):{timeforcleaningall}");
            return timeforcleaningall;
        }
        public void needcountmethod()//через  файл 
        {
            string path1 = @"C:\Users\Diana\source\repos\howe28\howe28\TextFile1.txt";

            string text1 = File.ReadAllText(path1);
            Console.WriteLine($"Продукты с помощью которых проводится очистка бассейна:{text1}");
        }
        public int colvoemployersmethd()
        {
            int colvopeople = count * 1;
            Console.WriteLine($"Общее кол-во персонала(человек) :{colvopeople}");
            return colvopeople;
        }
        public int timesmokingmethod()
        {
            int timesm = count - freetime;
            Console.WriteLine($"Время допустимое на перерыв:{timesm}" + " " + "минут");
            return timesm;
        }




    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте.Изучите внутренюю структуру аквапарка");
            Instructors instructors = new Instructors(10, 15);
            instructors.chargemethod();
            instructors.timemethod();
            instructors.incomemethod();
            instructors.colvopeoplemethod();
            instructors.salarymethod();
            Console.WriteLine("В нашем аквапарке уборка прогоходит по ГОСТу");
            Console.WriteLine("Ознакомьтесь с методами уборки");
            Cliningtime cliningtime = new Cliningtime(50, 20, 30);
            cliningtime.avercliningtimemethod();
            cliningtime.timesmokingmethod();
            cliningtime.needcountmethod();
            cliningtime.avarcliningtimeall();
            cliningtime.colvoemployersmethd();
            Console.WriteLine("Наполнение акварака");
            Watermiuntine watermiuntine = new Watermiuntine(20, 12, 15, 25, 2);
            watermiuntine.nachphrase();
            watermiuntine.countofgorki();
            watermiuntine.timeofworking();
            watermiuntine.countofgorki();
            watermiuntine.graduswater();
            watermiuntine.srdlina();
            Bar bar = new Bar(1000000, 30000000, "Махито", 15, 30);
            bar.arenda();
            bar.pribl();
            bar.coasts();
            bar.napitok();
            bar.trats();
            Console.ReadKey();




        }


    }
}
