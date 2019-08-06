using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Limilabs.Client.IMAP;
using Limilabs.Mail;

namespace ImapSearch
{
    class Program
    {
        private const string _server = "imap.163.com";
        private const string _user = "lijingwen831@163.com";
        private const string _password = "ljw831sq";

        static void Main()
        {
            using (Imap imap = new Imap())
            {
                imap.Connect(_server);              // Use overloads or ConnectSSL if you need to specify different port or SSL.
                imap.Login(_user, _password);       // You can also use: LoginPLAIN, LoginCRAM, LoginDIGEST, LoginOAUTH methods,
                                                    // or use UseBestLogin method if you want Mail.dll to choose for you.
                imap.SelectInbox();
                // All search methods return list of unique ids of found messages.

                while (true){

                    //Console.WriteLine("--------------start-------------");

                    List<long> unseen = imap.GetAll();        // Simple 'by flag' search.

                    if (unseen.Count > 2)
                    {
                        Console.WriteLine(" more than 2");
                    }

                    //foreach (long uid in unseen)        // Download emails from the last result.
                    //{
                    //    IMail email = new MailBuilder().CreateFromEml(
                    //        imap.GetMessageByUID(uid));
                    //    Console.WriteLine("   Subject  ->  " + email.Subject);
                    //}

                    //Console.WriteLine("---------------end------------");

                    //Thread.Sleep(1000);
                }
                imap.Close();
            }
        }
    };
}
