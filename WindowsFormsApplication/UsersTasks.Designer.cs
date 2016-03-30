namespace WindowsFormsApplication
{
    partial class UsersTasks
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
                dataGridView1.DataSource = null;
                _instance = null;
                
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabTasks = new System.Windows.Forms.TabPage();
            this.TabAddTask = new System.Windows.Forms.TabPage();
            this.btnScheduleTask = new System.Windows.Forms.Button();
            this.dtpWhen = new System.Windows.Forms.DateTimePicker();
            this.lbLocation = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabTasks.SuspendLayout();
            this.TabAddTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(408, 353);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(144, 24);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 1;
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(141, 8);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(29, 13);
            this.lbFilter.TabIndex = 2;
            this.lbFilter.Text = "Filter";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Location = new System.Drawing.Point(283, 22);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(114, 23);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemove.Location = new System.Drawing.Point(6, 22);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove selected task";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabTasks);
            this.tabControl1.Controls.Add(this.TabAddTask);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 443);
            this.tabControl1.TabIndex = 5;
            // 
            // TabTasks
            // 
            this.TabTasks.Controls.Add(this.dataGridView1);
            this.TabTasks.Controls.Add(this.btnRemove);
            this.TabTasks.Controls.Add(this.cbFilter);
            this.TabTasks.Controls.Add(this.btnAddTask);
            this.TabTasks.Controls.Add(this.lbFilter);
            this.TabTasks.Location = new System.Drawing.Point(4, 22);
            this.TabTasks.Name = "TabTasks";
            this.TabTasks.Padding = new System.Windows.Forms.Padding(3);
            this.TabTasks.Size = new System.Drawing.Size(420, 417);
            this.TabTasks.TabIndex = 0;
            this.TabTasks.Text = "Tasks";
            this.TabTasks.UseVisualStyleBackColor = true;
            // 
            // TabAddTask
            // 
            this.TabAddTask.Controls.Add(this.btnScheduleTask);
            this.TabAddTask.Controls.Add(this.dtpWhen);
            this.TabAddTask.Controls.Add(this.lbLocation);
            this.TabAddTask.Controls.Add(this.tbLocation);
            this.TabAddTask.Controls.Add(this.lbDate);
            this.TabAddTask.Controls.Add(this.lbTitle);
            this.TabAddTask.Controls.Add(this.tbTitle);
            this.TabAddTask.Location = new System.Drawing.Point(4, 22);
            this.TabAddTask.Name = "TabAddTask";
            this.TabAddTask.Padding = new System.Windows.Forms.Padding(3);
            this.TabAddTask.Size = new System.Drawing.Size(420, 417);
            this.TabAddTask.TabIndex = 1;
            this.TabAddTask.Text = "Add a new task";
            this.TabAddTask.UseVisualStyleBackColor = true;
            // 
            // btnScheduleTask
            // 
            this.btnScheduleTask.Location = new System.Drawing.Point(91, 254);
            this.btnScheduleTask.Name = "btnScheduleTask";
            this.btnScheduleTask.Size = new System.Drawing.Size(100, 23);
            this.btnScheduleTask.TabIndex = 15;
            this.btnScheduleTask.Text = "Schedule Task";
            this.btnScheduleTask.UseVisualStyleBackColor = true;
            this.btnScheduleTask.Click += new System.EventHandler(this.btnScheduleTask_Click);
            // 
            // dtpWhen
            // 
            this.dtpWhen.CustomFormat = "yyyy MMM dd hh:mm";
            this.dtpWhen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWhen.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.dtpWhen.Location = new System.Drawing.Point(91, 118);
            this.dtpWhen.Name = "dtpWhen";
            this.dtpWhen.Size = new System.Drawing.Size(177, 20);
            this.dtpWhen.TabIndex = 14;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(88, 192);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(48, 13);
            this.lbLocation.TabIndex = 13;
            this.lbLocation.Text = "Location";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(91, 206);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(100, 20);
            this.tbLocation.TabIndex = 12;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(88, 102);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(36, 13);
            this.lbDate.TabIndex = 11;
            this.lbDate.Text = "When";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(88, 50);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(27, 13);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(91, 66);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 9;
            // 
            // UsersTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControl1);
            this.Name = "UsersTasks";
            this.Size = new System.Drawing.Size(434, 455);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabTasks.ResumeLayout(false);
            this.TabTasks.PerformLayout();
            this.TabAddTask.ResumeLayout(false);
            this.TabAddTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabTasks;
        private System.Windows.Forms.TabPage TabAddTask;
        private System.Windows.Forms.Button btnScheduleTask;
        private System.Windows.Forms.DateTimePicker dtpWhen;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbTitle;
    }
}
