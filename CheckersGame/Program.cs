using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersGame
{
    static class Program
    {
        //ffsdfsdf
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        //в данной части кода идет включение визуальных стилей
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
