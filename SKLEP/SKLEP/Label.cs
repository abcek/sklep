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
    public partial class Label : Form
    {
        Laptop laptop;
        SKLEPEntities db;
        public Label(Laptop laptop, SKLEPEntities db)
        {
            this.db = db;
            this.laptop = laptop;
            InitializeComponent();
        }

        private void Label_Load(object sender, EventArgs e)
        {
            this.textprocesor.Text = laptop.procesor.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            laptop.procesor = int.Parse(this.textprocesor.Text);
            db.SaveChanges();
        }
    }
}
