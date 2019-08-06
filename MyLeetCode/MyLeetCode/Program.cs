using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLeetCode
{
    public class Program
    {
        private static int a = 1;

        private static int b = 2;

        public static class A
        {
            public static int b = 2;
        }

        public static void Main()
        {

            using (Imap imap = new Imap())
            {
                imap.Connect("imap.server.com");
                imap.UseBestLogin("lijingwen831@163.com", "ljw831wy");
                imap.SelectInbox();
                List<long> uids = imap.Search(Flag.Unseen);
                foreach (long uid in uids)
                {
                    IMail email = new MailBuilder()
                        .CreateFromEml(imap.GetMessageByUID(uid));
                    Console.WriteLine(email.Subject);
                }
                imap.Close();
            }



            Console.WriteLine(A.b);
            Console.ReadLine();
        }
    }
}
