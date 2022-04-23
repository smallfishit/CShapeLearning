using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ScoreButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ScoreBox.Text))
            {
                ShowMessage("請輸入內容");
                return;
            }

            int number = 0;
            if (Int32.TryParse(ScoreBox.Text, out number))
            {
                try
                {
                    ScoreAnalysis analysis = new ScoreAnalysis();
                    ScoreResultRichBox.Text = analysis.ShowScoreResult(number);
                }
                catch (Exception ex)
                {
                    ShowMessage(ex.Message);
                }
            }
            else
            {
                ShowMessage("請輸入內容");
            }
        }

        /// <summary>
        /// 顯示訊息
        /// </summary>
        /// <param name="text">訊息內容</param>
        private void ShowMessage(string text)
        {
            ScoreResultRichBox.Text = string.Empty;
            MessageBox.Show(text);
        }
    }
}
