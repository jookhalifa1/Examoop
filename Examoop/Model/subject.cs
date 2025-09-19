using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examoop.Model
{
    internal class subject
    {
		private int subjectid;

		public int Subjectid
		{
			get { return subjectid; }
			set { subjectid = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		 public Exam exam { get; set; }
		 public subject( int id,string name) 
		{
			this.name = name;
			subjectid = id;
		}

		public void createtheexam(TimeSpan t, int n,int type)
		{
			if (type == 1)
			{
				exam = new final(t, n);
			}
			else
			{
				exam=new practical(t, n);
			}
			
		}




	}
}
