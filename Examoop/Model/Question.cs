using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examoop.Model
{
    internal abstract class Question
    {
		private string header;

		public string Header
		{
			get { return header; }
			set { header = value; }
		}
		private string body;

		public string Body
		{
			get { return body; }
			set { body = value; }
		}
		private double mark;

		public double Mark
		{
			get { return mark; }
			set { mark = value; }

		}
		public List<Answers>  answers{ get; set; }
		private int rightanswer;

		public int Rightanswer
		{
			get { return rightanswer; }
			set { rightanswer = value; }
		}

		 
			



		public Question(string header,string body,double mark)
		{
			this.header = header;
			this.body = body;
			this.mark = mark;
            answers = new List<Answers>();
        
		}
		public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Header: {Header}");
            sb.AppendLine($"Body: {Body}");
            sb.AppendLine($"Mark: {Mark}");
            //sb.AppendLine("Answers:");
            //for (int i = 0; i < answers.Count; i++)
            //{
            //    sb.AppendLine($"{i + 1}. {answers[i].Answertext}");
            //}
            return sb.ToString();
        }
		public abstract void showquestion(); 
		




	}
}
