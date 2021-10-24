using System.ComponentModel;


namespace Buttons
{
    partial class Task2
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
            this.panel1    = new System.Windows.Forms.Panel();
            this.write4Btn = new System.Windows.Forms.Button();
            this.write3Btn = new System.Windows.Forms.Button();
            this.write2Btn = new System.Windows.Forms.Button();
            this.write1Btn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.write4Btn);
            this.panel1.Controls.Add(this.write3Btn);
            this.panel1.Controls.Add(this.write2Btn);
            this.panel1.Controls.Add(this.write1Btn);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name     = "panel1";
            this.panel1.Size     = new System.Drawing.Size(156, 118);
            this.panel1.TabIndex = 1;
            // 
            // write4Btn
            // 
            this.write4Btn.Location                =  new System.Drawing.Point(3, 90);
            this.write4Btn.Name                    =  "write4Btn";
            this.write4Btn.Size                    =  new System.Drawing.Size(150, 23);
            this.write4Btn.TabIndex                =  0;
            this.write4Btn.Text                    =  "Кнопка 4";
            this.write4Btn.UseVisualStyleBackColor =  true;
            this.write4Btn.Click                   += new System.EventHandler(this.write4Btn_Click);
            // 
            // write3Btn
            // 
            this.write3Btn.Location                =  new System.Drawing.Point(3, 61);
            this.write3Btn.Name                    =  "write3Btn";
            this.write3Btn.Size                    =  new System.Drawing.Size(150, 23);
            this.write3Btn.TabIndex                =  0;
            this.write3Btn.Text                    =  "Кнопка 3";
            this.write3Btn.UseVisualStyleBackColor =  true;
            this.write3Btn.Click                   += new System.EventHandler(this.write3Btn_Click);
            // 
            // write2Btn
            // 
            this.write2Btn.Location                =  new System.Drawing.Point(3, 32);
            this.write2Btn.Name                    =  "write2Btn";
            this.write2Btn.Size                    =  new System.Drawing.Size(150, 23);
            this.write2Btn.TabIndex                =  0;
            this.write2Btn.Text                    =  "Кнопка 2";
            this.write2Btn.UseVisualStyleBackColor =  true;
            this.write2Btn.Click                   += new System.EventHandler(this.write2Btn_Click);
            // 
            // write1Btn
            // 
            this.write1Btn.Location                =  new System.Drawing.Point(3, 3);
            this.write1Btn.Name                    =  "write1Btn";
            this.write1Btn.Size                    =  new System.Drawing.Size(150, 23);
            this.write1Btn.TabIndex                =  0;
            this.write1Btn.Text                    =  "Кнопка 1";
            this.write1Btn.UseVisualStyleBackColor =  true;
            this.write1Btn.Click                   += new System.EventHandler(this.write1Btn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.Location = new System.Drawing.Point(12, 162);
            this.resultLbl.Name     = "resultLbl";
            this.resultLbl.Size     = new System.Drawing.Size(156, 23);
            this.resultLbl.TabIndex = 2;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(182, 195);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBtn);
            this.Name = "Task2";
            this.Text = "Task2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label  resultLbl;
        private System.Windows.Forms.Button write1Btn;
        private System.Windows.Forms.Button write2Btn;
        private System.Windows.Forms.Button write3Btn;
        private System.Windows.Forms.Button write4Btn;

        private System.Windows.Forms.Panel  panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button backBtn;

        #endregion
    }
}