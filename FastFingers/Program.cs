using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace FastFingers
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!File.Exists("Users.xml"))
            {
                XDocument UsersDoc = new XDocument(new XElement("Users"));
                UsersDoc.Save("Users.xml");
            }

            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }
    }
}
