using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examoop.Model
{
    internal class practical :Exam
    {
        public practical(TimeSpan time, int num) : base(time, num)
        {
        }



        public override void ShowExam()
        {
            Console.WriteLine($" the number of question is :{Numberofquestion}");
            Console.WriteLine("======================================================================");
            int i = 1;
            double grade = 0;
            foreach (var qs in q)
            {
               
                Console.WriteLine($" the question {i}  is  :{qs.Body}");
                Console.WriteLine($" the mark of question is {qs.Mark}");
                Console.WriteLine($"the right answer is  {qs.Rightanswer}");
                i++;
            }
        }
    }
}
