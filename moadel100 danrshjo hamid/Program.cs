using System.IO;
using hamid;
string Path = "C:\\Users\\Acer\\Desktop\\c# tamrin\\gdjrfujfkmhdf\\hamid\\hamid\\Students.txt";
string[] Lines = File.ReadAllLines(Path);

//hamidrezavahedi  pishrafte1






Student[] students = new Student[9];
for (int i = 0; i < students.Length; i++)
{
    string[] line = Lines[i].Split(",");
    Student Student = new Student();
    Student.Name = line[0];
    Student.LName = line[1];
    Student.pishraftre2 = Int32.Parse(line[2]);
    Student.pishrafte1 = Int32.Parse(line[3]);
    Student.algoritm = Int32.Parse(line[4]);
    Student.sheygerayi = Int32.Parse(line[5]);
    Student.riazi = Int32.Parse(line[6]);
    Student.kargah = Int32.Parse(line[7]);
    Student.tarbiat = Int32.Parse(line[8]);
    Student.tafsir = Int32.Parse(line[9]);
    Student.system = Int32.Parse(line[9]);
    Student.zaban = Int32.Parse(line[11]);

    students[i] = Student;


}

Console.WriteLine();


bool yesorno = false;
do
{
    Console.WriteLine("1: miyangin nomarat");
    Console.WriteLine("2: moadelzarib3");
    Console.WriteLine("3: moadelzarib2");
    Console.WriteLine("4: moadelzarib1");
    Console.WriteLine("5: moadelha az 1_4");
    Console.WriteLine("6: adad aval ");
    Console.WriteLine("7: barases grade");
    Console.WriteLine("8: end");
    int adadvorodi = Convert.ToInt32(Console.ReadLine());
    switch (adadvorodi)
    {
        case 1:

            foreach (var student in students)
            {
                Console.WriteLine(student.names());
                Console.WriteLine(student.Miangin());
            }

            break;
        case 2:
            foreach (var student in students)
            {
                Console.WriteLine(student.names());
                Console.WriteLine(student.Moadelzarib3());
            }

            break;

        case 3:
            foreach (var student in students)
            {
                Console.WriteLine(student.names());
                Console.WriteLine(student.Moadelzarib2());
            }

            break;


        case 4:
            foreach (var student in students)
            {
                Console.WriteLine(student.names());
                Console.WriteLine(student.Moadelzarib1());
            }

            break;

        case 5:

            foreach (var student in students)
            {
                Console.WriteLine(student.names());
                Console.WriteLine(student.Miangin() + "  ,  ");
                Console.Write(student.Moadelzarib3() + "  ,  ");
                Console.WriteLine(student.Moadelzarib2() + "  ,  ");
                Console.Write(student.Moadelzarib1() + "  ,  ");

                switch (student.Miangin())
                {
                    case double x when x > 17:
                        Console.WriteLine("Grade: A");
                        break;
                    case double x when x > 15 && x <= 17:
                        Console.WriteLine("Grade: B");
                        break;

                    case double x when x > 13 && x <= 15:
                        Console.WriteLine("Grade: C");
                        break;
                    case double x when x > 10 && x <= 13:
                        Console.WriteLine("Grade: D");
                        break;
                    case double x when x > 7 && x <= 10:
                        Console.WriteLine("Grade: E");
                        break;
                    case double x when x > 3 && x <= 7:
                        Console.WriteLine("Grade: F");
                        break;
                    case double x when x <= 3:
                        Console.WriteLine("Grade: G");
                        break;
                }
            }
            break;
        case 6:
            {
                foreach (var student in students)
                {
                    if ((Int32)student.Miangin() < 2)
                        Console.WriteLine(student.names() + " Nomre Miangin aval nist");
                    for (int i = 2; i <= (Int32)student.Miangin(); i++)
                    {
                        if ((Int32)student.Miangin() % i == 0) ;
                        Console.WriteLine(student.names() + "Nomre Miangin aval nist ");

                    }
                    Console.WriteLine(student.names() + ":  " + (Int32)student.Miangin());
                }
            }


            break;

        case 7:
            foreach (var student in students)
            {
                switch (student.Miangin())
                {
                    case double n when n > 17:
                        Console.WriteLine(student.names() + " : A");
                        break;
                    case double n when n > 15 && n <= 17:
                        Console.WriteLine(student.names() + " : B");
                        break;

                    case double n when n > 13 && n <= 15:
                        Console.WriteLine(student.names() + " : C");
                        break;
                    case double n when n > 10 && n <= 13:
                        Console.WriteLine(student.names() + " : D");
                        break;
                    case double n when n > 7 && n <= 10:
                        Console.WriteLine(student.names() + " : E");
                        break;
                    case double n when n > 3 && n <= 7:
                        Console.WriteLine(student.names() + " :  F");
                        break;
                    case double n when n <= 3:
                        Console.WriteLine(student.names() + " :  G");
                        break;

                }
            }

            break;

        case 8:

            Console.WriteLine("============\nMOVAFAQ BASHID\n============");
            break;
    }

    Console.WriteLine("EDAME MIDI?");
    string Answer = Convert.ToString(Console.ReadLine());
    if (Answer == "y")
    { yesorno = true; }
    else { yesorno = false; }


} while (yesorno);
