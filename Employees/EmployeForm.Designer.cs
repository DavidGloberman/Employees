namespace Employees
{
    partial class EmployeForm
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
            button_next = new Button();
            textBox_lName = new TextBox();
            label_dob = new Label();
            label_lName = new Label();
            label_fName = new Label();
            label_tz = new Label();
            label_id = new Label();
            textBox_fName = new TextBox();
            textBox_tz = new TextBox();
            textBox_id = new TextBox();
            button_previous = new Button();
            textBox_num = new TextBox();
            textBox_mobilePhone = new TextBox();
            label_city = new Label();
            label_num = new Label();
            label_street = new Label();
            label_homePhone = new Label();
            label_mobilePhone = new Label();
            textBox_street = new TextBox();
            textBox_homePhone = new TextBox();
            textBox_city = new TextBox();
            button_new = new Button();
            button_addEmployee = new Button();
            button_updating = new Button();
            button_deletion = new Button();
            button_searchById = new Button();
            button_searchByTZ = new Button();
            radioButton_male = new RadioButton();
            radioButton_female = new RadioButton();
            groupBox_gender = new GroupBox();
            dateTimePicker_dob = new DateTimePicker();
            pictureBox1 = new PictureBox();
            groupBox_status = new GroupBox();
            radioButton_divorcee = new RadioButton();
            radioButton_widower = new RadioButton();
            radioButton_bachelor = new RadioButton();
            radioButton_married = new RadioButton();
            groupBox_gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox_status.SuspendLayout();
            SuspendLayout();
            // 
            // button_next
            // 
            button_next.Location = new Point(82, 278);
            button_next.Name = "button_next";
            button_next.Size = new Size(90, 29);
            button_next.TabIndex = 0;
            button_next.Text = "<<";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // textBox_lName
            // 
            textBox_lName.Location = new Point(416, 49);
            textBox_lName.Name = "textBox_lName";
            textBox_lName.ReadOnly = true;
            textBox_lName.Size = new Size(125, 27);
            textBox_lName.TabIndex = 1;
            // 
            // label_dob
            // 
            label_dob.AutoSize = true;
            label_dob.Location = new Point(586, 26);
            label_dob.Name = "label_dob";
            label_dob.Size = new Size(83, 20);
            label_dob.TabIndex = 3;
            label_dob.Text = "תאריך לידה";
            // 
            // label_lName
            // 
            label_lName.AutoSize = true;
            label_lName.Location = new Point(435, 26);
            label_lName.Name = "label_lName";
            label_lName.Size = new Size(86, 20);
            label_lName.TabIndex = 4;
            label_lName.Text = "שם משפחה";
            // 
            // label_fName
            // 
            label_fName.AutoSize = true;
            label_fName.Location = new Point(316, 26);
            label_fName.Name = "label_fName";
            label_fName.Size = new Size(66, 20);
            label_fName.TabIndex = 5;
            label_fName.Text = "שם פרטי";
            // 
            // label_tz
            // 
            label_tz.AutoSize = true;
            label_tz.Location = new Point(173, 26);
            label_tz.Name = "label_tz";
            label_tz.Size = new Size(85, 20);
            label_tz.TabIndex = 6;
            label_tz.Text = "תעודת זהות";
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(95, 26);
            label_id.Name = "label_id";
            label_id.Size = new Size(30, 20);
            label_id.TabIndex = 7;
            label_id.Text = "קוד";
            // 
            // textBox_fName
            // 
            textBox_fName.Location = new Point(285, 49);
            textBox_fName.Name = "textBox_fName";
            textBox_fName.ReadOnly = true;
            textBox_fName.Size = new Size(125, 27);
            textBox_fName.TabIndex = 8;
            // 
            // textBox_tz
            // 
            textBox_tz.Location = new Point(154, 49);
            textBox_tz.Name = "textBox_tz";
            textBox_tz.ReadOnly = true;
            textBox_tz.Size = new Size(125, 27);
            textBox_tz.TabIndex = 9;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(77, 49);
            textBox_id.Name = "textBox_id";
            textBox_id.ReadOnly = true;
            textBox_id.Size = new Size(71, 27);
            textBox_id.TabIndex = 10;
            // 
            // button_previous
            // 
            button_previous.Location = new Point(205, 278);
            button_previous.Name = "button_previous";
            button_previous.Size = new Size(90, 29);
            button_previous.TabIndex = 11;
            button_previous.Text = ">>";
            button_previous.UseVisualStyleBackColor = true;
            // 
            // textBox_num
            // 
            textBox_num.Location = new Point(455, 336);
            textBox_num.Name = "textBox_num";
            textBox_num.ReadOnly = true;
            textBox_num.Size = new Size(125, 27);
            textBox_num.TabIndex = 12;
            // 
            // textBox_mobilePhone
            // 
            textBox_mobilePhone.Location = new Point(62, 336);
            textBox_mobilePhone.Name = "textBox_mobilePhone";
            textBox_mobilePhone.ReadOnly = true;
            textBox_mobilePhone.Size = new Size(125, 27);
            textBox_mobilePhone.TabIndex = 21;
            // 
            // label_city
            // 
            label_city.AutoSize = true;
            label_city.Location = new Point(631, 313);
            label_city.Name = "label_city";
            label_city.Size = new Size(30, 20);
            label_city.TabIndex = 14;
            label_city.Text = "עיר";
            // 
            // label_num
            // 
            label_num.AutoSize = true;
            label_num.Location = new Point(499, 313);
            label_num.Name = "label_num";
            label_num.Size = new Size(46, 20);
            label_num.TabIndex = 15;
            label_num.Text = "מספר";
            // 
            // label_street
            // 
            label_street.AutoSize = true;
            label_street.Location = new Point(366, 313);
            label_street.Name = "label_street";
            label_street.Size = new Size(40, 20);
            label_street.TabIndex = 16;
            label_street.Text = "רחוב";
            // 
            // label_homePhone
            // 
            label_homePhone.AutoSize = true;
            label_homePhone.Location = new Point(223, 313);
            label_homePhone.Name = "label_homePhone";
            label_homePhone.Size = new Size(81, 20);
            label_homePhone.TabIndex = 17;
            label_homePhone.Text = "טלפון בבית";
            // 
            // label_mobilePhone
            // 
            label_mobilePhone.AutoSize = true;
            label_mobilePhone.Location = new Point(98, 313);
            label_mobilePhone.Name = "label_mobilePhone";
            label_mobilePhone.Size = new Size(69, 20);
            label_mobilePhone.TabIndex = 18;
            label_mobilePhone.Text = "טלפון נייד";
            // 
            // textBox_street
            // 
            textBox_street.Location = new Point(324, 336);
            textBox_street.Name = "textBox_street";
            textBox_street.ReadOnly = true;
            textBox_street.Size = new Size(125, 27);
            textBox_street.TabIndex = 19;
            // 
            // textBox_homePhone
            // 
            textBox_homePhone.Location = new Point(193, 336);
            textBox_homePhone.Name = "textBox_homePhone";
            textBox_homePhone.ReadOnly = true;
            textBox_homePhone.Size = new Size(125, 27);
            textBox_homePhone.TabIndex = 20;
            // 
            // textBox_city
            // 
            textBox_city.Location = new Point(586, 336);
            textBox_city.Name = "textBox_city";
            textBox_city.ReadOnly = true;
            textBox_city.Size = new Size(125, 27);
            textBox_city.TabIndex = 22;
            // 
            // button_new
            // 
            button_new.Location = new Point(62, 388);
            button_new.Name = "button_new";
            button_new.Size = new Size(140, 30);
            button_new.TabIndex = 24;
            button_new.Text = "חדש";
            button_new.UseVisualStyleBackColor = true;
            button_new.Click += button_new_Click;
            // 
            // button_addEmployee
            // 
            button_addEmployee.Location = new Point(233, 388);
            button_addEmployee.Name = "button_addEmployee";
            button_addEmployee.Size = new Size(140, 30);
            button_addEmployee.TabIndex = 23;
            button_addEmployee.Text = "הוספת עובד";
            button_addEmployee.UseVisualStyleBackColor = true;
            // 
            // button_updating
            // 
            button_updating.Location = new Point(406, 388);
            button_updating.Name = "button_updating";
            button_updating.Size = new Size(140, 30);
            button_updating.TabIndex = 26;
            button_updating.Text = "עדכון";
            button_updating.UseVisualStyleBackColor = true;
            // 
            // button_deletion
            // 
            button_deletion.Location = new Point(571, 388);
            button_deletion.Name = "button_deletion";
            button_deletion.Size = new Size(140, 30);
            button_deletion.TabIndex = 25;
            button_deletion.Text = "מחיקת עובד";
            button_deletion.UseVisualStyleBackColor = true;
            // 
            // button_searchById
            // 
            button_searchById.Location = new Point(37, 454);
            button_searchById.Name = "button_searchById";
            button_searchById.Size = new Size(162, 29);
            button_searchById.TabIndex = 28;
            button_searchById.Text = "חיפוש עובד לפי קוד";
            button_searchById.UseVisualStyleBackColor = true;
            // 
            // button_searchByTZ
            // 
            button_searchByTZ.Location = new Point(221, 454);
            button_searchByTZ.Name = "button_searchByTZ";
            button_searchByTZ.Size = new Size(204, 29);
            button_searchByTZ.TabIndex = 27;
            button_searchByTZ.Text = "חיפוש עובד לפי תעודת זהות";
            button_searchByTZ.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Location = new Point(30, 32);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(51, 24);
            radioButton_male.TabIndex = 29;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "זכר";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Location = new Point(16, 62);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(65, 24);
            radioButton_female.TabIndex = 30;
            radioButton_female.TabStop = true;
            radioButton_female.Text = "נקבה";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // groupBox_gender
            // 
            groupBox_gender.Controls.Add(radioButton_male);
            groupBox_gender.Controls.Add(radioButton_female);
            groupBox_gender.Enabled = false;
            groupBox_gender.ImeMode = ImeMode.NoControl;
            groupBox_gender.Location = new Point(95, 108);
            groupBox_gender.Name = "groupBox_gender";
            groupBox_gender.Size = new Size(111, 107);
            groupBox_gender.TabIndex = 35;
            groupBox_gender.TabStop = false;
            // 
            // dateTimePicker_dob
            // 
            dateTimePicker_dob.Enabled = false;
            dateTimePicker_dob.Location = new Point(549, 49);
            dateTimePicker_dob.Name = "dateTimePicker_dob";
            dateTimePicker_dob.Size = new Size(154, 27);
            dateTimePicker_dob.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(526, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 171);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // groupBox_status
            // 
            groupBox_status.Controls.Add(radioButton_divorcee);
            groupBox_status.Controls.Add(radioButton_widower);
            groupBox_status.Controls.Add(radioButton_bachelor);
            groupBox_status.Controls.Add(radioButton_married);
            groupBox_status.Enabled = false;
            groupBox_status.ImeMode = ImeMode.NoControl;
            groupBox_status.Location = new Point(309, 98);
            groupBox_status.Name = "groupBox_status";
            groupBox_status.Size = new Size(133, 171);
            groupBox_status.TabIndex = 36;
            groupBox_status.TabStop = false;
            // 
            // radioButton_divorcee
            // 
            radioButton_divorcee.AutoSize = true;
            radioButton_divorcee.Location = new Point(40, 92);
            radioButton_divorcee.Name = "radioButton_divorcee";
            radioButton_divorcee.Size = new Size(61, 24);
            radioButton_divorcee.TabIndex = 31;
            radioButton_divorcee.TabStop = true;
            radioButton_divorcee.Text = "גרוש";
            radioButton_divorcee.UseVisualStyleBackColor = true;
            // 
            // radioButton_widower
            // 
            radioButton_widower.AutoSize = true;
            radioButton_widower.Location = new Point(39, 120);
            radioButton_widower.Name = "radioButton_widower";
            radioButton_widower.Size = new Size(62, 24);
            radioButton_widower.TabIndex = 32;
            radioButton_widower.TabStop = true;
            radioButton_widower.Text = "אלמן";
            radioButton_widower.UseVisualStyleBackColor = true;
            // 
            // radioButton_bachelor
            // 
            radioButton_bachelor.AutoSize = true;
            radioButton_bachelor.Location = new Point(45, 32);
            radioButton_bachelor.Name = "radioButton_bachelor";
            radioButton_bachelor.Size = new Size(56, 24);
            radioButton_bachelor.TabIndex = 29;
            radioButton_bachelor.TabStop = true;
            radioButton_bachelor.Text = "רווק";
            radioButton_bachelor.UseVisualStyleBackColor = true;
            // 
            // radioButton_married
            // 
            radioButton_married.AutoSize = true;
            radioButton_married.Location = new Point(45, 62);
            radioButton_married.Name = "radioButton_married";
            radioButton_married.Size = new Size(56, 24);
            radioButton_married.TabIndex = 30;
            radioButton_married.TabStop = true;
            radioButton_married.Text = "נשוי";
            radioButton_married.UseVisualStyleBackColor = true;
            // 
            // EmployeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 508);
            Controls.Add(groupBox_status);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker_dob);
            Controls.Add(groupBox_gender);
            Controls.Add(button_searchById);
            Controls.Add(button_searchByTZ);
            Controls.Add(button_updating);
            Controls.Add(button_deletion);
            Controls.Add(button_new);
            Controls.Add(button_addEmployee);
            Controls.Add(textBox_city);
            Controls.Add(textBox_mobilePhone);
            Controls.Add(textBox_homePhone);
            Controls.Add(textBox_street);
            Controls.Add(label_mobilePhone);
            Controls.Add(label_homePhone);
            Controls.Add(label_street);
            Controls.Add(label_num);
            Controls.Add(label_city);
            Controls.Add(textBox_num);
            Controls.Add(button_previous);
            Controls.Add(textBox_id);
            Controls.Add(textBox_tz);
            Controls.Add(textBox_fName);
            Controls.Add(label_id);
            Controls.Add(label_tz);
            Controls.Add(label_fName);
            Controls.Add(label_lName);
            Controls.Add(label_dob);
            Controls.Add(textBox_lName);
            Controls.Add(button_next);
            Name = "EmployeForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "EmployeForm";
            groupBox_gender.ResumeLayout(false);
            groupBox_gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox_status.ResumeLayout(false);
            groupBox_status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_next;
        private TextBox textBox_lName;
        private Label label_dob;
        private Label label_lName;
        private Label label_fName;
        private Label label_tz;
        private Label label_id;
        private TextBox textBox_fName;
        private TextBox textBox_tz;
        private TextBox textBox_id;
        private Button button_previous;
        private TextBox textBox_num;
        private TextBox textBox_mobilePhone;
        private Label label_city;
        private Label label_num;
        private Label label_street;
        private Label label_homePhone;
        private Label label_mobilePhone;
        private TextBox textBox_street;
        private TextBox textBox_homePhone;
        private TextBox textBox_city;
        private Button button_new;
        private Button button_addEmployee;
        private Button button_updating;
        private Button button_deletion;
        private Button button_searchById;
        private Button button_searchByTZ;
        private RadioButton radioButton_male;
        private RadioButton radioButton_female;
        private GroupBox groupBox_gender;
        private DateTimePicker dateTimePicker_dob;
        private PictureBox pictureBox1;
        private GroupBox groupBox_status;
        private RadioButton radioButton_divorcee;
        private RadioButton radioButton_widower;
        private RadioButton radioButton_bachelor;
        private RadioButton radioButton_married;
    }
}