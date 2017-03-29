using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
namespace TaskManagementFinal
{
    public partial class MainForm : Form
    {
        private BindingSource allTaskListSource; 
        private BindingSource assigneeListSource;
        private TasksDAC taskDACObject;
        private bool formValuesChanged; 

        public MainForm()
        {
            InitializeComponent();
            allTaskListSource = new BindingSource();
            assigneeListSource = new BindingSource();
            taskDACObject = new TasksDAC();
        }

        /// <summary>
        /// Executes when form is loaded. Binds the data grid view to the list returned from 
        /// loadFile method. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGrid_allTasks.AutoGenerateColumns = false;
            //Get data from files.
            var listOfAllTasks = taskDACObject.LoadTasksFile();
            allTaskListSource.DataSource = listOfAllTasks;
            var listOfAssignees = taskDACObject.LoadAssigneeFile();
            assigneeListSource.DataSource = listOfAssignees;
            //Bind view to data source
            dataGrid_allTasks.DataSource = allTaskListSource;
            
            notifyIcon_tasks.ContextMenuStrip = ctxMenuStrip_tasks;
        }

        /// <summary>
        /// Show popup message about status of save.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saveAll_Click(object sender, EventArgs e)
        {
            if (formValuesChanged)
            {
                bool fileSavedSuccessfully = taskDACObject.SaveFile(dataGrid_allTasks);

                if (!fileSavedSuccessfully)
                {
                    MessageBox.Show(SharedData.SAVE_FAILED_WARNING);
                }
                else
                {
                    MessageBox.Show(SharedData.SAVE_SUCCESSFUL_WARNING);
                    formValuesChanged = false;
                }
            }
            else
            {
                MessageBox.Show(SharedData.NO_CHANGES_WARNING);
                formValuesChanged = false;
            }
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (formValuesChanged)
            {
                base.OnFormClosing(e);
                if (e.CloseReason == CloseReason.WindowsShutDown) return;
                // Confirm user wants to close
                switch (MessageBox.Show(this, SharedData.BEFORE_EXIT_WARNING, SharedData.TEXTBOX_CAPTION, MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        e.Cancel = false;
                        break;
                    case DialogResult.Yes:
                        if (!taskDACObject.SaveFile(dataGrid_allTasks))
                            MessageBox.Show(SharedData.SAVE_FAILED_WARNING);
                        else
                            MessageBox.Show(SharedData.SAVE_SUCCESSFUL_WARNING);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Function to delete tasks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deleteTask_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = dataGrid_allTasks.SelectedRows.Count;

            if (selectedRowsCount < 1)
            {
                MessageBox.Show(SharedData.ROW_NOT_SELECTED_WARNING);
                return;
            }
            foreach (DataGridViewRow row in dataGrid_allTasks.SelectedRows)
            {
                dataGrid_allTasks.Rows.Remove(row);
                formValuesChanged = true;
            }
        }

        /// <summary>
        /// Open or close window on double clicking the icon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_tasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
            else if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Minimize, maximize application window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon_tasks.BalloonTipText = SharedData.MINIMIZED_TIP;
                notifyIcon_tasks.ShowBalloonTip(1000);
            }
            else if (WindowState == FormWindowState.Normal)
            {
                notifyIcon_tasks.BalloonTipText = SharedData.MAXIMIZED_TIP;
                notifyIcon_tasks.ShowBalloonTip(1000);
            }
        }

        /// <summary>
        /// Load context menu with changed data before it opens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctxMenuStrip_tasks_Opening(object sender, CancelEventArgs e)
        {
            var allTaskList = (List<Task>)allTaskListSource.DataSource;
            var todaysTaskList = allTaskList.FindAll(x => x.DueDate == DateTime.Now.Date);
            if (todaysTaskList.Count <= 0)
            {
                ctxMenuStrip_tasks.Items.Clear();
                notifyIcon_tasks.BalloonTipText = SharedData.NO_PENDING_TASKS;
                notifyIcon_tasks.ShowBalloonTip(200);
            }
            else
            {
                ctxMenuStrip_tasks.Items.Clear();
                foreach (var item in todaysTaskList)
                {
                    var checkItem = this.ctxMenuStrip_tasks.Items.Add(item.ToString());
                    if (item.Completed)
                        ((ToolStripMenuItem)checkItem).Checked = true;
                }
            }
        }

        private void dataGrid_allTasks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            formValuesChanged = true;
        }

        private void btn_addTask_Click(object sender, EventArgs e)
        {
            var newTaskForm = new NewTaskForm(assigneeListSource);
            var result = newTaskForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var taskName = newTaskForm.txtBox_taskName.Text.ToString().TrimStart(SharedData.CHARACTERS_TO_TRIM).TrimEnd(SharedData.CHARACTERS_TO_TRIM);
                var date = newTaskForm.datePicker_dueDate.Value.Date;
                var assignee = newTaskForm.comboBox_AssigneeList.SelectedValue.ToString();
                var task = new Task(taskName, date, assignee);
                allTaskListSource.Add(task);
                formValuesChanged = true;
            }
        }
    }
}
