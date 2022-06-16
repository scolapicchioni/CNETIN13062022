
using demo02;
using demo02.Lab09;
using System.Text;

class Program {
    static void Main(string[] args) {
        Module09_Lab01();

    }

    private static void Module09_Lab01() {
        Course course = new Course(1, "C#");
        //course.Id = 1;
        //course.Name = "C#";

        Teacher simo = new Teacher("Simona", 1234,course);
        //simo.Name = "Simona";
        //simo.Salary = 1234;
        //simo.CurrentlyTeachingCourse = course;

        Student mario = new Student(12, "Mario", course);
        //mario.Name = "Mario";
        //mario.Id = 1234;
        //mario.CurrentlyFollowingCourse = course;

        //mario.CurrentlyFollowingCourse.Id
    }

    private static void Module09() {
        //StreamWriter streamWriter = new StreamWriter("c:\\temp");

        //streamWriter.WriteLine("something");

        SimoDate date = new SimoDate();

        Console.WriteLine(date.Day);

        string a = "hi";
        int b = 42;

        (string bla, int yada) = (a, b);

        (int d, int m, int y) = date;
        //date.Deconstruct(out d, out m, out y);

        //int d = date.Day;
        //int m = date.Month;
        //int y = date.Year;
        //MyFunction(d, y, m);

        
        for (int i = 0; i < 1_000_000; i++) {
            SimoDate x = new SimoDate();
        }
    }

    private static void Module08() { 
        BankAccount? GetAccountAtIndex(Bank theBank, int index) {
            return theBank.Accounts?[index];
        }


        Bank b1 = new Bank();
        b1.Accounts[0] = new BankAccount();
        b1.Accounts[1] = new BankAccount();
        b1.Accounts[2] = new BankAccount();

        BankAccount b = GetAccountAtIndex(b1, 1);
        //if(b is not null)
        b?.Deposit(100);
    }

    private static void ArraysExamples() {
        int[] numbers = new int[10];


        for (int index = 0; index < numbers.Length; index++) {
            numbers[index] = 2 * (index + 1);
        }




        for (int i = 0; i < numbers.Length; i++) {
            Console.WriteLine(numbers[i]);
        }

        string[] italianDays = new[] { "lunedi", "martedi", "mercoledi", "giovedi", "venerdi", "sabato", "domenica" };
        //string[] italianDays2 = new[] { "lunedi", "martedi", "mercoledi", "giovedi", "venerdi", "sabato", "domenica" };

        //if (italianDays == italianDays2) { 

        //}

        string[] copy = new string[italianDays.Length];

        for (int i = 0; i < italianDays.Length; i++) {
            copy[i] = italianDays[i];
        }
        Array.Copy(italianDays, copy, italianDays.Length);

        ChangeArray(italianDays);


        int[,] matrix = new int[5, 3];


        for (int row = 0; row < matrix.GetLength(0); row++) {
            for (int column = 0; column < matrix.GetLength(1); column++) {
                matrix[row, column] = (row + 1) * (column + 1);
            }
        }
    }

    //Write a program that reads ten integer numbers from the console,
    // then calculates the sum of these numbers. 
    // Store the numbers in an array. 

    static int[] Module06_Excercise01() {
        int[] numbers = new int[10];
        int sum = 0;
        string message = "The sum of";
        for (int i = 0; i < numbers.Length; i++) {
            Console.Write($"Please insert number {i+1}: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            numbers[i] = number;
            sum = sum + numbers[i];
            message += $" {numbers[i]} +";  
        }
        message = $"{message.Remove(message.Length - 1)} is {sum}";

        Console.WriteLine(message);
        return numbers;
        //The sum of 3  + 5  + 7  + 9  + 1  + 2  + 4  + 6  + 8  + 0  is 45
        //Console.WriteLine("The sum of ");
    }

    static void Module06_Excercise02() {
        //Write a program that fills a 3 by 3 array
        //with random numbers between 1 and 9.
        //Each random number may only occur once in the array.

        int[,] matrix = new int[3, 3];

        int height = matrix.GetLength(0);
        int width = matrix.GetLength(1);

        Random randomGenerator = new Random();

        bool[] alreadyExtracted = new bool[matrix.Length];

        for (int r = 0; r < height; r++) {
            for (int c = 0; c < width; c++) {
                int number;
                do {
                    number = randomGenerator.Next(1, matrix.Length + 1);
                } while (alreadyExtracted[number - 1] == true);

                alreadyExtracted[number - 1] = true;
                matrix[r, c] = number;
            }
        }

        for (int r = 0; r < height; r++) {
            for (int c = 0; c < width; c++) {
                Console.Write($"{matrix[r,c]}\t");
            }
            Console.WriteLine();
        }

    }

    private static void ChangeArray(string[] parameter) {
        parameter[3] = "fgsjgfsj";
    }

    private static void Yesterday() {
        int argument = 5;
        Console.WriteLine(argument);
        Increment(ref argument);
        Console.WriteLine(argument);

        int result;
        if (int.TryParse("42", out result)) {
            Console.WriteLine(result);
        }

        //result = Sum(new[] { 1, 2, 3, 4 });
        result = Sum(1, 2, 3, 4);

        MethodWithLotsOfParameters(0, 0, false, "hi", false);
        MethodWithLotsOfParameters();
        MethodWithLotsOfParameters(1, 2);

        //MethodWithLotsOfParameters("hi");
        MethodWithLotsOfParameters(d: "hi");

        MethodWithThreeParameters(1, 2, 3);
        MethodWithThreeParameters(b: 1, a: 2, c: 3);

        (int A, int B, string C) myTuple = (4, 5, "hi");

        (int first, int second, string third) = MethodThatReturnsATuple();
        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);
        SayHi(4);
        SayHi("Simona");
    }

    static void SayHi() {
        int someLocalMethod() {
            return 42;
        }

        someLocalMethod();
        Console.WriteLine("oh, HI!");
    }
    static void SayHi(string name) => Console.WriteLine($"oh, HI {name}!");

    static int SomeMethodReturningAnInt(string x) {
        return x.Length;
    }

    //static int SomeMethodReturningAnInt(string x) => x.Length;

    //static void SayHi(string whereDoYouComeFrom) {
    //    Console.WriteLine($"oh, HI {whereDoYouComeFrom}!");
    //}
    static void SayHi(int times) {
        for (int i = 0; i < times; i++) {
            Console.WriteLine($"oh, HI!");
        }
    }
    static void SayHi(string name, int times) {
        for (int i = 0; i < times; i++) {
            Console.WriteLine($"oh, HI {name}!");
        }
    }

    static int MethodThatReturnsAnInt() {
        return 42;
    }
    static (int A, int B, string C) MethodThatReturnsATuple() {
        return (4, 5, "hi");
    }

    static void MethodWithThreeParameters(int a, int b, int c) { 
    
    }

    static void MethodWithLotsOfParameters(int a=0, int b=10, bool c=false, string d="", bool f = false) { 
        
    }

    static int Sum(params int[] list) {
        return 42;
    }

    static void Increment(ref int parameter) {
        Console.WriteLine(parameter);
        parameter++;
        Console.WriteLine(parameter);
    }

    static void Write(out int parameter) {
        //Console.WriteLine(parameter);
        parameter = 42;
        Console.WriteLine(parameter);
    }
}