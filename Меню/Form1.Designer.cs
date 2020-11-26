namespace Меню
{
    partial class FormMenu
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
            this.buttonBillet = new System.Windows.Forms.Button();
            this.buttonExcursions = new System.Windows.Forms.Button();
            this.buttonInform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBillet
            // 
            this.buttonBillet.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonBillet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBillet.Location = new System.Drawing.Point(12, 36);
            this.buttonBillet.Name = "buttonBillet";
            this.buttonBillet.Size = new System.Drawing.Size(260, 38);
            this.buttonBillet.TabIndex = 0;
            this.buttonBillet.Text = "Купить билет";
            this.buttonBillet.UseVisualStyleBackColor = false;
            // 
            // buttonExcursions
            // 
            this.buttonExcursions.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonExcursions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcursions.Location = new System.Drawing.Point(12, 80);
            this.buttonExcursions.Name = "buttonExcursions";
            this.buttonExcursions.Size = new System.Drawing.Size(260, 38);
            this.buttonExcursions.TabIndex = 1;
            this.buttonExcursions.Text = "Экскурсии";
            this.buttonExcursions.UseVisualStyleBackColor = false;
            // 
            // buttonInform
            // 
            this.buttonInform.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonInform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInform.Location = new System.Drawing.Point(12, 124);
            this.buttonInform.Name = "buttonInform";
            this.buttonInform.Size = new System.Drawing.Size(260, 38);
            this.buttonInform.TabIndex = 2;
            this.buttonInform.Text = "Информация";
            this.buttonInform.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 195);
            this.Controls.Add(this.buttonInform);
            this.Controls.Add(this.buttonExcursions);
            this.Controls.Add(this.buttonBillet);
            this.Name = "FormMenu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBillet;
        private System.Windows.Forms.Button buttonExcursions;
        private System.Windows.Forms.Button buttonInform;
    }
}

