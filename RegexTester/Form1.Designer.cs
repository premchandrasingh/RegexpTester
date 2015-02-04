namespace RegexTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxRegEx = new System.Windows.Forms.TextBox();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonClearRegex = new System.Windows.Forms.Button();
            this.buttonClearTest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatches = new System.Windows.Forms.TextBox();
            this.rbIgnoreCase = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.chkMatchIndex = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxRegEx
            // 
            this.textBoxRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegEx.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegEx.Location = new System.Drawing.Point(92, 36);
            this.textBoxRegEx.Name = "textBoxRegEx";
            this.textBoxRegEx.Size = new System.Drawing.Size(491, 31);
            this.textBoxRegEx.TabIndex = 0;
            this.textBoxRegEx.TextChanged += new System.EventHandler(this.textBoxRegEx_TextChanged);
            // 
            // textBoxTest
            // 
            this.textBoxTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTest.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTest.Location = new System.Drawing.Point(92, 73);
            this.textBoxTest.Multiline = true;
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(491, 84);
            this.textBoxTest.TabIndex = 1;
            this.textBoxTest.TextChanged += new System.EventHandler(this.textBoxTest_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Regex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBarMessage
            // 
            this.statusBarMessage.Name = "statusBarMessage";
            this.statusBarMessage.Size = new System.Drawing.Size(109, 17);
            this.statusBarMessage.Text = "toolStripStatusLabel1";
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.Location = new System.Drawing.Point(508, 299);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(75, 31);
            this.buttonClearAll.TabIndex = 7;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonClearRegex
            // 
            this.buttonClearRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearRegex.Image = global::RegexTester.Properties.Resources.delete16;
            this.buttonClearRegex.Location = new System.Drawing.Point(589, 36);
            this.buttonClearRegex.Name = "buttonClearRegex";
            this.buttonClearRegex.Size = new System.Drawing.Size(31, 31);
            this.buttonClearRegex.TabIndex = 8;
            this.buttonClearRegex.UseVisualStyleBackColor = true;
            this.buttonClearRegex.Click += new System.EventHandler(this.buttonClearRegex_Click);
            // 
            // buttonClearTest
            // 
            this.buttonClearTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearTest.Image = global::RegexTester.Properties.Resources.delete16;
            this.buttonClearTest.Location = new System.Drawing.Point(589, 73);
            this.buttonClearTest.Name = "buttonClearTest";
            this.buttonClearTest.Size = new System.Drawing.Size(31, 31);
            this.buttonClearTest.TabIndex = 9;
            this.buttonClearTest.UseVisualStyleBackColor = true;
            this.buttonClearTest.Click += new System.EventHandler(this.buttonClearTest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Match";
            // 
            // txtMatches
            // 
            this.txtMatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatches.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatches.Location = new System.Drawing.Point(92, 163);
            this.txtMatches.Multiline = true;
            this.txtMatches.Name = "txtMatches";
            this.txtMatches.ReadOnly = true;
            this.txtMatches.Size = new System.Drawing.Size(491, 122);
            this.txtMatches.TabIndex = 10;
            // 
            // rbIgnoreCase
            // 
            this.rbIgnoreCase.AutoSize = true;
            this.rbIgnoreCase.Location = new System.Drawing.Point(153, 11);
            this.rbIgnoreCase.Name = "rbIgnoreCase";
            this.rbIgnoreCase.Size = new System.Drawing.Size(79, 17);
            this.rbIgnoreCase.TabIndex = 12;
            this.rbIgnoreCase.Tag = "";
            this.rbIgnoreCase.Text = "IgnoreCase";
            this.rbIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(96, 12);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 13;
            this.rbNone.TabStop = true;
            this.rbNone.Tag = "";
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // chkMatchIndex
            // 
            this.chkMatchIndex.AutoSize = true;
            this.chkMatchIndex.Location = new System.Drawing.Point(92, 299);
            this.chkMatchIndex.Name = "chkMatchIndex";
            this.chkMatchIndex.Size = new System.Drawing.Size(126, 17);
            this.chkMatchIndex.TabIndex = 14;
            this.chkMatchIndex.Text = "Show Matched index";
            this.chkMatchIndex.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 355);
            this.Controls.Add(this.chkMatchIndex);
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.rbIgnoreCase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatches);
            this.Controls.Add(this.buttonClearTest);
            this.Controls.Add(this.buttonClearRegex);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.textBoxRegEx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regex Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRegEx;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarMessage;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonClearRegex;
        private System.Windows.Forms.Button buttonClearTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatches;
        private System.Windows.Forms.RadioButton rbIgnoreCase;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.CheckBox chkMatchIndex;
    }
}

