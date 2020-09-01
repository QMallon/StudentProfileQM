using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/*
 * Form for student profile program
 * Quinn Mallon
 * CIS3374
 * 8/31/2020
 */
namespace StudentProfileQM
{
    public partial class frmStudentProfile : Form
    {
        //list of student profiles storing completed profiles
        List<Student_Profile> students = new List<Student_Profile>();
        public frmStudentProfile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //closes program doesent save
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //saves student to array list of student profiles
        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int tuid = Convert.ToInt32(txtTUID.Text);
                string Name = txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text;
                //finds age accounting for hainvg a birthday passed or not this year
                int age = DateTime.Now.Year - dtpDateOfBirth.Value.Year - (DateTime.Now.DayOfYear < dtpDateOfBirth.Value.DayOfYear ? 1 : 0);
                string phoneNum = txtPhonenumber.Text;
                DateTime graduationDate = dtpExpectedGrad.Value;
                string email = txtEmail.Text;
                string major = txtMajor.Text;
                bool isUnderGrad = true;
                 
                if(rbNo.Checked)
                {
                    isUnderGrad = false;
                }
                if(rbNo.Checked == rbYes.Checked)
                {
                    throw new System.ArgumentException("Must select graduate or undergraduate");
                }
                

                if (txtTUID.TextLength != 9)
                {
                    lblerror.Visible = true;
                }
                else
                {
                    Student_Profile newStudent = new Student_Profile(Name, age, phoneNum, graduationDate, tuid, email, major, isUnderGrad);
                    students.Add(newStudent);
                    reset();
                }
                
            }
            catch
            {
                lblerror.Visible = true;
                lblselectionError.Visible = true;
            }
        }
        //resets form to default values
        private void reset()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtEmail.Text = "";
            txtMajor.Text = "";
            txtPhonenumber.Text = "";
            txtTUID.Text = "";

            dtpDateOfBirth.Value = DateTime.Today;



            dtpExpectedGrad.Value = DateTime.Today;
            rbNo.Checked = false;
            rbYes.Checked = false;
            lblerror.Visible = false;
            lblselectionError.Visible = false;
        }
        //uses streamwriter to write the current profiles from the array list to a file called student profiles on the desktop
        private void btnSaveToText_Click(object sender, EventArgs e)
        {
            //sets path to dekstop
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "StudentProfiles.txt")))
            {
                //each student in list gets printed with a blank line
                foreach (Student_Profile x in students)
                {
                    outputFile.WriteLine(x.ToString() + "\r\n");
                }
            
                
            }
        }
    }
}
