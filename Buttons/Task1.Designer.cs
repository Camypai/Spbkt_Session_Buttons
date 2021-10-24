using System.ComponentModel;


namespace Buttons
{
    partial class Task1
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
            this.backBtn  = new System.Windows.Forms.Button();
            this.writeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.textLbl  = new System.Windows.Forms.Label();
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
            // writeBtn
            // 
            this.writeBtn.Location                =  new System.Drawing.Point(12, 56);
            this.writeBtn.Name                    =  "writeBtn";
            this.writeBtn.Size                    =  new System.Drawing.Size(157, 23);
            this.writeBtn.TabIndex                =  1;
            this.writeBtn.Text                    =  "Написать";
            this.writeBtn.UseVisualStyleBackColor =  true;
            this.writeBtn.Click                   += new System.EventHandler(this.writeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location                =  new System.Drawing.Point(226, 56);
            this.clearBtn.Name                    =  "clearBtn";
            this.clearBtn.Size                    =  new System.Drawing.Size(157, 23);
            this.clearBtn.TabIndex                =  1;
            this.clearBtn.Text                    =  "Стереть";
            this.clearBtn.UseVisualStyleBackColor =  true;
            this.clearBtn.Click                   += new System.EventHandler(this.clearBtn_Click);
            // 
            // textLbl
            // 
            this.textLbl.Location  = new System.Drawing.Point(145, 112);
            this.textLbl.Name      = "textLbl";
            this.textLbl.Size      = new System.Drawing.Size(100, 23);
            this.textLbl.TabIndex  = 2;
            this.textLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(395, 198);
            this.Controls.Add(this.textLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.writeBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "Task1";
            this.Text = "Task1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label textLbl;

        private System.Windows.Forms.Button writeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label  label1;

        private System.Windows.Forms.Button backBtn;

        #endregion
    }
}