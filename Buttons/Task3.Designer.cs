using System.ComponentModel;


namespace Buttons
{
    partial class Task3
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
            this.backBtn      = new System.Windows.Forms.Button();
            this.textLbl      = new System.Windows.Forms.Label();
            this.writeBtn     = new System.Windows.Forms.Button();
            this.clearBtn     = new System.Windows.Forms.Button();
            this.disableBtn   = new System.Windows.Forms.Button();
            this.enableBtn    = new System.Windows.Forms.Button();
            this.invisibleBtn = new System.Windows.Forms.Button();
            this.visibleBtn   = new System.Windows.Forms.Button();
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
            // textLbl
            // 
            this.textLbl.Font     = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLbl.Location = new System.Drawing.Point(12, 59);
            this.textLbl.Name     = "textLbl";
            this.textLbl.Size     = new System.Drawing.Size(223, 23);
            this.textLbl.TabIndex = 1;
            this.textLbl.Text     = "Место вывода текста";
            // 
            // writeBtn
            // 
            this.writeBtn.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeBtn.Location                =  new System.Drawing.Point(12, 85);
            this.writeBtn.Name                    =  "writeBtn";
            this.writeBtn.Size                    =  new System.Drawing.Size(223, 23);
            this.writeBtn.TabIndex                =  2;
            this.writeBtn.Text                    =  "Вывести текст на метку";
            this.writeBtn.UseVisualStyleBackColor =  true;
            this.writeBtn.Click                   += new System.EventHandler(this.writeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location                =  new System.Drawing.Point(12, 114);
            this.clearBtn.Name                    =  "clearBtn";
            this.clearBtn.Size                    =  new System.Drawing.Size(223, 23);
            this.clearBtn.TabIndex                =  2;
            this.clearBtn.Text                    =  "Стереть текст из метки";
            this.clearBtn.UseVisualStyleBackColor =  true;
            this.clearBtn.Click                   += new System.EventHandler(this.clearBtn_Click);
            // 
            // disableBtn
            // 
            this.disableBtn.Location                =  new System.Drawing.Point(12, 143);
            this.disableBtn.Name                    =  "disableBtn";
            this.disableBtn.Size                    =  new System.Drawing.Size(223, 23);
            this.disableBtn.TabIndex                =  2;
            this.disableBtn.Text                    =  "Сделать кнопку недоступной";
            this.disableBtn.UseVisualStyleBackColor =  true;
            this.disableBtn.Click                   += new System.EventHandler(this.disableBtn_Click);
            // 
            // enableBtn
            // 
            this.enableBtn.Location                =  new System.Drawing.Point(12, 172);
            this.enableBtn.Name                    =  "enableBtn";
            this.enableBtn.Size                    =  new System.Drawing.Size(223, 23);
            this.enableBtn.TabIndex                =  2;
            this.enableBtn.Text                    =  "Сделать кнопку доступной";
            this.enableBtn.UseVisualStyleBackColor =  true;
            this.enableBtn.Click                   += new System.EventHandler(this.enableBtn_Click);
            // 
            // invisibleBtn
            // 
            this.invisibleBtn.Location                =  new System.Drawing.Point(12, 201);
            this.invisibleBtn.Name                    =  "invisibleBtn";
            this.invisibleBtn.Size                    =  new System.Drawing.Size(223, 23);
            this.invisibleBtn.TabIndex                =  2;
            this.invisibleBtn.Text                    =  "Сделать кноку невидимой";
            this.invisibleBtn.UseVisualStyleBackColor =  true;
            this.invisibleBtn.Click                   += new System.EventHandler(this.invisibleBtn_Click);
            // 
            // visibleBtn
            // 
            this.visibleBtn.Location                =  new System.Drawing.Point(12, 230);
            this.visibleBtn.Name                    =  "visibleBtn";
            this.visibleBtn.Size                    =  new System.Drawing.Size(223, 23);
            this.visibleBtn.TabIndex                =  2;
            this.visibleBtn.Text                    =  "Сделать кнопку видимой";
            this.visibleBtn.UseVisualStyleBackColor =  true;
            this.visibleBtn.Click                   += new System.EventHandler(this.visibleBtn_Click);
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(250, 263);
            this.Controls.Add(this.visibleBtn);
            this.Controls.Add(this.invisibleBtn);
            this.Controls.Add(this.enableBtn);
            this.Controls.Add(this.disableBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.writeBtn);
            this.Controls.Add(this.textLbl);
            this.Controls.Add(this.backBtn);
            this.Name = "Task3";
            this.Text = "Task3";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button writeBtn;

        private System.Windows.Forms.Button enableBtn;
        private System.Windows.Forms.Button invisibleBtn;
        private System.Windows.Forms.Button visibleBtn;

        private System.Windows.Forms.Label  textLbl;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button disableBtn;

        private System.Windows.Forms.Button backBtn;

        #endregion
    }
}