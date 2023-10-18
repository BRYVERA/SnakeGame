using System;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;

namespace SnakeGame_Server
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (FirstInstance)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmServer());
            }
            else
            {
                MessageBox.Show("El servidor ya se encuentra abierto", "Snake Game - Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private static bool FirstInstance
        {
            get
            {
                bool created;
                string name = Assembly.GetEntryAssembly().FullName;
                Mutex mutex = new Mutex(true, name, out created);
                return created;
            }
        }
    }
}
