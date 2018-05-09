using System;

using System.Windows.Forms;
using System.IO;

namespace FinalProjectEmployeeApp
{
    public partial class frmFinalProject : Form
    {
        /// <summary>
        /// Name: Gregory Pugh 
        /// Assignment: Final Project
        /// Date: 5/9/2018
        /// Instructor: Mrs Renee Riley
        /// </summary>
        static string fileName;
        
        public frmFinalProject()
        {
            InitializeComponent();
        }

        private void frmFinalProject_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Welcome to the Employee App"; //Welcome Message
        }
        /// <summary>
        /// Adds an Employee to the list, Validates the data by not letting you add anything untill all fields have data in them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double sal;
            bool isValid = true;
            lblStatus.Text = "";
            if (txtBxLastName.Text == "")
            {
                lblStatus.Text += "Last Name cannot be blank ";
                isValid = false;
            }
            if (txtBxFirstName.Text == "")
            {
                lblStatus.Text += "First Name cannot be blank ";
                isValid = false;
            }
            if (txtBxEmpType.Text == "")
            {
                lblStatus.Text += "Employee Type cannot be blank ";
                isValid = false;
            }
            if(txtBxSalary.Text == "")
            {
                lblStatus.Text += "Salary cannot be blank ";
            }
            if (double.TryParse(txtBxSalary.Text, out sal) == false)
            {

                lblStatus.Text += "Salary cannot be anything but a number";
                isValid = false;

            }
            if (isValid)
            {
                EmployeeClass aEmployee = new EmployeeClass(txtBxLastName.Text, txtBxFirstName.Text, txtBxEmpType.Text, Convert.ToDouble(txtBxSalary.Text));
                lstBxEmpolyee.Items.Add(aEmployee);
                lblStatus.Text = "Item Added to list";
                txtBxSalary.Clear();
                txtBxEmpType.Clear();
                txtBxFirstName.Clear();
                txtBxLastName.Clear();

            }
        }
        /// <summary>
        /// Validates Data by not letting someone delete something untill all fields are filled
        /// If all fields are filled out and match an item in the lstbox all instances of the file are deleted.
        /// If any of the fields do not match an item in the lstbox an error is displayed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            double sal;
            bool isValid = true;
            lblStatus.Text = "";
            if (txtBxLastName.Text == "")
            {
                lblStatus.Text += "Last Name cannot be blank";
                isValid = false;
            }
            if (txtBxFirstName.Text == "")
            {
                lblStatus.Text += "First Name cannot be blank";
                isValid = false;
            }
            if (txtBxEmpType.Text == "")
            {
                lblStatus.Text += "Employee Type cannot be blank";
                isValid = false;
            }
            if (txtBxSalary.Text == "")
            {
                lblStatus.Text += "Salary cannot be blank";
            }
            if (double.TryParse(txtBxSalary.Text, out sal) == false)
            {

                lblStatus.Text += "Salary cannot be anything but a number";
                isValid = false;

            }
            if (isValid)
            {
                lstBxEmpolyee.SelectedItems.Clear();
                for (int i = lstBxEmpolyee.Items.Count - 1; i >= 0; i--)
                {
                    if (lstBxEmpolyee.Items[i].ToString().ToLower().Contains(txtBxFirstName.Text.ToLower()))
                        if (lstBxEmpolyee.Items[i].ToString().ToLower().Contains(txtBxLastName.Text.ToLower()))
                            if (lstBxEmpolyee.Items[i].ToString().ToLower().Contains(txtBxEmpType.Text.ToLower()))
                                if ((lstBxEmpolyee.Items[i].ToString().ToLower().Contains(txtBxSalary.Text.ToLower())))
                                {
                                    lstBxEmpolyee.Items.RemoveAt(i);
                                    lblStatus.Text = "Deleted Successfully";
                                    txtBxSalary.Clear();
                                    txtBxEmpType.Clear();
                                    txtBxFirstName.Clear();
                                    txtBxLastName.Clear();
                                }
                                else
                                {
                                    lblStatus.Text = "Delete Failed. Field did not match";
                                }


                }
            }

        }
        /// <summary>
        /// Clears all the data entered in the fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBxSalary.Text = "";
            txtBxLastName.Text = "";
            txtBxFirstName.Text = "";
            txtBxEmpType.Text = "";
        }
        /// <summary>
        /// Sets all the edit funtions to visible. Sets Edit listbox to the item selected in the Employee listbox
        /// enables the commit edit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditSelected_Click(object sender, EventArgs e)
        {
           
            if(lstBxEmpolyee.Items.Count ==0)
            {
                lblStatus.Text = "Nothing to Edit";
            }
 
                else if (lstBxEmpolyee.SelectedIndex != -1)
                {
                    lblEditFN.Visible = !lblEditFN.Visible;
                    lblEditLN.Visible = !lblEditLN.Visible;
                    lblEditType.Visible = !lblEditType.Visible;
                    lblEditSal.Visible = !lblEditSal.Visible;
                    txtBxEditEmpType.Visible = !txtBxEditEmpType.Visible;
                    txtBxEditFName.Visible = !txtBxEditFName.Visible;
                    txtBxEditLName.Visible = !txtBxEditLName.Visible;
                    txtBxEditSalary.Visible = !txtBxEditSalary.Visible;
                    btnCommit.Visible = !btnCommit.Visible;
                    lstBxEdit.Visible = !lstBxEdit.Visible;
                    lstBxEdit.Items.Add(lstBxEmpolyee.SelectedItem);
                    btnCommit.Enabled = true;
                    btnCancelEdit.Visible = !btnCancelEdit.Visible;
                    btnDeleteSelected.Enabled = false;
                }

        }
        /// <summary>
        /// If an item is selcted it enables the edit button and the delete selected button
        /// while disabled the delete all btn
        /// if an item is not selected the edit and delete selected button are disabled
        /// while it reenables the delete all btn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBxEmpolyee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxEmpolyee.SelectedIndex != -1)
            {
                btnEditSelected.Enabled = true;
                btnDeleteSelected.Enabled = true;
                btnDelete.Enabled = false;
            }
            else if(lstBxEmpolyee.SelectedIndex ==-1)
            {
                btnDeleteSelected.Enabled = false;
                btnEditSelected.Enabled = false;
                btnDelete.Enabled = true;
            }
        }
        /// <summary>
        /// Deletes Selected Index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            lstBxEmpolyee.Items.Remove(lstBxEmpolyee.SelectedItem);
            lblStatus.Text = "Deleted Successfully";
        }
        /// <summary>
        /// Deletes Selected Index and replaces it with what the user entered into the new field boxes. 
        /// It also upon completion clears out the entered data and sets all visible fields to invisible 
        /// and disables all related buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommit_Click(object sender, EventArgs e)
        {
            double sal;
            bool isValid = true;
            lblStatus.Text = "";
            if (txtBxEditLName.Text == "")
            {
                lblStatus.Text += "Last Name cannot be blank";
                isValid = false;
            }
            if (txtBxEditFName.Text == "")
            {
                lblStatus.Text += "First Name cannot be blank";
                isValid = false;
            }
            if (txtBxEditEmpType.Text == "")
            {
                lblStatus.Text += "Employee Type cannot be blank";
                isValid = false;
            }
            if (txtBxEditSalary.Text == "")
            {
                lblStatus.Text += "Salary cannot be blank";
            }
            if (double.TryParse(txtBxEditSalary.Text, out sal) == false)
            {

                lblStatus.Text += "Salary cannot be anything but a number";
                isValid = false;

            }
            if (isValid)
            {
                lstBxEmpolyee.Items.Remove(lstBxEmpolyee.SelectedItem);
                lstBxEdit.Items.RemoveAt(0);
                EmployeeClass aEmployee = new EmployeeClass(txtBxEditLName.Text, txtBxEditFName.Text, txtBxEditEmpType.Text, Convert.ToDouble(txtBxEditSalary.Text));
                lstBxEmpolyee.Items.Add(aEmployee);
                btnCommit.Enabled = false;
                if (lblEditSal.Visible == true && lblEditFN.Visible == true && lblEditLN.Visible == true && lblEditType.Visible == true)
                {
                    lblEditFN.Visible = !lblEditFN.Visible;
                    lblEditLN.Visible = !lblEditLN.Visible;
                    lblEditType.Visible = !lblEditType.Visible;
                    lblEditSal.Visible = !lblEditSal.Visible;
                    txtBxEditEmpType.Visible = !txtBxEditEmpType.Visible;
                    txtBxEditFName.Visible = !txtBxEditFName.Visible;
                    txtBxEditLName.Visible = !txtBxEditLName.Visible;
                    txtBxEditSalary.Visible = !txtBxEditSalary.Visible;
                    btnCommit.Visible = !btnCommit.Visible;
                    lstBxEdit.Visible = !lstBxEdit.Visible;
                    txtBxEditEmpType.Clear();
                    txtBxEditFName.Clear();
                    txtBxEditLName.Clear();
                    txtBxEditSalary.Clear();
                    btnCancelEdit.Visible = btnCancelEdit.Visible;
                    btnCancelEdit.Visible = btnCancelEdit.Visible;
                    lblStatus.Text = "Edited Succesfully";
                    if(btnCancelEdit.Visible != false)
                    {
                        btnCancelEdit.Visible = !btnCancelEdit.Visible;
                    }
                }
            }

        }
        /// <summary>
        /// shows the version of the app, who created it and the date it was created. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0" + "\n" + "Created by Gregory Pugh" + "\n" + "Created on May 7,2018"+"\n"+"This Program allows you to add,edit, and delete specific imformation about Employees to a list. \nIt also allows you to open, save and edit files of the same type of format.");
        }
        /// <summary>
        /// opens a file and sets the global to the filename and fills the employee list box with useres in
        /// the correct format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlsOpen_Click(object sender, EventArgs e)
        {
            try
            {
                lstBxEmpolyee.Items.Clear();
                openFileDialog1.FileName = fileName;
                openFileDialog1.ShowDialog();
                fileName = openFileDialog1.FileName;
                StreamReader inFile = new StreamReader(fileName);
                string inLine = inFile.ReadLine();
                while (inLine != null)
                {                    
                        string[] fields = inLine.Split(',');
                        EmployeeClass aEmployee = new EmployeeClass(fields[0], fields[1], fields[2], Convert.ToDouble(fields[3]));
                        lstBxEmpolyee.Items.Add(aEmployee);
                        inLine = (inFile.ReadLine());                                    
                    
                }
                inFile.Close();
                lblStatus.Text = "Loaded Successfully";
            }
            catch (Exception exc)
            {
                lblStatus.Text = exc.Message + "...Load Failed";
            }
        }
        /// <summary>
        /// If file name equals null it runs the save aa function 
        /// if the file name doesn't equal null it runs the save function with current file name and overwrites the previouse files data with the upadted data. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlsSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (fileName != null)
                {
                    fileName = saveFileDialog1.FileName;
                    StreamWriter outFile = new StreamWriter(fileName, false);
                    foreach (EmployeeClass item in lstBxEmpolyee.Items)
                    {
                        outFile.WriteLine(item.ToFileString());
                    }
                    outFile.Close();
                    lblStatus.Text = "Saved";
                }
                if(fileName == null)
                {
                    saveFileDialog1.FileName = fileName;
                    saveFileDialog1.ShowDialog();
                    fileName = saveFileDialog1.FileName;
                    StreamWriter outFile = new StreamWriter(fileName);
                    foreach (EmployeeClass item in lstBxEmpolyee.Items)
                    {
                        outFile.WriteLine(item.ToFileString());

                    }
                    outFile.Close();
                    lblStatus.Text = "Saved Successfully";
                }
            }
            catch (Exception exc)
            {
                lblStatus.Text = exc.Message;
            }
        }
        /// <summary>
        /// allows you to edit the file if the a property is selected otherwise it displays an error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlsProperties_Click(object sender, EventArgs e)
        {
            if(lstBxEmpolyee.SelectedIndex != -1)
            {
                lblEditFN.Visible = !lblEditFN.Visible;
                lblEditLN.Visible = !lblEditLN.Visible;
                lblEditType.Visible = !lblEditType.Visible;
                lblEditSal.Visible = !lblEditSal.Visible;
                txtBxEditEmpType.Visible = !txtBxEditEmpType.Visible;
                txtBxEditFName.Visible = !txtBxEditFName.Visible;
                txtBxEditLName.Visible = !txtBxEditLName.Visible;
                txtBxEditSalary.Visible = !txtBxEditSalary.Visible;
                btnCommit.Visible = !btnCommit.Visible;
                btnCancelEdit.Visible = !btnCancelEdit.Visible;
                lstBxEdit.Visible = !lstBxEdit.Visible;
                lstBxEdit.Items.Add(lstBxEmpolyee.SelectedItem);
                btnCommit.Enabled = true;
            }
            else
            {
                lblStatus.Text = "No item selected to edit";
            }
        }
        /// <summary>
        /// Clears all edit fields disables the commit button and removes the item in the edit listbox and sets 
        /// all visible items back to not visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            lblEditFN.Visible = !lblEditFN.Visible;
            lblEditLN.Visible = !lblEditLN.Visible;
            lblEditType.Visible = !lblEditType.Visible;
            lblEditSal.Visible = !lblEditSal.Visible;
            txtBxEditEmpType.Visible = !txtBxEditEmpType.Visible;
            txtBxEditFName.Visible = !txtBxEditFName.Visible;
            txtBxEditLName.Visible = !txtBxEditLName.Visible;
            txtBxEditSalary.Visible = !txtBxEditSalary.Visible;
            btnCommit.Visible = !btnCommit.Visible;
            btnCancelEdit.Visible = !btnCancelEdit.Visible;
            lstBxEdit.Visible = !lstBxEdit.Visible;
            txtBxEditEmpType.Clear();
            txtBxEditFName.Clear();
            txtBxEditLName.Clear();
            txtBxEditSalary.Clear();
            btnCommit.Enabled = false;
            lstBxEdit.Items.RemoveAt(0); //clears the items list box.
            btnDeleteSelected.Enabled = true;
            //if (btnCancelEdit.Visible == true)
            //{
            //    btnCancelEdit.Visible = false;

            //}
            if (btnCommit.Visible == true)
            {
                btnCommit.Visible = !btnCommit.Visible;
                btnCancelEdit.Visible = !btnCancelEdit.Visible;
            }
        }
        /// <summary>
        /// Saves the File with a new name displays an error message when an exception is thrown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlsSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = fileName;
                saveFileDialog1.ShowDialog();
                fileName = saveFileDialog1.FileName;
                StreamWriter outFile = new StreamWriter(fileName);
                foreach (EmployeeClass item in lstBxEmpolyee.Items)
                {
                    outFile.WriteLine(item.ToFileString());

                }
                outFile.Close();
                lblStatus.Text = "Saved Successfully";
            }
            catch(Exception exc)
            {
                lblStatus.Text = exc.Message;
            }

        }
    }
}