using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

namespace Threading
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadA;
        private Thread ThreadB;
        ThreadStart ts1 = new ThreadStart(MyThreadClass.Thread1);
        ThreadStart ts2 = new ThreadStart(MyThreadClass.Thread1);
        public FrmBasicThread()
        {
            InitializeComponent();
            ThreadA = new Thread(ts1);
            ThreadB = new Thread(ts2);

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void btnStart_Click(object sender, EventArgs e)
        {
           
            try
            {
                AllocConsole();
                lblStatusOfThread.Text = "-Thread is Running-";


                ThreadA.Start();
                ThreadB.Start();
                ThreadB.Join();
                ThreadA.Join();

                if (!ThreadA.IsAlive && !ThreadB.IsAlive)
                {
                    Console.WriteLine("-End Of Thread-");
                    lblStatusOfThread.Text = "-End Of Thread-";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {

            }
        }
    } 
}
