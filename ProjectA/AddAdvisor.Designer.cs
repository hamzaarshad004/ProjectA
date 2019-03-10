namespace ProjectA
{
    partial class AddAdvisor
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.btnAddAdvisor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(141, 192);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(95, 24);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Advisor ID";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(141, 277);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(109, 24);
            this.lblDesignation.TabIndex = 1;
            this.lblDesignation.Text = "Designation";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(141, 362);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(61, 24);
            this.lblSalary.TabIndex = 2;
            this.lblSalary.Text = "Salary";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(508, 194);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(221, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(508, 364);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(221, 22);
            this.txtSalary.TabIndex = 4;
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.cmbDesignation.Location = new System.Drawing.Point(508, 278);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(221, 24);
            this.cmbDesignation.TabIndex = 5;
            // 
            // btnAddAdvisor
            // 
            this.btnAddAdvisor.Location = new System.Drawing.Point(622, 459);
            this.btnAddAdvisor.Name = "btnAddAdvisor";
            this.btnAddAdvisor.Size = new System.Drawing.Size(106, 42);
            this.btnAddAdvisor.TabIndex = 6;
            this.btnAddAdvisor.Text = "Submit";
            this.btnAddAdvisor.UseVisualStyleBackColor = true;
            this.btnAddAdvisor.Click += new System.EventHandler(this.btnAddAdvisor_Click);
            // 
            // AddAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 639);
            this.Controls.Add(this.btnAddAdvisor);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblID);
            this.Name = "AddAdvisor";
            this.Text = "AddAdvisor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Button btnAddAdvisor;
    }
}