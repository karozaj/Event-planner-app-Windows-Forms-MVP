using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_mvp
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Repositories.EventRepository rep=new Repositories.EventRepository();
            Views.EventView view=new Views.EventView();
            Presenters.EventViewPresenter pres=new Presenters.EventViewPresenter(view, rep);
            //Application.Run(new Form1());
            Application.Run((Form)view);
        }
    }
}
