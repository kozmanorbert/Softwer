using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class StockMain : Form
    {
        public StockMain()
        {
            InitializeComponent();
            stockUserControl1.Visible = false;
            productsUserControl1.Visible = false;
        }
        private void StockMain_Load(object sender, EventArgs e)
        {
            panelForButton.Height = stockButton.Height;
            panelForButton.Top = stockButton.Top;
            stockUserControl1.Visible = true;
            productsUserControl1.Visible = false;
        }

        bool close = true;
        private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            panelForButton.Height = productsButton.Height;
            panelForButton.Top = productsButton.Top;
            stockUserControl1.Visible = false;
            productsUserControl1.Visible = true;
        }

      

        private void stockButton_Click(object sender, EventArgs e)
        {
            panelForButton.Height = stockButton.Height;
            panelForButton.Top = stockButton.Top;
            stockUserControl1.Visible = true;
            productsUserControl1.Visible = false;
        }

    
    }
}

