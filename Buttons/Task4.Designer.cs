using System.ComponentModel;


namespace Buttons
{
    partial class Task4
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
            this.lengthTb  = new System.Windows.Forms.TextBox();
            this.calcBtn   = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name     = "label1";
            this.label1.Size     = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 1;
            this.label1.Text     = "Расстояние (см):";
            // 
            // lengthTb
            // 
            this.lengthTb.Font     = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthTb.Location = new System.Drawing.Point(198, 56);
            this.lengthTb.Name     = "lengthTb";
            this.lengthTb.Size     = new System.Drawing.Size(100, 29);
            this.lengthTb.TabIndex = 2;
            // 
            // calcBtn
            // 
            this.calcBtn.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcBtn.Location                =  new System.Drawing.Point(12, 91);
            this.calcBtn.Name                    =  "calcBtn";
            this.calcBtn.Size                    =  new System.Drawing.Size(286, 49);
            this.calcBtn.TabIndex                =  3;
            this.calcBtn.Text                    =  "Перевести";
            this.calcBtn.UseVisualStyleBackColor =  true;
            this.calcBtn.Click                   += new System.EventHandler(this.calcBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.Font     = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLbl.Location = new System.Drawing.Point(12, 143);
            this.resultLbl.Name     = "resultLbl";
            this.resultLbl.Size     = new System.Drawing.Size(286, 23);
            this.resultLbl.TabIndex = 4;
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.lengthTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Name = "Task4";
            this.Text = "Task4";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label  resultLbl;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox lengthTb;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button backBtn;

        #endregion
    }
}