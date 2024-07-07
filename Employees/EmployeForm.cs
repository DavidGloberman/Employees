using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employees.Model;
using Employees.Service;
using static Employees.EmployeForm;

namespace Employees
{
    public partial class EmployeForm : Form
    {
        //public class EmployeeModel;
        private IEmployeService _employeeService;
        private int _activeIndex = 0;
        public EmployeForm()
        {
            InitializeComponent();

            _employeeService = new EmployeeService();

            UpdateFormFields(_employeeService.GetAll()[_activeIndex]);
        }
        private void UpdateFormFields(EmployeeModel dudu)
        {
            textBox_id.Text = dudu.Id.ToString();
            textBox_tz.Text = dudu.TZ.ToString();
            textBox_fName.Text = dudu.FirstName;
            textBox_lName.Text = dudu.LastName;
            dateTimePicker_dob.Value = dudu.Dob;
            textBox_mobilePhone.Text = "0" + dudu.MobilePhone.ToString();
            textBox_homePhone.Text = "0" + dudu.HomePhone.ToString();
            textBox_street.Text = dudu.Address.Street;
            textBox_city.Text = dudu.Address.City;
            textBox_num.Text = dudu.Address.Num.ToString();

            if (dudu.Gender == Gender.MALE)
            {
                radioButton_male.Checked = true;
            }
            else if (dudu.Gender == Gender.FEMALE)
            {
                radioButton_female.Checked = true;
            }

            switch (dudu.Status)
            {
                case Status.BACHELOR:
                    radioButton_bachelor.Checked = true;
                    break;
                case Status.MARRIED:
                    radioButton_married.Checked = true;
                    break;
                case Status.DIVORCEE:
                    radioButton_divorcee.Checked = true;
                    break;
                case Status.WIDOWER:
                    radioButton_widower.Checked = true;
                    break;
            }
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            //textBox_id.Text = "";
            //textBox_tz.Text = "";
            //textBox_fName.Text = "";
            //textBox_lName.Text = "";
            //dateTimePicker_dob.Value = dudu.Dob;
            //textBox_mobilePhone.Text = "";
            //textBox_homePhone.Text = "";
            //textBox_street.Text = "";
            //textBox_city.Text = "";
            //textBox_num.Text = "";
            //radioButton_male.Checked = false;
            //radioButton_female.Checked = false;
            //radioButton_bachelor.Checked = true;


            //textBox_id.Enabled = false;
            //radioButton_male.Enabled = false;
            //radioButton_female.Enabled = false;
            //radioButton_bachelor.Enabled = false;
            //textBox_tz.Enabled = false;
            //textBox_fName.Enabled = false;
            //textBox_lName.Enabled = false;
            //textBox_mobilePhone.Enabled = false;
            //textBox_homePhone.Enabled = false;
            //textBox_street.Enabled = false;
            //textBox_city.Enabled = false;
            //textBox_num.Enabled = false;


            /*
            dateTimePicker_dob.Value = dudu.Dob;
            */
        }

        private void button_next_Click(object sender, EventArgs e)
        {

        }
    }
}
