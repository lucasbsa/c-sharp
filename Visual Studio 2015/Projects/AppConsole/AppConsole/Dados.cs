using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsole
{
    public partial class Dados : Form
    {
        public Dados()
        {
            InitializeComponent();
        }

        private void Dados_Load(object sender, EventArgs e)
        {

        }

        private void colocar_dados_listBox_Click(object sender, EventArgs e)
        {
            // Create an instance of the ListBox.
            // Set the size and location of the ListBox.
         
            // Add the ListBox to the form.this.Controls.Add(listBox1);
            // Set the ListBox to display items in multiple columns.
            // Set the selection mode to multiple and extended.

            // Shutdown the painting of the ListBox as items are added.
            // Loop through and add 50 items to the ListBox.
            
                for (int x = 1; x <= 50; x++)
                    listBox1.Items.Add("Item " + x.ToString());
            
            // Allow the ListBox to repaint and display the new items.
            //listBox1.EndUpdate();

            // Select three items from the ListBox.
          
        }
    }
}
