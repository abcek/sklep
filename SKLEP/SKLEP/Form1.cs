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
    public partial class FormStart : Form
    {
        SKLEPEntities sklepEntities = new SKLEPEntities();
        public FormStart()
        {
            InitializeComponent();
        }

        private void Open_Laptopy_Click(object sender, EventArgs e)
        {
            GridLaptopy listalaptopy = new GridLaptopy(sklepEntities);
            listalaptopy.Show();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }
    }
}
