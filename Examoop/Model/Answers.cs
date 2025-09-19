using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examoop.Model
	{
		internal class Answers
		{
			private int answerid;

			public int Answerid
			{
				get { return answerid; }
				set { answerid = value; }
			}
			private string  answertext;

			public string  Answertext
			{
				get { return answertext; }
				set { answertext = value; }
			}

		public 	Answers( int id,string text)
			{
				answerid= id;
				Answertext = text;

			}




		}
	}
