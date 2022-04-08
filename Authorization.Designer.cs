
namespace graphicKey
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegistrB = new System.Windows.Forms.Button();
            this.signInB = new System.Windows.Forms.Button();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "АВТОРИЗАЦИЯ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 75);
            this.panel1.TabIndex = 1;
            // 
            // RegistrB
            // 
            this.RegistrB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.RegistrB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrB.Location = new System.Drawing.Point(24, 158);
            this.RegistrB.Name = "RegistrB";
            this.RegistrB.Size = new System.Drawing.Size(348, 38);
            this.RegistrB.TabIndex = 5;
            this.RegistrB.TabStop = false;
            this.RegistrB.Text = "Регистрация";
            this.RegistrB.UseVisualStyleBackColor = false;
            this.RegistrB.Click += new System.EventHandler(this.RegistrB_Click);
            // 
            // signInB
            // 
            this.signInB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.signInB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.signInB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signInB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInB.Location = new System.Drawing.Point(24, 108);
            this.signInB.Name = "signInB";
            this.signInB.Size = new System.Drawing.Size(348, 38);
            this.signInB.TabIndex = 4;
            this.signInB.TabStop = false;
            this.signInB.Text = "Войти";
            this.signInB.UseVisualStyleBackColor = false;
            this.signInB.Click += new System.EventHandler(this.signInB_Click);
            // 
            // LoginTB
            // 
            this.LoginTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTB.ForeColor = System.Drawing.Color.Black;
            this.LoginTB.Location = new System.Drawing.Point(24, 45);
            this.LoginTB.Multiline = true;
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(348, 38);
            this.LoginTB.TabIndex = 2;
            this.LoginTB.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.errorL);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LoginTB);
            this.panel2.Controls.Add(this.RegistrB);
            this.panel2.Controls.Add(this.signInB);
            this.panel2.Location = new System.Drawing.Point(32, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 238);
            this.panel2.TabIndex = 2;
            // 
            // errorL
            // 
            this.errorL.AutoSize = true;
            this.errorL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorL.Location = new System.Drawing.Point(3, 203);
            this.errorL.Name = "errorL";
            this.errorL.Size = new System.Drawing.Size(0, 20);
            this.errorL.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(145)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(465, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RegistrB;
        private System.Windows.Forms.Button signInB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorL;
    }
}

