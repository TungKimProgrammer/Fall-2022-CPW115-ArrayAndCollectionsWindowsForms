namespace ArrayAndCollectionsWindowsForms
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblInstructions1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSorted = new System.Windows.Forms.Label();
            this.lblReversed = new System.Windows.Forms.Label();
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(147, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Name and Sort";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(19, 86);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(235, 23);
            this.txtbxName.TabIndex = 1;
            this.txtbxName.Text = "Plese enter a name here";
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(272, 86);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(102, 23);
            this.btnAddName.TabIndex = 2;
            this.btnAddName.Text = "&Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(384, 86);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(102, 23);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // lblInstructions1
            // 
            this.lblInstructions1.AutoSize = true;
            this.lblInstructions1.Location = new System.Drawing.Point(19, 124);
            this.lblInstructions1.Name = "lblInstructions1";
            this.lblInstructions1.Size = new System.Drawing.Size(345, 15);
            this.lblInstructions1.TabIndex = 4;
            this.lblInstructions1.Text = "Press Alt + A or hit Enter or click Add Name button to add name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Press Alt + D or click Display button to display names added";
            // 
            // lblSorted
            // 
            this.lblSorted.Location = new System.Drawing.Point(22, 177);
            this.lblSorted.Name = "lblSorted";
            this.lblSorted.Size = new System.Drawing.Size(467, 55);
            this.lblSorted.TabIndex = 6;
            // 
            // lblReversed
            // 
            this.lblReversed.Location = new System.Drawing.Point(19, 245);
            this.lblReversed.Name = "lblReversed";
            this.lblReversed.Size = new System.Drawing.Size(467, 55);
            this.lblReversed.TabIndex = 7;
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.Location = new System.Drawing.Point(20, 194);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(467, 23);
            this.lblErrMsg.TabIndex = 8;
            this.lblErrMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 322);
            this.Controls.Add(this.lblErrMsg);
            this.Controls.Add(this.lblReversed);
            this.Controls.Add(this.lblSorted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInstructions1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Add Name and Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private TextBox txtbxName;
        private Button btnAddName;
        private Button btnDisplay;
        private Label lblInstructions1;
        private Label label1;
        private Label lblSorted;
        private Label lblReversed;
        private Label lblErrMsg;
    }
}