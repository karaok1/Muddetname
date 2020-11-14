using MetroFramework.Forms;
using NodaTime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarihHesabi
{
    public partial class Form1 : MetroForm
    {
        bool trial = false;
        Ceza ceza = new Ceza();
        public Form1()
        {
            InitializeComponent();
            metroComboBox1.SelectedIndex = 0;
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            if (metroTextBoxYil.Text == "0")
            {
                metroTextBoxYil.Text = "";
            }
        }

        private void metroTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double oran;
                double oranliSure;
                CultureInfo culture = new CultureInfo("tr-TR");
                DateTime pickerValue = dateTimePicker1.Value;
                DateTime pickerValue2 = dateTimePicker1.Value;
                int gun = Convert.ToInt32(metroTextBoxGun.Text),
                    ay = Convert.ToInt32(metroTextBoxAy.Text),
                    yil = Convert.ToInt32(metroTextBoxYil.Text);
                pickerValue = pickerValue.AddDays(gun);
                pickerValue = pickerValue.AddDays(ay * 30);
                pickerValue = pickerValue.AddDays(yil * 365);
                var eklenecekSure = CustomHelper.ConvertToTimeSpan(gun, ay, yil);
                if (metroComboBox1.SelectedIndex == 0)
                {
                    oran = 1;
                }
                else
                {
                    oran = CustomHelper.FractionToDouble(metroComboBox1.SelectedItem.ToString());
                }
                oranliSure = eklenecekSure.TotalDays * oran - 1;
                var sonucB = pickerValue2.Add(TimeSpan.FromDays(oranliSure));
                metroTextBox2.Text = sonucB.ToString("d", culture);

                    // ListView

                metroTextBox1.Text = pickerValue.ToString("d", culture);
                ListViewItem item = new ListViewItem(metroTextBoxYil.Text);
                item.SubItems.Add(metroTextBoxAy.Text);
                item.SubItems.Add(metroTextBoxGun.Text);
                item.SubItems.Add(eklenecekSure.TotalDays.ToString());
                item.SubItems.Add(oran.ToString());
                item.SubItems.Add(TimeSpan.FromDays(oranliSure).Days.ToString());
                listView1.Items.Add(item);
                
            }
        }

        private void textBoxZaman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
