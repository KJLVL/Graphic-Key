
namespace graphicKey
{
    partial class grKey
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitB = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.smsL = new System.Windows.Forms.Label();
            this.grKPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.headerL);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 83);
            this.panel1.TabIndex = 2;
            // 
            // headerL
            // 
            this.headerL.AutoSize = true;
            this.headerL.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerL.Location = new System.Drawing.Point(6, 14);
            this.headerL.Name = "headerL";
            this.headerL.Size = new System.Drawing.Size(327, 27);
            this.headerL.TabIndex = 0;
            this.headerL.Text = "                                             ";
            this.headerL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 5;
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.exitB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitB.Location = new System.Drawing.Point(252, 3);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(82, 37);
            this.exitB.TabIndex = 5;
            this.exitB.TabStop = false;
            this.exitB.Text = "Выход";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.panel7.Controls.Add(this.smsL);
            this.panel7.Controls.Add(this.exitB);
            this.panel7.Location = new System.Drawing.Point(12, 399);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(338, 43);
            this.panel7.TabIndex = 3;
            // 
            // smsL
            // 
            this.smsL.AutoSize = true;
            this.smsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smsL.Location = new System.Drawing.Point(4, 10);
            this.smsL.Name = "smsL";
            this.smsL.Size = new System.Drawing.Size(0, 25);
            this.smsL.TabIndex = 6;
            // 
            // grKPanel
            // 
            this.grKPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.grKPanel.Location = new System.Drawing.Point(12, 109);
            this.grKPanel.Name = "grKPanel";
            this.grKPanel.Size = new System.Drawing.Size(339, 276);
            this.grKPanel.TabIndex = 6;
            this.grKPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grKPanel_MouseDown);
            this.grKPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grKPanel_MouseMove);
            this.grKPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grKPanel_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.panel2.Location = new System.Drawing.Point(11, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 276);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // grKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(145)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(363, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grKPanel);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "grKey";
            this.Text = "AccConfirmation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel grKPanel;
        private System.Windows.Forms.Label smsL;
        private System.Windows.Forms.Panel panel2;
    }
}