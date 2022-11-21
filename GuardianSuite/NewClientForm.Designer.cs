namespace GuardianSuite
{
    partial class NewClientForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Names = new System.Windows.Forms.Label();
            this.listNames = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Location = new System.Drawing.Point(12, 9);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(95, 15);
            this.Names.TabIndex = 0;
            this.Names.Text = "Family Members";
            // 
            // listNames
            // 
            this.listNames.FormattingEnabled = true;
            this.listNames.ItemHeight = 15;
            this.listNames.Items.AddRange(new object[] {
            "Joshua",
            "Whitney",
            "Brenna",
            "Madison",
            "Walker",
            "Shane",
            "Molly",
            "Joey",
            "Phoebe"});
            this.listNames.Location = new System.Drawing.Point(12, 27);
            this.listNames.Name = "listNames";
            this.listNames.Size = new System.Drawing.Size(120, 94);
            this.listNames.TabIndex = 1;
            this.listNames.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Name";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(138, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // NewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 141);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.listNames);
            this.Controls.Add(this.Names);
            this.Name = "NewClientForm";
            this.Text = "Guardian Suite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Names;
        private ListBox listNames;
        private TextBox txtName;
        private Button btnAdd;
        private Button btnClear;
    }
}