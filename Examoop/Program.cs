using Examoop.Model;
using System.Runtime.CompilerServices;

namespace Examoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region createexam
            int x, n;
            TimeSpan t;
            bool f;

            subject sb = new subject(1, "test");
            do
            {
                Console.WriteLine("please enter the type of exam (1:Final || 2: practical)");
                f = int.TryParse(Console.ReadLine(), out x);
            }
            while (!f);
            do
            {
                Console.WriteLine("please enter the  time of Exam");
                f = TimeSpan.TryParse(Console.ReadLine(), out t);
            }
            while (!f);
            do
            {
                Console.WriteLine("please enter the Number of Question");
                f = int.TryParse(Console.ReadLine(), out n);
            }
            while (!f);
            sb.createtheexam(t, n, x);
            if (x == 1)
            {
              
                
                for (int i = 0; i < n; i++)
                {
                    int j;
                    do
                    {
                        Console.WriteLine($"Please enter the Type of Question number {i+1}(1:for MCQ |2 For True|False )");
                        f = int.TryParse(Console.ReadLine(), out j);
                    }
                    while (!f);
                    string header;
                    string body;
                    int mark;

                    header = "";
                    do
                    {
                        Console.WriteLine("please enter of body of Question");
                        body = Console.ReadLine();

                    }
                    while (body is null);
                    do
                    {
                        Console.WriteLine("please enter the Mark of Question");
                        f = int.TryParse(Console.ReadLine(), out mark);

                    }
                    while (!f);

                     
                    if (j == 1)
                    {
                       // Console.WriteLine("here");
                        // open mcq calss
                         List<string> st = new List<string>(4);
                        do
                       {
                            Console.WriteLine("please enter the chose number one ");
                          //  st[0]= Console.ReadLine();
                        st.Add(Console.ReadLine());

                        }
                        while (st[0] is null);
                        do
                        {
                            Console.WriteLine("please enter the chose number two");
                        //  st[1] = Console.ReadLine();
                        st.Add(Console.ReadLine());


                        }
                        while (st[1] is null);
                        do
                        {
                        Console.WriteLine("please enter the chose number three ");
                        //    st[2] = Console.ReadLine();
                        st.Add(Console.ReadLine());

                        }
                        while (st[2] is null);
                         do
                        {
                        Console.WriteLine("please enter the chose number four ");
                        //    st[3] = Console.ReadLine();
                        st.Add(Console.ReadLine());

                        }
                        while (st[3] is null);
                        int answerid;
                        do
                        {
                            Console.WriteLine("Please enter the right answer id");
                            f=int.TryParse(Console.ReadLine(),out answerid);
                            
                        }
                        while (!f);
                        sb.exam.q.Add(new MCQ(body,header,mark,st,answerid))  ;
                        
                         
                        //send choose and answer of MCQ to class


                    }
                    else
                    {
                        // open  true or false
                        int flag;
                        do
                        {
                            Console.WriteLine("Please enter the right answer id (1 for true || 2 for False)");
                            f = int.TryParse(Console.ReadLine(), out flag);
                        }
                        while (!f);
                        sb.exam.q.Add(new trueFales(header, body, mark, flag));
                        // send answer

                    }
                }
              //  sb.exam.ShowExam();
            }
            else
            {
                string header;
                string body;
                int mark;
                header = "";
                do
                {
                    Console.WriteLine("please enter of body of Question");
                    body = Console.ReadLine();

                }
                while (body is null);
                do
                {
                    Console.WriteLine("please enter the Mark of Question");
                    f = int.TryParse(Console.ReadLine(), out mark);

                }
                while (!f);

                // open practical
                for (int i = 0; i < n; i++)
                {
                    List<string> st = new List<string>(4);
                    do
                    {
                        Console.WriteLine("please enter the chose number one ");
                        st.Add ( Console.ReadLine());

                    }
                    while (st[0] is null);
                    do
                    {
                        Console.WriteLine("please enter the chose number two");
                        st.Add(Console.ReadLine());

                    }
                    while (st[1] is null);
                    do
                    {
                        Console.WriteLine("please enter the chose number three ");
                        st.Add(Console.ReadLine());

                    }
                    while (st[2] is null);
                    do
                    {
                        Console.WriteLine("please enter the chose number four ");
                        st.Add(Console.ReadLine());

                    }
                    while (st[3] is null);
                    int answerid;
                    do
                    {
                        Console.WriteLine("Please enter the right answer id");
                        f = int.TryParse(Console.ReadLine(), out answerid);

                    }
                    while (!f);
                    sb.exam.q.Add ( new MCQ(body, header, mark, st, answerid));
                }
                //sb.exam.ShowExam();
            }
            #endregion

            #region startofexam
            char start;
            bool fl;
            Console.Clear();

            do
            {
            Console.WriteLine("Do you want to start of exam (Y => yes || N => no)");
                fl = char.TryParse(Console.ReadLine(), out start);
            }
            while (!fl);
            DateTime starttime;
            start = char.ToUpper(start);

            if (start== 'Y')
            {
                starttime = DateTime.Now;
                for (int i = 0; i < sb.exam.q.Count; i++)
                {
                    sb.exam.q[i].showquestion();
                    Console.WriteLine("================================");
                }
                Console.Clear();
                Console.WriteLine($"the time of exam is :{DateTime.Now-starttime}");
                sb.exam.ShowExam();
            }
           
           
            #endregion
        }
    }
}
