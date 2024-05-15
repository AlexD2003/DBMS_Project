namespace databases2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardwarestoreDataSet = new databases2.hardwarestoreDataSet();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardwarestoreDataSet1 = new databases2.hardwarestoreDataSet1();
            this.fKEmployeeOrdEid440B1D61BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardwarestoreDataSet2 = new databases2.hardwarestoreDataSet2();
            this.orderDetailsTableAdapter = new databases2.hardwarestoreDataSet1TableAdapters.OrderDetailsTableAdapter();
            this.databaseVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseVersionTableAdapter = new databases2.hardwarestoreDataSetTableAdapters.DatabaseVersionTableAdapter();
            this.employeesTableAdapter = new databases2.hardwarestoreDataSetTableAdapters.EmployeesTableAdapter();
            this.employeeOrderAssignmentsTableAdapter = new databases2.hardwarestoreDataSetTableAdapters.EmployeeOrderAssignmentsTableAdapter();
            this.productsTableAdapter = new databases2.hardwarestoreDataSet2TableAdapters.ProductsTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.getParentId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarestoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarestoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeeOrdEid440B1D61BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarestoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVersionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 164);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hardwarestoreDataSet;
            // 
            // hardwarestoreDataSet
            // 
            this.hardwarestoreDataSet.DataSetName = "hardwarestoreDataSet";
            this.hardwarestoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.hardwarestoreDataSet1;
            // 
            // hardwarestoreDataSet1
            // 
            this.hardwarestoreDataSet1.DataSetName = "hardwarestoreDataSet1";
            this.hardwarestoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKEmployeeOrdEid440B1D61BindingSource
            // 
            this.fKEmployeeOrdEid440B1D61BindingSource.DataMember = "FK__EmployeeOrd__Eid__440B1D61";
            this.fKEmployeeOrdEid440B1D61BindingSource.DataSource = this.employeesBindingSource;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.hardwarestoreDataSet2;
            // 
            // hardwarestoreDataSet2
            // 
            this.hardwarestoreDataSet2.DataSetName = "hardwarestoreDataSet2";
            this.hardwarestoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // databaseVersionBindingSource
            // 
            this.databaseVersionBindingSource.DataMember = "DatabaseVersion";
            this.databaseVersionBindingSource.DataSource = this.hardwarestoreDataSet;
            // 
            // databaseVersionTableAdapter
            // 
            this.databaseVersionTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeOrderAssignmentsTableAdapter
            // 
            this.employeeOrderAssignmentsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(268, 276);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(753, 183);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.b1click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deleteClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.updateClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Parent new id";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // getParentId
            // 
            this.getParentId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.getParentId.Location = new System.Drawing.Point(12, 301);
            this.getParentId.Name = "getParentId";
            this.getParentId.Size = new System.Drawing.Size(100, 20);
            this.getParentId.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 580);
            this.Controls.Add(this.getParentId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarestoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarestoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeeOrdEid440B1D61BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwarestoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseVersionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private hardwarestoreDataSet hardwarestoreDataSet;
        private System.Windows.Forms.BindingSource databaseVersionBindingSource;
        private hardwarestoreDataSetTableAdapters.DatabaseVersionTableAdapter databaseVersionTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private hardwarestoreDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource fKEmployeeOrdEid440B1D61BindingSource;
        private hardwarestoreDataSetTableAdapters.EmployeeOrderAssignmentsTableAdapter employeeOrderAssignmentsTableAdapter;
        private hardwarestoreDataSet1 hardwarestoreDataSet1;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private hardwarestoreDataSet1TableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private hardwarestoreDataSet2 hardwarestoreDataSet2;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private hardwarestoreDataSet2TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox getParentId;
    }
}

