using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ComboData> combolist = new List<ComboData>();
            combolist.Add(new ComboData(((int)EWeather.SUNNY).ToString() , "晴天"));
            combolist.Add(new ComboData(((int)EWeather.CLOUDY).ToString(), "陰天"));
            combolist.Add(new ComboData(((int)EWeather.RAINY).ToString(), "雨天"));

            comboBox1.DataSource = combolist;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                ShowMessage("請輸入內容");
                return;
            }

            decimal temperature = 0;
            if(Decimal.TryParse(textBox1.Text, out temperature))
            {
                try
                {
                    EWeather weather = (EWeather)Int32.Parse(comboBox1.SelectedValue.ToString());
                    StrokeAnalysis analysis = new StrokeAnalysis();
                    var result = analysis.GetTodayStroke(dateTimePicker1.Value, temperature, weather);
                    textBox2.Text = $"{EnumToString.GetStrokeString(result.stroke)}，{EnumToString.GetActionString(result.action)}";
                }
                catch(Exception ex)
                {
                    ShowMessage(ex.Message);
                }
            }
            else
            {
                ShowMessage("請輸入數字");
            }
        }

        /// <summary>
        /// 顯示訊息
        /// </summary>
        /// <param name="text">訊息內容</param>
        private void ShowMessage(string text)
        {
            textBox2.Text = string.Empty;
            MessageBox.Show(text);
        }
    }
}
