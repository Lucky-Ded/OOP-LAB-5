namespace Lab5WinForm
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
            this.galeryCircle1 = new Lab5WinForm.GaleryCircle();
            this.galery1 = new Lab5WinForm.Galery();
            this.SuspendLayout();
            // 
            // galeryCircle1
            // 
            this.galeryCircle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galeryCircle1.ForeColor = System.Drawing.Color.White;
            this.galeryCircle1.Location = new System.Drawing.Point(64, 31);
            this.galeryCircle1.Name = "galeryCircle1";
            this.galeryCircle1.Size = new System.Drawing.Size(700, 400);
            this.galeryCircle1.TabIndex = 1;
            this.galeryCircle1.Text = "galeryCircle1";
            //this.galeryCircle1.UseVisualStyleBackColor = true;
            // 
            // galery1
            // 
            this.galery1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galery1.ForeColor = System.Drawing.Color.White;
            this.galery1.Location = new System.Drawing.Point(64, 461);
            this.galery1.Name = "galery1";
            this.galery1.Size = new System.Drawing.Size(700, 400);
            this.galery1.TabIndex = 0;
            this.galery1.Text = "galery1";
           // this.galery1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 920);
            this.Controls.Add(this.galeryCircle1);
            this.Controls.Add(this.galery1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Galery galery1;
        private GaleryCircle galeryCircle1;
    }
}

