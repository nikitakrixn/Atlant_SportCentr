using Atlant_Project.Class;
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
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadServers()
        {
            cmbServer.Clear();
            cmbServer.AddItem(Environment.MachineName);
            cmbServer.AddItem(@".\SQLEXPRESS");
            cmbServer.AddItem(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cmbServer.selectedIndex = 2;
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (txtNameBD.Text.Length >= 3)
            {
                Settings.SettingsConnect.Enabled = true;
                Settings.SettingsConnect.DataBase = txtNameBD.Text;
                Settings.SettingsConnect.Server = cmbServer.selectedValue;
            }
            else MessageBox.Show("Поле не должно быть пустым");
            
            
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            LoadServers();
        }
    }
}
