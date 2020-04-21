
using System;
using System.Threading;
using System.Windows.Forms;

namespace Lab9_Parallelism
{
    public partial class AppForm : Form
    {
        private System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        private readonly object balanceLock = new object();
        const int DEFAULT_TIME = 3;
        const int DEFAULT_CNT = 5;
        int time = 3;
        public static int cnt = 5;
        public static int counter = 0;

        public AppForm()
        {
            InitializeComponent();
            t.Interval = 200;
            cntTB.TextChanged += new System.EventHandler(cnt_Changed);
            timeTB.TextChanged += new System.EventHandler(time_Changed);
            hide.CheckedChanged += new EventHandler(hide_Click);
            t.Tick+= new EventHandler(t_Tick);
        }
        /// <summary>
        /// Показ или остановка создания окружностей
        /// </summary>
        private void hide_Click(object sender, EventArgs e)
        {
            if (hide.Checked)
            {
                t.Enabled = true;
            }
            else
            {
                t.Enabled = false ;
            }
        }
        /// <summary>
        /// Генерация потоков для отрисовки кругов
        /// </summary>
        private void t_Tick(object sender, EventArgs e)
        {
            lock(balanceLock) {
                if (counter < AppForm.cnt)
                {
                    counter++;
                    Thread t = new Thread(new ThreadStart(new Circle(time, area.CreateGraphics(), area.Width, area.Height).Run));
                    t.Start();
                }
            }
        }
        /// <summary>
        /// Смена максимального числа окружностей на экране
        /// </summary>
        /// <param name="o"></param>
        /// <param name="e"></param>
        private void cnt_Changed(object o, System.EventArgs e)
        {
            if (!Int32.TryParse(cntTB.Text, out cnt))
            {
                cnt = DEFAULT_CNT;
            }
            
        }
        /// <summary>
        /// Смена времени жизни окружности
        /// </summary>
        private void time_Changed(object o, System.EventArgs e)
        {
            if (!Int32.TryParse(timeTB.Text, out time))
            {
                time = DEFAULT_TIME;
            }
            if (time > 5) time = 5;
        }
    }
}