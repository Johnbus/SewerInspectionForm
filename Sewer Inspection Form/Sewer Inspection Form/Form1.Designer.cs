namespace Sewer_Inspection_Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneralInformation = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxComments = new System.Windows.Forms.GroupBox();
            this.tabPageEntryLocation = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_GeneralInfo_Inspected = new System.Windows.Forms.CheckBox();
            this.tabPagePipeMaterials = new System.Windows.Forms.TabPage();
            this.tabPageLengthCondition = new System.Windows.Forms.TabPage();
            this.tabPageMainConnection = new System.Windows.Forms.TabPage();
            this.tabPageRecommendations = new System.Windows.Forms.TabPage();
            this.tabPageInvoice = new System.Windows.Forms.TabPage();
            this.tabPageAgreement = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneralInformation.SuspendLayout();
            this.tabPageEntryLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageGeneralInformation);
            this.tabControl1.Controls.Add(this.tabPageEntryLocation);
            this.tabControl1.Controls.Add(this.tabPagePipeMaterials);
            this.tabControl1.Controls.Add(this.tabPageLengthCondition);
            this.tabControl1.Controls.Add(this.tabPageMainConnection);
            this.tabControl1.Controls.Add(this.tabPageRecommendations);
            this.tabControl1.Controls.Add(this.tabPageInvoice);
            this.tabControl1.Controls.Add(this.tabPageAgreement);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1387, 674);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageGeneralInformation
            // 
            this.tabPageGeneralInformation.Controls.Add(this.label4);
            this.tabPageGeneralInformation.Controls.Add(this.dateTimePicker1);
            this.tabPageGeneralInformation.Controls.Add(this.groupBoxComments);
            this.tabPageGeneralInformation.Location = new System.Drawing.Point(8, 39);
            this.tabPageGeneralInformation.Name = "tabPageGeneralInformation";
            this.tabPageGeneralInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneralInformation.Size = new System.Drawing.Size(1371, 627);
            this.tabPageGeneralInformation.TabIndex = 0;
            this.tabPageGeneralInformation.Text = "General Information";
            this.tabPageGeneralInformation.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // groupBoxComments
            // 
            this.groupBoxComments.Location = new System.Drawing.Point(24, 302);
            this.groupBoxComments.Name = "groupBoxComments";
            this.groupBoxComments.Size = new System.Drawing.Size(1327, 322);
            this.groupBoxComments.TabIndex = 0;
            this.groupBoxComments.TabStop = false;
            this.groupBoxComments.Text = "Comments";
            // 
            // tabPageEntryLocation
            // 
            this.tabPageEntryLocation.Controls.Add(this.comboBox2);
            this.tabPageEntryLocation.Controls.Add(this.comboBox1);
            this.tabPageEntryLocation.Controls.Add(this.label3);
            this.tabPageEntryLocation.Controls.Add(this.label2);
            this.tabPageEntryLocation.Controls.Add(this.label1);
            this.tabPageEntryLocation.Controls.Add(this.cb_GeneralInfo_Inspected);
            this.tabPageEntryLocation.Location = new System.Drawing.Point(8, 39);
            this.tabPageEntryLocation.Name = "tabPageEntryLocation";
            this.tabPageEntryLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntryLocation.Size = new System.Drawing.Size(1371, 627);
            this.tabPageEntryLocation.TabIndex = 1;
            this.tabPageEntryLocation.Text = "Entry Location";
            this.tabPageEntryLocation.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(305, 145);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 33);
            this.comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Camera Entry Location";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inspected";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_GeneralInfo_Inspected
            // 
            this.cb_GeneralInfo_Inspected.AutoSize = true;
            this.cb_GeneralInfo_Inspected.Location = new System.Drawing.Point(178, 32);
            this.cb_GeneralInfo_Inspected.Name = "cb_GeneralInfo_Inspected";
            this.cb_GeneralInfo_Inspected.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_GeneralInfo_Inspected.Size = new System.Drawing.Size(28, 27);
            this.cb_GeneralInfo_Inspected.TabIndex = 7;
            this.cb_GeneralInfo_Inspected.UseCompatibleTextRendering = true;
            this.cb_GeneralInfo_Inspected.UseVisualStyleBackColor = true;
            // 
            // tabPagePipeMaterials
            // 
            this.tabPagePipeMaterials.Location = new System.Drawing.Point(8, 39);
            this.tabPagePipeMaterials.Name = "tabPagePipeMaterials";
            this.tabPagePipeMaterials.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePipeMaterials.Size = new System.Drawing.Size(1371, 627);
            this.tabPagePipeMaterials.TabIndex = 2;
            this.tabPagePipeMaterials.Text = "Pipe Materials";
            this.tabPagePipeMaterials.UseVisualStyleBackColor = true;
            // 
            // tabPageLengthCondition
            // 
            this.tabPageLengthCondition.Location = new System.Drawing.Point(8, 39);
            this.tabPageLengthCondition.Name = "tabPageLengthCondition";
            this.tabPageLengthCondition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLengthCondition.Size = new System.Drawing.Size(1371, 627);
            this.tabPageLengthCondition.TabIndex = 3;
            this.tabPageLengthCondition.Text = "Length / Condition";
            this.tabPageLengthCondition.UseVisualStyleBackColor = true;
            // 
            // tabPageMainConnection
            // 
            this.tabPageMainConnection.Location = new System.Drawing.Point(8, 39);
            this.tabPageMainConnection.Name = "tabPageMainConnection";
            this.tabPageMainConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainConnection.Size = new System.Drawing.Size(1371, 627);
            this.tabPageMainConnection.TabIndex = 4;
            this.tabPageMainConnection.Text = "Main Connection";
            this.tabPageMainConnection.UseVisualStyleBackColor = true;
            // 
            // tabPageRecommendations
            // 
            this.tabPageRecommendations.Location = new System.Drawing.Point(8, 39);
            this.tabPageRecommendations.Name = "tabPageRecommendations";
            this.tabPageRecommendations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecommendations.Size = new System.Drawing.Size(1371, 627);
            this.tabPageRecommendations.TabIndex = 5;
            this.tabPageRecommendations.Text = "Recommendations";
            this.tabPageRecommendations.UseVisualStyleBackColor = true;
            // 
            // tabPageInvoice
            // 
            this.tabPageInvoice.Location = new System.Drawing.Point(8, 39);
            this.tabPageInvoice.Name = "tabPageInvoice";
            this.tabPageInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInvoice.Size = new System.Drawing.Size(1371, 627);
            this.tabPageInvoice.TabIndex = 6;
            this.tabPageInvoice.Text = "Invoice";
            this.tabPageInvoice.UseVisualStyleBackColor = true;
            // 
            // tabPageAgreement
            // 
            this.tabPageAgreement.Location = new System.Drawing.Point(8, 39);
            this.tabPageAgreement.Name = "tabPageAgreement";
            this.tabPageAgreement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgreement.Size = new System.Drawing.Size(1371, 627);
            this.tabPageAgreement.TabIndex = 7;
            this.tabPageAgreement.Text = "Agreement";
            this.tabPageAgreement.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1084, 680);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(804, 680);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Signature";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 746);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Sewer Inspection Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneralInformation.ResumeLayout(false);
            this.tabPageGeneralInformation.PerformLayout();
            this.tabPageEntryLocation.ResumeLayout(false);
            this.tabPageEntryLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneralInformation;
        private System.Windows.Forms.TabPage tabPageEntryLocation;
        private System.Windows.Forms.TabPage tabPagePipeMaterials;
        private System.Windows.Forms.TabPage tabPageLengthCondition;
        private System.Windows.Forms.TabPage tabPageMainConnection;
        private System.Windows.Forms.TabPage tabPageRecommendations;
        private System.Windows.Forms.TabPage tabPageInvoice;
        private System.Windows.Forms.TabPage tabPageAgreement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_GeneralInfo_Inspected;
        private System.Windows.Forms.GroupBox groupBoxComments;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}

