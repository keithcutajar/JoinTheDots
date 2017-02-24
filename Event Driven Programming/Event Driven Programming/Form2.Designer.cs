namespace Event_Driven_Programming
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDots = new System.Windows.Forms.ComboBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlDrawing = new System.Windows.Forms.Panel();
            this.link = new System.Windows.Forms.LinkLabel();
            this.clrDialog = new System.Windows.Forms.ColorDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.help = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many Dots?";
            // 
            // cmbDots
            // 
            this.cmbDots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDots.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbDots.Location = new System.Drawing.Point(118, 22);
            this.cmbDots.Name = "cmbDots";
            this.cmbDots.Size = new System.Drawing.Size(121, 21);
            this.cmbDots.TabIndex = 1;
            this.cmbDots.SelectedIndexChanged += new System.EventHandler(this.cmbDots_SelectedIndexChanged);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(260, 22);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(120, 23);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "Join the Dots!";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(617, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(498, 25);
            this.textBox1.MaxLength = 25;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // pnlDrawing
            // 
            this.pnlDrawing.Location = new System.Drawing.Point(27, 62);
            this.pnlDrawing.Name = "pnlDrawing";
            this.pnlDrawing.Size = new System.Drawing.Size(652, 339);
            this.pnlDrawing.TabIndex = 6;
            this.pnlDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawing_Paint);
            this.pnlDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawing_MouseDown);
            this.pnlDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrawing_MouseMove);
            this.pnlDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrawing_MouseUp);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(575, 414);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(104, 13);
            this.link.TabIndex = 7;
            this.link.TabStop = true;
            this.link.Text = "Open Saved Images";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // help
            // 
            this.help.HelpNamespace = "C:\\Users\\Keith\\Desktop\\Event Driven Programming\\help-menu_tmphhp\\help-menu.chm";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 444);
            this.Controls.Add(this.link);
            this.Controls.Add(this.pnlDrawing);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.cmbDots);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.help.SetHelpKeyword(this, "Welcome.chm");
            this.help.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.help.SetShowHelp(this, true);
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDots;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlDrawing;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.ColorDialog clrDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.HelpProvider help;
    }
}