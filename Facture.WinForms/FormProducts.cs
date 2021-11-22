using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facture.BO;

namespace Facture.WinForms
{
    public partial class FormProducts : Form
    {
        public List<Product> products;
        
        public FormProducts()
        { 
            InitializeComponent();
          
        }

        private void btnDP_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                DialogResult r = MessageBox.Show("Voulez vous vraiment effacer le contenu ?",
              "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    listView1.Items.Clear();
                }
            }
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            var user = listView1.SelectedItems[0].Tag as Product;
            FormProducts form = new FormProducts();
            form.ShowDialog();
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView1.Items.Add(txtDesignation.Text);
            lvi.SubItems.Add(txtMontant_ht.Text);
            lvi.SubItems.Add(txtName.Text);
            lvi.SubItems.Add(txtNum.Text);
            
        
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            Hide();
            formPreview form = new formPreview();
            form.ShowDialog();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {

        }
    }

   
}
