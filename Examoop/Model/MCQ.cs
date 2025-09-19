using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Examoop.Model
{
    internal class MCQ : Question
    {



        public List<string> choice { get; set; }
        public MCQ(string body, string header, double mark, List<string> choos,int rightanswer ): base(header,body,mark)
        {
           
            choice = choos;
            Rightanswer = rightanswer;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Choices:");
            for (int i = 0; i < choice.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {choice[i]}");
            }
            sb.AppendLine($"The correct answer is: {choice[Rightanswer]}");
            return sb.ToString();
        }

        public override void showquestion()
        {
            Console.WriteLine($"the body of question is {Body}");
            Console.WriteLine($"the mark of question is {Mark}");
            Console.WriteLine("===========================================");
            Console.WriteLine("the choices is ");
            int i = 1;
            foreach(var ch in choice)
            {
                Console.WriteLine($"{i}: {ch}");
                i++;
            
            }
            bool fl;
            int answer;
            do
            {
            Console.WriteLine("please enter the right answer");
               fl= int.TryParse(Console.ReadLine(), out answer);
            }
            while (!fl);


            answers.Add(new(answer, choice[answer - 1]));
        }
    }
}
