namespace Names
{
    partial class Names
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
            txtName = new TextBox();
            lstNames = new ListBox();
            label1 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 27);
            txtName.TabIndex = 1;
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.Location = new Point(12, 27);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(120, 84);
            lstNames.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Names";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(138, 55);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Names";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Names
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 133);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(lstNames);
            Controls.Add(txtName);
            Name = "Names";
            Text = "Mi primer ventana";
            Load += Names_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private ListBox lstNames;
        private Label label1;
        private Button btnAdd;
    }
}
