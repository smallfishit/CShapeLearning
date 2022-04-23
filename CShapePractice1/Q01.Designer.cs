namespace CShapePractice1
{
    partial class Q01
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
            this.ScoreResultRichBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F);
            this.label1.Location = new System.Drawing.Point(106, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入考試分數：";
            // 
            // ScoreBox
            // 
            this.ScoreBox.Font = new System.Drawing.Font("新細明體", 16F);
            this.ScoreBox.Location = new System.Drawing.Point(296, 46);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(100, 33);
            this.ScoreBox.TabIndex = 1;
            // 
            // ScoreButton
            // 
            this.ScoreButton.Font = new System.Drawing.Font("新細明體", 16F);
            this.ScoreButton.Location = new System.Drawing.Point(110, 98);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(130, 37);
            this.ScoreButton.TabIndex = 2;
            this.ScoreButton.Text = "成績評斷";
            this.ScoreButton.UseVisualStyleBackColor = true;
            this.ScoreButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // ScoreResultRichBox
            // 
            this.ScoreResultRichBox.Font = new System.Drawing.Font("新細明體", 16F);
            this.ScoreResultRichBox.Location = new System.Drawing.Point(110, 152);
            this.ScoreResultRichBox.Name = "ScoreResultRichBox";
            this.ScoreResultRichBox.Size = new System.Drawing.Size(406, 33);
            this.ScoreResultRichBox.TabIndex = 3;
            // 
            // Q01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 246);
            this.Controls.Add(this.ScoreResultRichBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.ScoreBox);
            this.Name = "Q01";
            this.Text = "練習題1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.Button ScoreButton;
        private System.Windows.Forms.TextBox ScoreResultRichBox;
    }
}

