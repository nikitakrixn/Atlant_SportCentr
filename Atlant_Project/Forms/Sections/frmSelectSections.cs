using Atlant_Project.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlant_Project.Forms.Sections
{
    public partial class frmSelectSections : Form
    {
        private AtlantEntities database;

        public string NameSection;
        public frmSelectSections()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateDatatoDatagrid()
        {
            var results = database.Instructor.Select(r => r).Where(r => r.Vid_sporta.Contains(NameSection));

            grid.Rows.Clear();
            foreach (var inst in results)
            {
                grid.Rows.Add(
                           new object[]
                           {
                               inst.FirstName,
                               inst.LastName,
                               inst.Exp + " месяц",
                           }
                          );
                grid.Rows[grid.RowCount - 1].Tag = inst;
            }
        }

        private void frmSelectSections_Load(object sender, EventArgs e)
        {
            PopulateDatatoDatagrid();
        }
    }
}
