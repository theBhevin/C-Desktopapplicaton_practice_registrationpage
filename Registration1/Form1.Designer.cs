namespace Registration1
{
    partial class Registration
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Fullnamelabel3 = new System.Windows.Forms.Label();
            this.FullNametextBox1 = new System.Windows.Forms.TextBox();
            this.Emaillabel4 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.Genderlabel5 = new System.Windows.Forms.Label();
            this.femaleradioButton = new System.Windows.Forms.RadioButton();
            this.MaleradioButton = new System.Windows.Forms.RadioButton();
            this.OthersradioButton3 = new System.Windows.Forms.RadioButton();
            this.Contactlabel6 = new System.Windows.Forms.Label();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.Userlabel7 = new System.Windows.Forms.Label();
            this.ContactNumbertextBox = new System.Windows.Forms.TextBox();
            this.Passlabel8 = new System.Windows.Forms.Label();
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.AcceptCheckbox = new System.Windows.Forms.CheckBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CancelButten = new System.Windows.Forms.Button();
            this.RegiErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DOBlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegiErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.DOBlabel);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.CancelButten);
            this.panel1.Controls.Add(this.RegisterButton);
            this.panel1.Controls.Add(this.AcceptCheckbox);
            this.panel1.Controls.Add(this.PasstextBox);
            this.panel1.Controls.Add(this.Passlabel8);
            this.panel1.Controls.Add(this.ContactNumbertextBox);
            this.panel1.Controls.Add(this.Userlabel7);
            this.panel1.Controls.Add(this.UserNametextBox);
            this.panel1.Controls.Add(this.Contactlabel6);
            this.panel1.Controls.Add(this.OthersradioButton3);
            this.panel1.Controls.Add(this.MaleradioButton);
            this.panel1.Controls.Add(this.femaleradioButton);
            this.panel1.Controls.Add(this.Genderlabel5);
            this.panel1.Controls.Add(this.EmailtextBox);
            this.panel1.Controls.Add(this.Emaillabel4);
            this.panel1.Controls.Add(this.FullNametextBox1);
            this.panel1.Controls.Add(this.Fullnamelabel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 430);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(297, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registration Form";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fullnamelabel3
            // 
            this.Fullnamelabel3.AutoSize = true;
            this.Fullnamelabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullnamelabel3.ForeColor = System.Drawing.Color.Cyan;
            this.Fullnamelabel3.Location = new System.Drawing.Point(50, 40);
            this.Fullnamelabel3.Name = "Fullnamelabel3";
            this.Fullnamelabel3.Size = new System.Drawing.Size(77, 16);
            this.Fullnamelabel3.TabIndex = 2;
            this.Fullnamelabel3.Text = "Full Name";
            // 
            // FullNametextBox1
            // 
            this.FullNametextBox1.Location = new System.Drawing.Point(146, 39);
            this.FullNametextBox1.Multiline = true;
            this.FullNametextBox1.Name = "FullNametextBox1";
            this.FullNametextBox1.Size = new System.Drawing.Size(482, 28);
            this.FullNametextBox1.TabIndex = 3;
            this.FullNametextBox1.TextChanged += new System.EventHandler(this.FullNametextBox1_TextChanged);
            this.FullNametextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNametextBox1_KeyPress);
            // 
            // Emaillabel4
            // 
            this.Emaillabel4.AutoSize = true;
            this.Emaillabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Emaillabel4.Location = new System.Drawing.Point(50, 87);
            this.Emaillabel4.Name = "Emaillabel4";
            this.Emaillabel4.Size = new System.Drawing.Size(51, 16);
            this.Emaillabel4.TabIndex = 4;
            this.Emaillabel4.Text = "E-Mail";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(146, 87);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(482, 22);
            this.EmailtextBox.TabIndex = 5;
            this.EmailtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailtextBox_KeyPress);
            // 
            // Genderlabel5
            // 
            this.Genderlabel5.AutoSize = true;
            this.Genderlabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlabel5.ForeColor = System.Drawing.Color.Orange;
            this.Genderlabel5.Location = new System.Drawing.Point(50, 130);
            this.Genderlabel5.Name = "Genderlabel5";
            this.Genderlabel5.Size = new System.Drawing.Size(58, 16);
            this.Genderlabel5.TabIndex = 6;
            this.Genderlabel5.Text = "Gender";
            // 
            // femaleradioButton
            // 
            this.femaleradioButton.AutoSize = true;
            this.femaleradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleradioButton.ForeColor = System.Drawing.Color.Crimson;
            this.femaleradioButton.Location = new System.Drawing.Point(146, 126);
            this.femaleradioButton.Name = "femaleradioButton";
            this.femaleradioButton.Size = new System.Drawing.Size(77, 20);
            this.femaleradioButton.TabIndex = 7;
            this.femaleradioButton.Text = "Female";
            this.femaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            this.MaleradioButton.AutoSize = true;
            this.MaleradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleradioButton.ForeColor = System.Drawing.Color.Crimson;
            this.MaleradioButton.Location = new System.Drawing.Point(267, 126);
            this.MaleradioButton.Name = "MaleradioButton";
            this.MaleradioButton.Size = new System.Drawing.Size(59, 20);
            this.MaleradioButton.TabIndex = 8;
            this.MaleradioButton.Text = "Male";
            this.MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // OthersradioButton3
            // 
            this.OthersradioButton3.AutoSize = true;
            this.OthersradioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersradioButton3.ForeColor = System.Drawing.Color.Crimson;
            this.OthersradioButton3.Location = new System.Drawing.Point(344, 128);
            this.OthersradioButton3.Name = "OthersradioButton3";
            this.OthersradioButton3.Size = new System.Drawing.Size(70, 20);
            this.OthersradioButton3.TabIndex = 9;
            this.OthersradioButton3.Text = "Others";
            this.OthersradioButton3.UseVisualStyleBackColor = true;
            // 
            // Contactlabel6
            // 
            this.Contactlabel6.AutoSize = true;
            this.Contactlabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contactlabel6.ForeColor = System.Drawing.Color.Lime;
            this.Contactlabel6.Location = new System.Drawing.Point(10, 201);
            this.Contactlabel6.Name = "Contactlabel6";
            this.Contactlabel6.Size = new System.Drawing.Size(117, 16);
            this.Contactlabel6.TabIndex = 10;
            this.Contactlabel6.Text = "Contact Number";
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(146, 232);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(482, 22);
            this.UserNametextBox.TabIndex = 11;
            this.UserNametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserNametextBox_KeyPress);
            // 
            // Userlabel7
            // 
            this.Userlabel7.AutoSize = true;
            this.Userlabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlabel7.ForeColor = System.Drawing.Color.OrangeRed;
            this.Userlabel7.Location = new System.Drawing.Point(42, 232);
            this.Userlabel7.Name = "Userlabel7";
            this.Userlabel7.Size = new System.Drawing.Size(85, 16);
            this.Userlabel7.TabIndex = 12;
            this.Userlabel7.Text = "User Name";
            // 
            // ContactNumbertextBox
            // 
            this.ContactNumbertextBox.Location = new System.Drawing.Point(146, 197);
            this.ContactNumbertextBox.Name = "ContactNumbertextBox";
            this.ContactNumbertextBox.Size = new System.Drawing.Size(482, 22);
            this.ContactNumbertextBox.TabIndex = 13;
            this.ContactNumbertextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactNumbertextBox_KeyPress);
            // 
            // Passlabel8
            // 
            this.Passlabel8.AutoSize = true;
            this.Passlabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlabel8.ForeColor = System.Drawing.Color.OrangeRed;
            this.Passlabel8.Location = new System.Drawing.Point(42, 276);
            this.Passlabel8.Name = "Passlabel8";
            this.Passlabel8.Size = new System.Drawing.Size(79, 16);
            this.Passlabel8.TabIndex = 14;
            this.Passlabel8.Text = "PassWord";
            // 
            // PasstextBox
            // 
            this.PasstextBox.Location = new System.Drawing.Point(146, 276);
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.Size = new System.Drawing.Size(482, 22);
            this.PasstextBox.TabIndex = 15;
            this.PasstextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasstextBox_KeyPress);
            // 
            // AcceptCheckbox
            // 
            this.AcceptCheckbox.AutoSize = true;
            this.AcceptCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptCheckbox.ForeColor = System.Drawing.Color.Red;
            this.AcceptCheckbox.Location = new System.Drawing.Point(267, 317);
            this.AcceptCheckbox.Name = "AcceptCheckbox";
            this.AcceptCheckbox.Size = new System.Drawing.Size(229, 20);
            this.AcceptCheckbox.TabIndex = 16;
            this.AcceptCheckbox.Text = "Accept Terms and Conditions";
            this.AcceptCheckbox.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.Blue;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.Azure;
            this.RegisterButton.Location = new System.Drawing.Point(399, 352);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(116, 48);
            this.RegisterButton.TabIndex = 17;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.Registration_Load);
            this.RegisterButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RegisterButton_MouseClick);
            // 
            // CancelButten
            // 
            this.CancelButten.BackColor = System.Drawing.Color.Red;
            this.CancelButten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButten.ForeColor = System.Drawing.Color.White;
            this.CancelButten.Location = new System.Drawing.Point(560, 352);
            this.CancelButten.Name = "CancelButten";
            this.CancelButten.Size = new System.Drawing.Size(116, 48);
            this.CancelButten.TabIndex = 18;
            this.CancelButten.Text = "Cancel";
            this.CancelButten.UseVisualStyleBackColor = false;
            // 
            // RegiErrorProvider
            // 
            this.RegiErrorProvider.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // DOBlabel
            // 
            this.DOBlabel.AutoSize = true;
            this.DOBlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.DOBlabel.Location = new System.Drawing.Point(42, 166);
            this.DOBlabel.Name = "DOBlabel";
            this.DOBlabel.Size = new System.Drawing.Size(94, 16);
            this.DOBlabel.TabIndex = 20;
            this.DOBlabel.Text = "Date Of Birth";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegiErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Fullnamelabel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Genderlabel5;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label Emaillabel4;
        private System.Windows.Forms.TextBox FullNametextBox1;
        private System.Windows.Forms.RadioButton OthersradioButton3;
        private System.Windows.Forms.RadioButton MaleradioButton;
        private System.Windows.Forms.RadioButton femaleradioButton;
        private System.Windows.Forms.Label Userlabel7;
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.Label Contactlabel6;
        private System.Windows.Forms.Label Passlabel8;
        private System.Windows.Forms.TextBox ContactNumbertextBox;
        private System.Windows.Forms.TextBox PasstextBox;
        private System.Windows.Forms.CheckBox AcceptCheckbox;
        private System.Windows.Forms.Button CancelButten;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.ErrorProvider RegiErrorProvider;
        private System.Windows.Forms.Label DOBlabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

