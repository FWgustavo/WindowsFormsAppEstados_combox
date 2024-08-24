using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEstados_combox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstados_Click(object sender, EventArgs e)
        {
            string estado = cboEstados.SelectedItem.ToString();
            if (estado == "SP" | estado == "RJ" | estado == "MG" | estado == "ES")
            {
                cboSudeste.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboSudeste.Focus();
            }
            else if (estado == "AM" | estado == "PA" | estado == "AC" | estado == "RR" | estado == "RO" | estado == "AP" | estado == "TO")
            {
                cboNorte.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboNorte.Focus();
            }
            else if (estado == "AL" | estado == "BA" | estado == "CE" | estado == "MA" | estado == "PB" | estado == "PE" | estado == "PI" | estado == "RN" | estado == "SE")
            {
                cboNordeste.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboNordeste.Focus();
            }
            else if (estado == "SC" | estado == "RS" | estado == "PR")
            {
                cboSul.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboSul.Focus();
            }
            else if (estado == "GO" | estado == "MT" | estado == "MS" | estado == "DF")
            {
                cboCentro.Items.Add(cboEstados.SelectedItem.ToString());
                cboEstados.Items.Remove(cboEstados.SelectedItem.ToString());
                cboCentro.Focus();
            }

            lblEstados.Text = cboEstados.Items.Count.ToString();
            lblCentro.Text = cboCentro.Items.Count.ToString();
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
            lblNorte.Text = cboNorte.Items.Count.ToString();
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
            lblSul.Text = cboSul.Items.Count.ToString();
            cboCentro.Sorted = true;
            cboEstados.Sorted = true;
            cboNordeste.Sorted = true;
            cboNorte.Sorted = true;
            cboSudeste.Sorted = true;
            cboSul.Sorted = true;
            cboEstados.ResetText();
            btnEstados.Visible = false;
        }

        private void btnNorte_Click(object sender, EventArgs e)
        {
            string estado = cboNorte.SelectedItem.ToString();
            if (estado == "AM" | estado == "PA" | estado == "AC" | estado == "RR" | estado == "RO" | estado == "AP" | estado == "TO")
            {
                cboEstados.Items.Add(cboNorte.SelectedItem.ToString());
                cboNorte.Items.Remove(cboNorte.SelectedItem.ToString());
                cboNorte.ResetText();
                lblNorte.Text = cboNorte.Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnNorte.Visible = false;
            }
        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {
            string estado = cboNordeste.SelectedItem.ToString();
            if (estado == "AL" | estado == "BA" | estado == "CE" | estado == "MA" | estado == "PB" | estado == "PE" | estado == "PI" | estado == "RN" | estado == "SE")
            {
                cboEstados.Items.Add(cboNordeste.SelectedItem.ToString());
                cboNordeste.Items.Remove(cboNordeste.SelectedItem.ToString());
                cboNordeste.ResetText();
                lblNordeste.Text = cboNordeste.Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnNordeste.Visible = false;
            }
        }

        private void btnCentro_Click(object sender, EventArgs e)
        {
            string estado = cboCentro.SelectedItem.ToString();
            if (estado == "GO" | estado == "MT" | estado == "MS" | estado == "DF")
            {
                cboEstados.Items.Add(cboCentro.SelectedItem.ToString());
                cboCentro.Items.Remove(cboCentro.SelectedItem.ToString());
                cboCentro.ResetText();
                lblCentro.Text = cboCentro.Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnCentro.Visible = false;
            }
        }

        private void btnSudeste_Click(object sender, EventArgs e)
        {
            string estado = cboSudeste.SelectedItem.ToString();
            if (estado == "SP" | estado == "RJ" | estado == "MG" | estado == "ES")
            {
                cboEstados.Items.Add(cboSudeste.SelectedItem.ToString());
                cboSudeste.Items.Remove(cboSudeste.SelectedItem.ToString());
                cboSudeste.ResetText();
                lblSudeste.Text = cboSudeste.Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnSudeste.Visible = false;
            }
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            string estado = cboSul.SelectedItem.ToString();
            if (estado == "SC" | estado == "RS" | estado == "PR")
            {
                cboSudeste.Items.Add(cboSul.SelectedItem.ToString());
                cboSul.Items.Remove(cboSul.SelectedItem.ToString());
                cboSul.ResetText();
                lblSul.Text = cboSul.Items.Count.ToString();
                lblEstados.Text = cboEstados.Items.Count.ToString();
                cboEstados.Sorted = true;
                btnSul.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEstados.Visible = false;
            btnNorte.Visible = false;
            btnNordeste.Visible = false;
            btnCentro.Visible = false;
            btnSudeste.Visible = false;
            btnSul.Visible = false;
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cboEstados.SelectedItem.ToString();
            btnEstados.Visible = false;
            if (estado != "") 
            { btnEstados.Visible = true; }
        }

        private void cboNorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cboNorte.SelectedItem.ToString();
            btnEstados.Visible = false;
            if (estado != "")
            { btnNorte.Visible = true; }
        }

        private void cboNordeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cboNordeste.SelectedItem.ToString();
            btnNordeste.Visible = false;
            if (estado != "")
            { btnNordeste.Visible = true; }
        }

        private void cboCentro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cboCentro.SelectedItem.ToString();
            btnCentro.Visible = false;
            if (estado != "")
            { btnCentro.Visible = true; }
        }

        private void cboSudeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cboSudeste.SelectedItem.ToString();
            btnSudeste.Visible = false;
            if (estado != "")
            { btnSudeste.Visible = true; }
        }

        private void cboSul_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cboSul.SelectedItem.ToString();
            btnSul.Visible = false;
            if (estado != "")
            { btnSul.Visible = true; }
        }
    }
}
