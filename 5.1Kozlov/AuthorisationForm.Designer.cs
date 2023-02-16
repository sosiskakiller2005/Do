namespace _5._1Kozlov
{
    partial class AuthorisationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logTb = new System.Windows.Forms.TextBox();
            this.passTb = new System.Windows.Forms.TextBox();
            this.logBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль :";
            // 
            // logTb
            // 
            this.logTb.Location = new System.Drawing.Point(159, 18);
            this.logTb.Margin = new System.Windows.Forms.Padding(4);
            this.logTb.Name = "logTb";
            this.logTb.Size = new System.Drawing.Size(132, 30);
            this.logTb.TabIndex = 2;
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(159, 60);
            this.passTb.Margin = new System.Windows.Forms.Padding(4);
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '*';
            this.passTb.Size = new System.Drawing.Size(132, 30);
            this.passTb.TabIndex = 3;
            // 
            // logBtn
            // 
            this.logBtn.Location = new System.Drawing.Point(170, 113);
            this.logBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(110, 44);
            this.logBtn.TabIndex = 4;
            this.logBtn.Text = "Войти";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(13, 291);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(102, 44);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // AuthorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 348);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.logTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AuthorisationForm";
            this.Text = "Окно авторизации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logTb;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}