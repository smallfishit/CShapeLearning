namespace CShapeLearning
{
    partial class Practice1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ScoreResultRichBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F);
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入考試分數：";
            // 
            // ScoreBox
            // 
            this.ScoreBox.Font = new System.Drawing.Font("新細明體", 16F);
            this.ScoreBox.Location = new System.Drawing.Point(205, 35);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(100, 33);
            this.ScoreBox.TabIndex = 1;
            // 
            // ScoreButton
            // 
            this.ScoreButton.Font = new System.Drawing.Font("新細明體", 16F);
            this.ScoreButton.Location = new System.Drawing.Point(19, 87);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(130, 37);
            this.ScoreButton.TabIndex = 2;
            this.ScoreButton.Text = "成績評斷";
            this.ScoreButton.UseVisualStyleBackColor = true;
            this.ScoreButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ScoreResultRichBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ScoreButton);
            this.groupBox1.Controls.Add(this.ScoreBox);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 16F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 193);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "練習題1";
            // 
            // ScoreResultRichBox
            // 
            this.ScoreResultRichBox.Font = new System.Drawing.Font("新細明體", 16F);
            this.ScoreResultRichBox.Location = new System.Drawing.Point(19, 141);
            this.ScoreResultRichBox.Name = "ScoreResultRichBox";
            this.ScoreResultRichBox.Size = new System.Drawing.Size(406, 33);
            this.ScoreResultRichBox.TabIndex = 3;
            // 
            // Practice1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 557);
            this.Controls.Add(this.groupBox1);
            this.Name = "Practice1Form";
            this.Text = "練習題題庫1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.Button ScoreButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ScoreResultRichBox;
    }
}