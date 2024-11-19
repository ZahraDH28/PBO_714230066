using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714230066
{
    public partial class Form1 : Form
    {
        public object ComboBoxAngkatan { get; private set; }

        public Form1()
        {
            InitializeComponent();
            Size = new Size(330, 230);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TextBoxNama.Text))
            {
                errorMessage.AppendLine("Nama Harus Diisi");
            }

            if (comboBoxAngkatan.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Angkatan Harus Diisi");
            }

            if (string.IsNullOrWhiteSpace(TextBoxKelas.Text))
            {
                errorMessage.AppendLine("Kelas Harus Diisi");
            }

            string errorMsg = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(
                "Lengkap!!",
                "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Size = new Size(330, 500);
            }

            else
            {
                MessageBox.Show(
                errorMsg.Trim(),
                "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonWeekday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekday.Checked)
            {
                checkBoxKuliah.Enabled = true; checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = false; checkBoxLiburan.Checked = false;
            }

        }

        private void radioButtonWeekend_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxKuliah.Enabled = false; checkBoxKuliah.Checked = false;
            checkBoxTidur.Enabled = true; checkBoxTidur.Checked= false;
            checkBoxLiburan.Enabled = true; checkBoxLiburan.Checked = false;
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            string hari = null;
            string kegiatan = null;

            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    hari = radioButton.Text;
                    break;
                }
            }

            foreach (Control control in Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    if (!string.IsNullOrEmpty(kegiatan))
                    {
                        kegiatan += ",";
                    }
                    kegiatan += checkBox.Text;
                }


            }
            MessageBox.Show(
                    "Nama: " + TextBoxNama.Text + "\n" +
                    "Angkatan: " + comboBoxAngkatan.Text + "\n" +
                    "Kelas: " + TextBoxKelas.Text + "\n" +
                    "=======================================\n" +
                    "Hari: " + hari + "\n" +
                    "Kegiatan: " + kegiatan + "\n",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

            ////menggunakan LINQ 
            //string hari = Controls.OfType<RadioButton>()
            //    .FirstOrDefault(rb => rb.Checked)?.Text;

            //string kegiatan = string.Join(",",
            //    Controls.OfType<CheckBox>()?
            //    .Where(cb => cb.Checked)
            //    .Select(cb => cb.Text));
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //TextBoxNama.Text = "";
            //comboBoxAngkatan.SelectedIndex = -1;
            //TextBoxKelas.Text = "";
            //radioButtonWeekday.Checked = false;
            //radioButtonWeekend.Checked = false;
            //checkBoxKuliah.Checked = false;
            //checkBoxLiburan.Checked = false;
            //checkBoxTidur.Checked = false;
            Size = new Size(330, 230);

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }

                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }

                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }

                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                    checkBox.Enabled = true;
                }
            }

                    MessageBox.Show(
                    "Berhasil Di Reset",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
         
        }
    }
}
