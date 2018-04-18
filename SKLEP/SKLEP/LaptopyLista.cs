using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKLEP
{


    public partial class GridLaptopy : Form
    {
        SKLEPEntities db;
        public GridLaptopy(SKLEPEntities sKLEPEntities)
        {
            db = sKLEPEntities;
            InitializeComponent();
        }

        private void GridLaptopy_Load(object sender, EventArgs e)
        {
            this.gridVIew.DataSource = db.Laptop.ToList();
        }

        private void gridVIew_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           Laptop selectedLaptop = (Laptop)((DataGridView)sender).CurrentRow.DataBoundItem;
            Label Label = new Label(selectedLaptop, db);
            Label.Show();
        }
    }
}
