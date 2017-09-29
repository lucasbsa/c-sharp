using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxColunas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Items.AddRange(new object[] {
            "Itemsasas 1, column 1",
            "Item 2    , column 1",
            "Item dsd 3, column 1",
            "Itemd 4, column 1",
            "Itemdd 5, column 1",
            "Item d1, column 2",
            "Item    2, column 2",
            "Item  3, column 2",
         
            });
          //  this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
           this.listBox1.ScrollAlwaysVisible = true;
           this.listBox1.Size = new System.Drawing.Size(300, 200);
            this.listBox1.TabIndex = 0;
            this.listBox1.ColumnWidth = 85;
        }
    }
}
