using System;
using System.Windows.Forms;

namespace TaskManagementFinal
{
    public partial class NewTaskForm : Form
    {
        private BindingSource assigneeListSource;
        private TasksDAC taskDACObject;

        public NewTaskForm()
        {
            InitializeComponent();
        }

        public NewTaskForm(BindingSource assigneeList)
        {
            InitializeComponent();
            assigneeListSource = new BindingSource();
            taskDACObject = new TasksDAC();
            assigneeListSource.DataSource = assigneeList.DataSource;
        }

        void NewTaskForm_Load(object sender, EventArgs e)
        {
            //Set the min and max date of date picker.
            datePicker_dueDate.MinDate = DateTime.Today.Date;
            datePicker_dueDate.MaxDate = new DateTime(2099, 12, 31);
            //disable add button
            btn_addTask.Enabled = false;
            btn_addTask.DialogResult = DialogResult.OK;
            //bind data to assignee combo box.
            comboBox_AssigneeList.DataSource = assigneeListSource;
        }

        private void txtBox_taskName_Validating(object sender, KeyEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBox_taskName.Text))
                {
                    btn_addTask.Enabled = false;
                    txtBox_taskName.Focus();
                    TaskNameErrorProvider.SetError(txtBox_taskName, SharedData.TEXTBOX_EMPTY_WARNING);
                }
                else if (!string.IsNullOrWhiteSpace(txtBox_taskName.Text))
                {
                    TaskNameErrorProvider.Clear();
                    btn_addTask.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
