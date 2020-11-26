namespace Музей
{
    partial class NameAutoriz
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Пароль = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonZar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOK.Location = new System.Drawing.Point(28, 124);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(228, 33);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "Войти";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // Пароль
            // 
            this.Пароль.AutoSize = true;
            this.Пароль.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Пароль.Location = new System.Drawing.Point(25, 64);
            this.Пароль.Name = "Пароль";
            this.Пароль.Size = new System.Drawing.Size(45, 13);
            this.Пароль.TabIndex = 2;
            this.Пароль.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(28, 37);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(228, 20);
            this.textBoxLogin.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(28, 80);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(228, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // buttonZar
            // 
            this.buttonZar.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonZar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonZar.Location = new System.Drawing.Point(28, 162);
            this.buttonZar.Name = "buttonZar";
            this.buttonZar.Size = new System.Drawing.Size(228, 33);
            this.buttonZar.TabIndex = 5;
            this.buttonZar.Text = "Зарегистрироваться";
            this.buttonZar.UseVisualStyleBackColor = false;
            // 
            // NameAutoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.buttonZar);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.Пароль);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "NameAutoriz";
            this.Text = "Авторизация";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.NameAutoriz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Пароль;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonZar;
    }
}

