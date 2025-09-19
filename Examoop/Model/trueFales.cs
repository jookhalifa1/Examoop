using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examoop.Model
{
    internal class trueFales :Question
    {
        public trueFales(string h, string body,double mark,int flag):base(h,body,mark)
        {
            Rightanswer = flag;
        }

        public override void showquestion()
        {
            Console.WriteLine($"the body  {Body}");
            Console.WriteLine($"the mark {Mark}");
            Console.WriteLine("===========================================");
            int answer;
            bool f;
            do
            {
            Console.WriteLine("enter 1 to true or 2 to flase");
                f=int.TryParse( Console.ReadLine(), out answer);
            }
            while (!f);
            if (answer == 1)
                answers.Add(new Answers(answer, "True"));
            else
                answers.Add(new Answers(answer, "false"));


        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            if (Rightanswer == 1)
                sb.AppendLine($" the correct answer is true");
            else
                sb.AppendLine($" the correct answer is false");
            return sb.ToString();

        }
    }
}
