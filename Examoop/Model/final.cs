using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examoop.Model
{
    internal class final:Exam
    {
		private int type;

		public int MyProperty
		{
			get { return type; }
			set { type = value; }
		
		}
		 public final( TimeSpan t,int n) : base(t,n)
		{

		}
		 
		 

        public override void ShowExam()
        {
            Console.WriteLine($" the number of question is :{Numberofquestion}");
            Console.WriteLine("======================================================================");
			int i=1;
			double grade = 0,count=0;
			foreach (var qs in q)
			{
				
                Console.WriteLine( $" the question {i}  :{qs.Body}");
                Console.WriteLine($" the mark of question is {qs.Mark}");
                Console.WriteLine($"your answer is {qs.answers[0].Answertext}");
				if (qs.answers[0].Answerid == qs.Rightanswer)
				{
					grade += qs.Mark;
					count++;
				}
				else
				{
					grade += 0;
				}

					i++;
			}
            Console.WriteLine($"Your grade of all question is {grade}");
            Console.WriteLine($"you get {count} of {Numberofquestion}");
        }
    }
}
