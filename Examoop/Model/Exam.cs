using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examoop.Model
{
    internal abstract class Exam
    {
		private TimeSpan time;

		public TimeSpan Time
		{
			get { return time; }
			set { time = value; }
		}
		private int numberofquestion;

		public int Numberofquestion
		{
			get { return numberofquestion; }
			set { numberofquestion = value; }
		}
		public List<Question> q { get; set; }

		 public Exam( TimeSpan time,int num)
		{
			this.time = time;
			numberofquestion = num;
			q= new List<Question>();
		}
		public abstract void  ShowExam();

	}
}
