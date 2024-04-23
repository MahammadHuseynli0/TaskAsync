using Core.Models;
using Core.Models.Service;

namespace TapsiriqThreadTaskAsyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            string name;
            string surname;
            double grade;
            string gradestr,studentpointstr;
            int studentPoint,Id;
            int minPoint, maxPoint; 
          
            byte Choose = 0;
            
            AsyncMethods AsyncMethods = new AsyncMethods();


            do
            {
                Console.WriteLine("1.Telebe elave et");
                Console.WriteLine("2.Butun telebelere bax");
                Console.WriteLine("3.Bal araligina gore telebeleri axtaris et");
                Console.WriteLine("4. Idye gore telebeeri axtaris et");
                Console.WriteLine("0.Proqrami bitir");


                Choose = Convert.ToByte(Console.ReadLine());

                if (Choose == 0)
                {
                    break;

                }

                if (Choose == 1)
                {  

                    Console.WriteLine("Telebe adini daxil edin");
                    name = Console.ReadLine();
                    Console.WriteLine("Soyadini daxil edin");
                    surname = Console.ReadLine();
                   
                    do
                    {
                        Console.WriteLine("Sinifini daxil edin");
                        gradestr = Console.ReadLine();

                    } while (!double.TryParse(gradestr, out grade));

                    do
                    {
                        Console.WriteLine("Telebenin balini daxil edin ");
                        studentpointstr = Console.ReadLine();

                    } while (!int.TryParse(gradestr, out studentPoint));


                  
                    Student student = new Student(name, surname,grade, studentPoint );

                  await AsyncMethods.AddStudentAsync(student);
                }
                if (Choose == 2)
                {
                   await AsyncMethods.AsyncShowStudentInfo();
                }
                if (Choose == 3)
                {
                    Console.WriteLine("minPoint daxil edin");
                    minPoint = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("maxPoint daxil edin");
                    maxPoint = Convert.ToInt32(Console.ReadLine());
                   await AsyncMethods.AsyncGetAllStudentsByPoint(maxPoint, minPoint );
                }
                if (Choose == 4)
                {
                    Console.WriteLine("Id daxil edin");
                    Id = Convert.ToInt32(Console.ReadLine());
                   await AsyncMethods.AsyncFindStudentById(Id); 
                }

            } while (true);


        }
    }
}








