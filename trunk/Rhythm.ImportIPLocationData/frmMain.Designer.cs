namespace Rhythm.ImportIPLocationData
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnImport = new System.Windows.Forms.Button();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.richInstructions = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBlocks = new System.Windows.Forms.TextBox();
            this.btnPickBlocks = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnPickLocation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.progressImport = new System.Windows.Forms.ProgressBar();
            this.tableMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnImport.AutoSize = true;
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.Location = new System.Drawing.Point(709, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(46, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.txtConnection, 1, 3);
            this.tableMain.Controls.Add(this.richInstructions, 0, 0);
            this.tableMain.Controls.Add(this.label1, 0, 1);
            this.tableMain.Controls.Add(this.label2, 0, 2);
            this.tableMain.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableMain.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableMain.Controls.Add(this.label3, 0, 3);
            this.tableMain.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 5;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.Size = new System.Drawing.Size(764, 362);
            this.tableMain.TabIndex = 1;
            // 
            // txtConnection
            // 
            this.txtConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnection.Location = new System.Drawing.Point(100, 304);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(661, 20);
            this.txtConnection.TabIndex = 6;
            this.txtConnection.Text = "server=some-server;database=some-database;user id=some-user;password=some-passwor" +
    "d";
            // 
            // richInstructions
            // 
            this.tableMain.SetColumnSpan(this.richInstructions, 2);
            this.richInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richInstructions.Location = new System.Drawing.Point(3, 3);
            this.richInstructions.Name = "richInstructions";
            this.richInstructions.ReadOnly = true;
            this.richInstructions.Size = new System.Drawing.Size(758, 225);
            this.richInstructions.TabIndex = 0;
            this.richInstructions.Text = resources.GetString("richInstructions.Text");
            this.richInstructions.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richInstructions_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blocks CSV";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location CSV";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.txtBlocks, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPickBlocks, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(100, 234);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(661, 29);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // txtBlocks
            // 
            this.txtBlocks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBlocks.Location = new System.Drawing.Point(3, 4);
            this.txtBlocks.Name = "txtBlocks";
            this.txtBlocks.Size = new System.Drawing.Size(623, 20);
            this.txtBlocks.TabIndex = 0;
            // 
            // btnPickBlocks
            // 
            this.btnPickBlocks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickBlocks.AutoSize = true;
            this.btnPickBlocks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPickBlocks.Location = new System.Drawing.Point(632, 3);
            this.btnPickBlocks.Name = "btnPickBlocks";
            this.btnPickBlocks.Size = new System.Drawing.Size(26, 23);
            this.btnPickBlocks.TabIndex = 1;
            this.btnPickBlocks.Text = "...";
            this.btnPickBlocks.UseVisualStyleBackColor = true;
            this.btnPickBlocks.Click += new System.EventHandler(this.btnPickBlocks_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.txtLocation, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPickLocation, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(100, 269);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(661, 29);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Location = new System.Drawing.Point(3, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(623, 20);
            this.txtLocation.TabIndex = 0;
            // 
            // btnPickLocation
            // 
            this.btnPickLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickLocation.AutoSize = true;
            this.btnPickLocation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPickLocation.Location = new System.Drawing.Point(632, 3);
            this.btnPickLocation.Name = "btnPickLocation";
            this.btnPickLocation.Size = new System.Drawing.Size(26, 23);
            this.btnPickLocation.TabIndex = 1;
            this.btnPickLocation.Text = "...";
            this.btnPickLocation.UseVisualStyleBackColor = true;
            this.btnPickLocation.Click += new System.EventHandler(this.btnPickLocation_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Connection String";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableMain.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.btnImport, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.progressImport, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 330);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(758, 29);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // progressImport
            // 
            this.progressImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressImport.Location = new System.Drawing.Point(3, 3);
            this.progressImport.MarqueeAnimationSpeed = 300;
            this.progressImport.Maximum = 1000;
            this.progressImport.Name = "progressImport";
            this.progressImport.Size = new System.Drawing.Size(700, 23);
            this.progressImport.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressImport.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 362);
            this.Controls.Add(this.tableMain);
            this.Name = "frmMain";
            this.Text = "Import IP Location Data";
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.TableLayoutPanel tableMain;
		private System.Windows.Forms.RichTextBox richInstructions;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TextBox txtBlocks;
		private System.Windows.Forms.Button btnPickBlocks;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TextBox txtLocation;
		private System.Windows.Forms.Button btnPickLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ProgressBar progressImport;
    }
}

