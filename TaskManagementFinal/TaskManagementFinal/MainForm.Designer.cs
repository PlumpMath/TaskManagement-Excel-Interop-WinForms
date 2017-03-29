namespace TaskManagementFinal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_TaskList = new System.Windows.Forms.Label();
            this.dataGrid_allTasks = new System.Windows.Forms.DataGridView();
            this.btn_deleteTask = new System.Windows.Forms.Button();
            this.notifyIcon_tasks = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMenuStrip_tasks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_saveAll = new System.Windows.Forms.Button();
            this.btn_addTask = new System.Windows.Forms.Button();
            this.col_taskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_assignee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_allTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TaskList
            // 
            this.lbl_TaskList.AutoSize = true;
            this.lbl_TaskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaskList.Location = new System.Drawing.Point(12, 9);
            this.lbl_TaskList.Name = "lbl_TaskList";
            this.lbl_TaskList.Size = new System.Drawing.Size(78, 20);
            this.lbl_TaskList.TabIndex = 0;
            this.lbl_TaskList.Text = "Task List";
            // 
            // dataGrid_allTasks
            // 
            this.dataGrid_allTasks.AllowUserToAddRows = false;
            this.dataGrid_allTasks.AllowUserToResizeRows = false;
            this.dataGrid_allTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_allTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_allTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_allTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_allTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_taskName,
            this.col_dueDate,
            this.col_assignee,
            this.col_completed});
            this.dataGrid_allTasks.Location = new System.Drawing.Point(16, 46);
            this.dataGrid_allTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGrid_allTasks.MultiSelect = false;
            this.dataGrid_allTasks.Name = "dataGrid_allTasks";
            this.dataGrid_allTasks.RowTemplate.Height = 24;
            this.dataGrid_allTasks.ShowEditingIcon = false;
            this.dataGrid_allTasks.Size = new System.Drawing.Size(455, 267);
            this.dataGrid_allTasks.TabIndex = 1;
            this.dataGrid_allTasks.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_allTasks_CellValueChanged);
            // 
            // btn_deleteTask
            // 
            this.btn_deleteTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_deleteTask.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteTask.Image")));
            this.btn_deleteTask.Location = new System.Drawing.Point(101, 319);
            this.btn_deleteTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteTask.Name = "btn_deleteTask";
            this.btn_deleteTask.Size = new System.Drawing.Size(80, 30);
            this.btn_deleteTask.TabIndex = 10;
            this.btn_deleteTask.Text = "Delete";
            this.btn_deleteTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deleteTask.UseVisualStyleBackColor = true;
            this.btn_deleteTask.Click += new System.EventHandler(this.btn_deleteTask_Click);
            // 
            // notifyIcon_tasks
            // 
            this.notifyIcon_tasks.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_tasks.Icon")));
            this.notifyIcon_tasks.Visible = true;
            this.notifyIcon_tasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_tasks_MouseDoubleClick);
            // 
            // ctxMenuStrip_tasks
            // 
            this.ctxMenuStrip_tasks.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuStrip_tasks.Name = "contextMenuStrip1";
            this.ctxMenuStrip_tasks.ShowCheckMargin = true;
            this.ctxMenuStrip_tasks.ShowImageMargin = false;
            this.ctxMenuStrip_tasks.Size = new System.Drawing.Size(67, 4);
            this.ctxMenuStrip_tasks.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMenuStrip_tasks_Opening);
            // 
            // btn_saveAll
            // 
            this.btn_saveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_saveAll.Image = ((System.Drawing.Image)(resources.GetObject("btn_saveAll.Image")));
            this.btn_saveAll.Location = new System.Drawing.Point(391, 319);
            this.btn_saveAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_saveAll.Name = "btn_saveAll";
            this.btn_saveAll.Size = new System.Drawing.Size(80, 30);
            this.btn_saveAll.TabIndex = 11;
            this.btn_saveAll.Text = "Save";
            this.btn_saveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_saveAll.UseVisualStyleBackColor = true;
            this.btn_saveAll.Click += new System.EventHandler(this.btn_saveAll_Click);
            // 
            // btn_addTask
            // 
            this.btn_addTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_addTask.Image = ((System.Drawing.Image)(resources.GetObject("btn_addTask.Image")));
            this.btn_addTask.Location = new System.Drawing.Point(16, 319);
            this.btn_addTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addTask.Name = "btn_addTask";
            this.btn_addTask.Size = new System.Drawing.Size(80, 30);
            this.btn_addTask.TabIndex = 12;
            this.btn_addTask.Text = "Add";
            this.btn_addTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addTask.UseVisualStyleBackColor = true;
            this.btn_addTask.Click += new System.EventHandler(this.btn_addTask_Click);
            // 
            // col_taskName
            // 
            this.col_taskName.DataPropertyName = "TaskName";
            this.col_taskName.HeaderText = "TaskName";
            this.col_taskName.Name = "col_taskName";
            this.col_taskName.ReadOnly = true;
            // 
            // col_dueDate
            // 
            this.col_dueDate.DataPropertyName = "DueDate";
            this.col_dueDate.HeaderText = "DueDate";
            this.col_dueDate.Name = "col_dueDate";
            this.col_dueDate.ReadOnly = true;
            // 
            // col_assignee
            // 
            this.col_assignee.DataPropertyName = "Assignee";
            this.col_assignee.HeaderText = "Assignee";
            this.col_assignee.Name = "col_assignee";
            this.col_assignee.ReadOnly = true;
            // 
            // col_completed
            // 
            this.col_completed.DataPropertyName = "Completed";
            this.col_completed.HeaderText = "Completed";
            this.col_completed.Name = "col_completed";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 361);
            this.Controls.Add(this.btn_addTask);
            this.Controls.Add(this.btn_saveAll);
            this.Controls.Add(this.btn_deleteTask);
            this.Controls.Add(this.dataGrid_allTasks);
            this.Controls.Add(this.lbl_TaskList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_allTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TaskList;
        private System.Windows.Forms.DataGridView dataGrid_allTasks;
        private System.Windows.Forms.Button btn_deleteTask;
        private System.Windows.Forms.NotifyIcon notifyIcon_tasks;
        private System.Windows.Forms.ContextMenuStrip ctxMenuStrip_tasks;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_saveAll;
        private System.Windows.Forms.Button btn_addTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_taskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_assignee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_completed;
    }
}