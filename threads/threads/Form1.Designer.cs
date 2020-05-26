namespace threads
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
            this.components = new System.ComponentModel.Container();
            this.labeldot = new System.Windows.Forms.Label();
            this.labelsec = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelhour = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labeldots = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeldot
            // 
            this.labeldot.AutoSize = true;
            this.labeldot.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldot.Location = new System.Drawing.Point(590, 174);
            this.labeldot.Name = "labeldot";
            this.labeldot.Size = new System.Drawing.Size(65, 116);
            this.labeldot.TabIndex = 0;
            this.labeldot.Text = ":";
            this.labeldot.Click += new System.EventHandler(this.Label7_Click);
            // 
            // labelsec
            // 
            this.labelsec.AutoSize = true;
            this.labelsec.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsec.Location = new System.Drawing.Point(685, 174);
            this.labelsec.Name = "labelsec";
            this.labelsec.Size = new System.Drawing.Size(134, 116);
            this.labelsec.TabIndex = 1;
            this.labelsec.Text = "00";
            this.labelsec.Click += new System.EventHandler(this.Labelsec_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(414, 174);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(134, 116);
            this.labelMin.TabIndex = 2;
            this.labelMin.Text = "00";
            this.labelMin.Click += new System.EventHandler(this.Label9_Click);
            // 
            // labelhour
            // 
            this.labelhour.AutoSize = true;
            this.labelhour.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhour.Location = new System.Drawing.Point(121, 174);
            this.labelhour.Name = "labelhour";
            this.labelhour.Size = new System.Drawing.Size(134, 116);
            this.labelhour.TabIndex = 3;
            this.labelhour.Text = "00";
            this.labelhour.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(301, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(354, 116);
            this.label11.TabIndex = 4;
            this.label11.Text = "Время";
            // 
            // labeldots
            // 
            this.labeldots.AutoSize = true;
            this.labeldots.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldots.Location = new System.Drawing.Point(301, 174);
            this.labeldots.Name = "labeldots";
            this.labeldots.Size = new System.Drawing.Size(65, 116);
            this.labeldots.TabIndex = 5;
            this.labeldots.Text = ":";
            this.labeldots.Click += new System.EventHandler(this.Labeldots_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(62, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(868, 137);
            this.button2.TabIndex = 6;
            this.button2.Text = "Запустить время";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(990, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labeldots);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelhour);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelsec);
            this.Controls.Add(this.labeldot);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labeldot;
        private System.Windows.Forms.Label labelsec;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelhour;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labeldots;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}

