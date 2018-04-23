namespace DynamicStyleSheet {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.printControl1 = new DevExpress.XtraPrinting.Control.PrintControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yellow",
            "Blue"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(150, 12);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(100, 23);
            this.buttonPreview.TabIndex = 2;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // printControl1
            // 
            this.printControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.printControl1.BackColor = System.Drawing.Color.Empty;
            this.printControl1.ForeColor = System.Drawing.Color.Empty;
            this.printControl1.IsMetric = false;
            this.printControl1.Location = new System.Drawing.Point(12, 41);
            this.printControl1.Name = "printControl1";
            this.printControl1.Size = new System.Drawing.Size(653, 448);
            this.printControl1.TabIndex = 3;
            this.printControl1.TooltipFont = new System.Drawing.Font("Tahoma", 8.25F);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save the Current Style Sheet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printControl1);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonPreview;
        private DevExpress.XtraPrinting.Control.PrintControl printControl1;
        private System.Windows.Forms.Button button1;
    }
}

