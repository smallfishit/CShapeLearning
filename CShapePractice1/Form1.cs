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
                ScoreResultRichBox.Text = "請輸入內容";
                return;
            }
            int number = 0;
            if (Int32.TryParse(ScoreBox.Text, out number))
            {
                ScoreAnalysis analysis = new ScoreAnalysis();
                ScoreResultRichBox.Text = analysis.ShowScoreResult(number);
            }
            else
            {
                ScoreResultRichBox.Text = "請輸入數字";
            }
        }
    }
}
