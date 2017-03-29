namespace TaskManagementFinal
{
    partial class NewTaskForm
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
            this.grpBox_newTask = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.comboBox_AssigneeList = new System.Windows.Forms.ComboBox();
            this.lbl_assignTo = new System.Windows.Forms.Label();
            this.txtBox_taskName = new System.Windows.Forms.TextBox();
            this.lbl_taskName = new System.Windows.Forms.Label();
            this.btn_addTask = new System.Windows.Forms.Button();
            this.lbl_dueDate = new System.Windows.Forms.Label();
            this.datePicker_dueDate = new System.Windows.Forms.DateTimePicker();
            this.TaskNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBox_newTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskNameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox_newTask
            // 
            this.grpBox_newTask.Controls.Add(this.btn_cancel);
            this.grpBox_newTask.Controls.Add(this.comboBox_AssigneeList);
            this.grpBox_newTask.Controls.Add(this.lbl_assignTo);
            this.grpBox_newTask.Controls.Add(this.txtBox_taskName);
            this.grpBox_newTask.Controls.Add(this.lbl_taskName);
            this.grpBox_newTask.Controls.Add(this.btn_addTask);
            this.grpBox_newTask.Controls.Add(this.lbl_dueDate);
            this.grpBox_newTask.Controls.Add(this.datePicker_dueDate);
            this.grpBox_newTask.Location = new System.Drawing.Point(12, 12);
            this.grpBox_newTask.Name = "grpBox_newTask";
            this.grpBox_newTask.Size = new System.Drawing.Size(455, 232);
            this.grpBox_newTask.TabIndex = 11;
            this.grpBox_newTask.TabStop = false;
            this.grpBox_newTask.Text = "Add a new task";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(320, 177);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 39);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // comboBox_AssigneeList
            // 
            this.comboBox_AssigneeList.FormattingEnabled = true;
            this.comboBox_AssigneeList.Location = new System.Drawing.Point(113, 137);
            this.comboBox_AssigneeList.Name = "comboBox_AssigneeList";
            this.comboBox_AssigneeList.Size = new System.Drawing.Size(317, 24);
            this.comboBox_AssigneeList.TabIndex = 11;
            // 
            // lbl_assignTo
            // 
            this.lbl_assignTo.AutoSize = true;
            this.lbl_assignTo.Location = new System.Drawing.Point(12, 146);
            this.lbl_assignTo.Name = "lbl_assignTo";
            this.lbl_assignTo.Size = new System.Drawing.Size(75, 17);
            this.lbl_assignTo.TabIndex = 10;
            this.lbl_assignTo.Text = "Assign To:";
            // 
            // txtBox_taskName
            // 
            this.txtBox_taskName.Location = new System.Drawing.Point(113, 36);
            this.txtBox_taskName.Multiline = true;
            this.txtBox_taskName.Name = "txtBox_taskName";
            this.txtBox_taskName.Size = new System.Drawing.Size(317, 54);
            this.txtBox_taskName.TabIndex = 5;
            this.txtBox_taskName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBox_taskName_Validating);
            // 
            // lbl_taskName
            // 
            this.lbl_taskName.AutoSize = true;
            this.lbl_taskName.Location = new System.Drawing.Point(12, 36);
            this.lbl_taskName.Name = "lbl_taskName";
            this.lbl_taskName.Size = new System.Drawing.Size(84, 17);
            this.lbl_taskName.TabIndex = 4;
            this.lbl_taskName.Text = "Task Name:";
            // 
            // btn_addTask
            // 
            this.btn_addTask.Location = new System.Drawing.Point(195, 177);
            this.btn_addTask.Name = "btn_addTask";
            this.btn_addTask.Size = new System.Drawing.Size(110, 39);
            this.btn_addTask.TabIndex = 8;
            this.btn_addTask.Text = "Add task";
            this.btn_addTask.UseVisualStyleBackColor = true;
            // 
            // lbl_dueDate
            // 
            this.lbl_dueDate.AutoSize = true;
            this.lbl_dueDate.Location = new System.Drawing.Point(12, 102);
            this.lbl_dueDate.Name = "lbl_dueDate";
            this.lbl_dueDate.Size = new System.Drawing.Size(72, 17);
            this.lbl_dueDate.TabIndex = 6;
            this.lbl_dueDate.Text = "Due Date:";
            // 
            // datePicker_dueDate
            // 
            this.datePicker_dueDate.Location = new System.Drawing.Point(113, 101);
            this.datePicker_dueDate.Name = "datePicker_dueDate";
            this.datePicker_dueDate.Size = new System.Drawing.Size(317, 22);
            this.datePicker_dueDate.TabIndex = 7;
            // 
            // TaskNameErrorProvider
            // 
            this.TaskNameErrorProvider.ContainerControl = this;
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 255);
            this.Controls.Add(this.grpBox_newTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewTaskForm";
            this.Load += new System.EventHandler(this.NewTaskForm_Load);
            this.grpBox_newTask.ResumeLayout(false);
            this.grpBox_newTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskNameErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

       
        

        #endregion

        #region EventHandlers


        #endregion

        public System.Windows.Forms.GroupBox grpBox_newTask;
        public System.Windows.Forms.ComboBox comboBox_AssigneeList;
        public System.Windows.Forms.Label lbl_assignTo;
        public System.Windows.Forms.TextBox txtBox_taskName;
        public System.Windows.Forms.Label lbl_taskName;
        public System.Windows.Forms.Button btn_addTask;
        public System.Windows.Forms.Label lbl_dueDate;
        public System.Windows.Forms.DateTimePicker datePicker_dueDate;
        private System.Windows.Forms.ErrorProvider TaskNameErrorProvider;
        public System.Windows.Forms.Button btn_cancel;
    }
}