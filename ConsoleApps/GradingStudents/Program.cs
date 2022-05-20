
using System.Collections.Generic;

using System;
using System.Runtime.InteropServices;
using System.Net.WebSockets;

namespace GradingStudents
{
    class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        for(int grade = 0;grade<grades.Count; grade++){
                if (grades[grade] % 5 > 0)
                {
                    var cmplt = grades[grade] % 5;
                    if (grades[grade] + 5 -cmplt >= 40)
                    {
                        grades[grade] += 5 - cmplt;
                    }
                }
        }
        return grades;
    

    }

}
    class Program
    {
        static void Main(string[] args)
        {
              // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
Console.WriteLine("Enter Number of students: ");
        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
Console.WriteLine("Number of students: "+gradesCount);
        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine(String.Join("\n", result));

      //  textWriter.Flush();
       // textWriter.Close();
        }
    }
}
