namespace MusicPlayer
{
    partial class MainWindow
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
            this.registrationGroup = new System.Windows.Forms.GroupBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_repeat_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_auth_login = new System.Windows.Forms.TextBox();
            this.tb_auth_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_auth = new System.Windows.Forms.Button();
            this.registrationGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationGroup
            // 
            this.registrationGroup.Controls.Add(this.btn_register);
            this.registrationGroup.Controls.Add(this.label5);
            this.registrationGroup.Controls.Add(this.tb_repeat_password);
            this.registrationGroup.Controls.Add(this.label4);
            this.registrationGroup.Controls.Add(this.tb_password);
            this.registrationGroup.Controls.Add(this.label3);
            this.registrationGroup.Controls.Add(this.label2);
            this.registrationGroup.Controls.Add(this.label1);
            this.registrationGroup.Controls.Add(this.tb_lastname);
            this.registrationGroup.Controls.Add(this.tb_name);
            this.registrationGroup.Controls.Add(this.tb_login);
            this.registrationGroup.Location = new System.Drawing.Point(13, 13);
            this.registrationGroup.Name = "registrationGroup";
            this.registrationGroup.Size = new System.Drawing.Size(363, 182);
            this.registrationGroup.TabIndex = 0;
            this.registrationGroup.TabStop = false;
            this.registrationGroup.Text = "Регистрация";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(122, 150);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(233, 23);
            this.btn_register.TabIndex = 10;
            this.btn_register.Text = "Зарегистрироваться";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Повторите пароль:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_repeat_password
            // 
            this.tb_repeat_password.Location = new System.Drawing.Point(122, 123);
            this.tb_repeat_password.Name = "tb_repeat_password";
            this.tb_repeat_password.PasswordChar = '*';
            this.tb_repeat_password.Size = new System.Drawing.Size(233, 20);
            this.tb_repeat_password.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(122, 97);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(233, 20);
            this.tb_password.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин:";
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(122, 71);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(233, 20);
            this.tb_lastname.TabIndex = 2;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(122, 45);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(233, 20);
            this.tb_name.TabIndex = 1;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(122, 19);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(233, 20);
            this.tb_login.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_auth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_auth_password);
            this.groupBox1.Controls.Add(this.tb_auth_login);
            this.groupBox1.Location = new System.Drawing.Point(401, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tb_auth_login
            // 
            this.tb_auth_login.Location = new System.Drawing.Point(110, 60);
            this.tb_auth_login.Name = "tb_auth_login";
            this.tb_auth_login.Size = new System.Drawing.Size(217, 20);
            this.tb_auth_login.TabIndex = 0;
            // 
            // tb_auth_password
            // 
            this.tb_auth_password.Location = new System.Drawing.Point(110, 86);
            this.tb_auth_password.Name = "tb_auth_password";
            this.tb_auth_password.Size = new System.Drawing.Size(217, 20);
            this.tb_auth_password.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Логин:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Пароль:";
            // 
            // btn_auth
            // 
            this.btn_auth.Location = new System.Drawing.Point(119, 150);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(189, 23);
            this.btn_auth.TabIndex = 2;
            this.btn_auth.Text = "Авторизоваться";
            this.btn_auth.UseVisualStyleBackColor = true;
            this.btn_auth.Click += new System.EventHandler(this.btn_auth_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registrationGroup);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.registrationGroup.ResumeLayout(false);
            this.registrationGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registrationGroup;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_repeat_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_auth_password;
        private System.Windows.Forms.TextBox tb_auth_login;
        private System.Windows.Forms.Button btn_auth;
    }
}

