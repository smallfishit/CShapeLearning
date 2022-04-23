using BaseProject.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShapeLearning
{
    public partial class Practice1Form : Form
    {
        public Practice1Form()
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
                Practice1Solution solution = new Practice1Solution(number);
                ScoreResultRichBox.Text = solution.ShowScoreResult();
            }
            else
            {
                ScoreResultRichBox.Text = "請輸入數字";
            }
        }
    }
}
