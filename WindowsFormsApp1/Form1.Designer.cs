namespace WindowsFormsApp1
{
    partial class Form1
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
            this.textBox_nameIN = new System.Windows.Forms.TextBox();
            this.button_add_name = new System.Windows.Forms.Button();
            this.textBox_nameOUT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя:";
            // 
            // textBox_nameIN
            // 
            this.textBox_nameIN.Location = new System.Drawing.Point(12, 28);
            this.textBox_nameIN.Name = "textBox_nameIN";
            this.textBox_nameIN.Size = new System.Drawing.Size(100, 20);
            this.textBox_nameIN.TabIndex = 1;
            // 
            // button_add_name
            // 
            this.button_add_name.Location = new System.Drawing.Point(136, 25);
            this.button_add_name.Name = "button_add_name";
            this.button_add_name.Size = new System.Drawing.Size(86, 23);
            this.button_add_name.TabIndex = 2;
            this.button_add_name.Text = "Добавить";
            this.button_add_name.UseVisualStyleBackColor = true;
            this.button_add_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_add_name_MouseClick);
            // 
            // textBox_nameOUT
            // 
            this.textBox_nameOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_nameOUT.Location = new System.Drawing.Point(12, 77);
            this.textBox_nameOUT.Multiline = true;
            this.textBox_nameOUT.Name = "textBox_nameOUT";
            this.textBox_nameOUT.Size = new System.Drawing.Size(100, 129);
            this.textBox_nameOUT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список имен:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 129);
            this.button1.TabIndex = 5;
            this.button1.Text = "Создать пароли";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 231);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nameOUT);
            this.Controls.Add(this.button_add_name);
            this.Controls.Add(this.textBox_nameIN);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор паролей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nameIN;
        private System.Windows.Forms.Button button_add_name;
        private System.Windows.Forms.TextBox textBox_nameOUT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

