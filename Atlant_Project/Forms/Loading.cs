using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlant_Project.Forms
{
    public partial class Loading : Form
    {
        private int plus = 3;

        public Loading()
        {
            InitializeComponent();
        }

        private void move(object sender, EventArgs e)
        {
            pnlLoading.Left += plus;

            if (pnlLoading.Left > 218) { plus = -2; }
            if (pnlLoading.Left < 0) { plus = 2; }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            TimerLoad.Tick += new EventHandler(move);
            TimerLoad.Interval = 10;
            TimerLoad.Start();
            Main();
        }

        private async void Main()
        {
            AuthForm loginsql = new AuthForm();
            lblPreloadText.Text = "Загрузка, пожалуйста подождите...";
        begin:
            await Task.Delay(2000);
            lblPreloadText.Text = "Идёт соединение с базой данных...";
            loginsql.ShowDialog();
            if (loginsql.connect == true)
            {
                lblPreloadText.Text = "Соединение с базой данных выполнено...";
            }
            else
            {
                lblPreloadText.Text = "Ошибка с подключением базой данных...";
                await Task.Delay(2000);
                lblPreloadText.Text = "Повторите попытку";
                goto begin;
            }
            await Task.Delay(2000);
            lblPreloadText.Text = "Загрузка, пожалуйста подождите...";
            await Task.Delay(2000);
            Main mainform = new Main();
            mainform.Show();
            this.Hide();
        }
    }
}
