using System.ComponentModel;


namespace Buttons
{
    partial class Task5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.backBtn   = new System.Windows.Forms.Button();
            this.label1    = new System.Windows.Forms.Label();
            this.label2    = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.xTb       = new System.Windows.Forms.TextBox();
            this.calcBtn   = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location                =  new System.Drawing.Point(12, 12);
            this.backBtn.Name                    =  "backBtn";
            this.backBtn.Size                    =  new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex                =  0;
            this.backBtn.Text                    =  "Назад";
            this.backBtn.UseVisualStyleBackColor =  true;
            this.backBtn.Click                   += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.Font     = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name     = "label1";
            this.label1.Size     = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 1;
            this.label1.Text     = "X:";
            // 
            // label2
            // 
            this.label2.Font     = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name     = "label2";
            this.label2.Size     = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 2;
            this.label2.Text     = "Y =";
            // 
            // resultLbl
            // 
            this.resultLbl.Font     = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLbl.Location = new System.Drawing.Point(63, 84);
            this.resultLbl.Name     = "resultLbl";
            this.resultLbl.Size     = new System.Drawing.Size(75, 23);
            this.resultLbl.TabIndex = 3;
            // 
            // xTb
            // 
            this.xTb.Font     = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xTb.Location = new System.Drawing.Point(63, 58);
            this.xTb.Name     = "xTb";
            this.xTb.Size     = new System.Drawing.Size(100, 29);
            this.xTb.TabIndex = 4;
            // 
            // calcBtn
            // 
            this.calcBtn.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcBtn.Location                =  new System.Drawing.Point(12, 110);
            this.calcBtn.Name                    =  "calcBtn";
            this.calcBtn.Size                    =  new System.Drawing.Size(151, 41);
            this.calcBtn.TabIndex                =  5;
            this.calcBtn.Text                    =  "Посчитать";
            this.calcBtn.UseVisualStyleBackColor =  true;
            this.calcBtn.Click                   += new System.EventHandler(this.calcBtn_Click);
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(179, 164);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.xTb);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Name = "Task5";
            this.Text = "Task5";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button calcBtn;

        private System.Windows.Forms.Label   label2;
        private System.Windows.Forms.Label   resultLbl;
        private System.Windows.Forms.TextBox xTb;
        private System.Windows.Forms.Button  button1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button backBtn;

        #endregion
    }
}