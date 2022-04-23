using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingFee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy/MM/dd HH:mm:ss";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ParkingFeeCalculator parkFee = new ParkingFeeCalculator(dateTimePicker1.Value, dateTimePicker2.Value);
                //計算應付停車費及停車總小時數、分鐘數
                var result = parkFee.GetFeeFromDate();
                richTextBox1.Text = $"小時數 = {result.hours}{Environment.NewLine}分鐘數 = {result.minutes}{Environment.NewLine}總金額 = {result.fee}";
            }
            catch (Exception ex)
            {
                richTextBox1.Text = string.Empty;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
