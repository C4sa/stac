namespace stac
{
    partial class Stac
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button helpBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stac));
            this.startedProgsList = new System.Windows.Forms.ListView();
            this.NameHeader = new System.Windows.Forms.ColumnHeader();
            this.PathHeader = new System.Windows.Forms.ColumnHeader();
            this.removeBtn = new System.Windows.Forms.Button();
            this.titleTxt = new System.Windows.Forms.Label();
            this.expBtn = new System.Windows.Forms.Button();
            this.openProfileBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuLogo = new System.Windows.Forms.PictureBox();
            this.stacTxt = new System.Windows.Forms.Label();
            this.openExeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            helpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // helpBtn
            // 
            helpBtn.BackColor = System.Drawing.Color.Transparent;
            helpBtn.FlatAppearance.BorderSize = 0;
            helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            helpBtn.Image = global::stac.Properties.Resources.info37;
            helpBtn.Location = new System.Drawing.Point(400, 32);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new System.Drawing.Size(37, 37);
            helpBtn.TabIndex = 9;
            this.tooltip.SetToolTip(helpBtn, "Info\r\n\r\nA brief guide to Stac and basic\r\nexplanation of everything\r\nincluded.");
            helpBtn.UseMnemonic = false;
            helpBtn.UseVisualStyleBackColor = false;
            helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // startedProgsList
            // 
            this.startedProgsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.startedProgsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startedProgsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.PathHeader});
            this.startedProgsList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startedProgsList.ForeColor = System.Drawing.Color.White;
            this.startedProgsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.startedProgsList.Location = new System.Drawing.Point(12, 76);
            this.startedProgsList.Name = "startedProgsList";
            this.startedProgsList.Size = new System.Drawing.Size(533, 152);
            this.startedProgsList.TabIndex = 3;
            this.startedProgsList.UseCompatibleStateImageBehavior = false;
            this.startedProgsList.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 200;
            // 
            // PathHeader
            // 
            this.PathHeader.Text = "Path";
            this.PathHeader.Width = 329;
            // 
            // removeBtn
            // 
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Image = global::stac.Properties.Resources.remove37;
            this.removeBtn.Location = new System.Drawing.Point(55, 32);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(37, 37);
            this.removeBtn.TabIndex = 4;
            this.tooltip.SetToolTip(this.removeBtn, "Removes the selected item\r\nfrom the list. It will only apply\r\nto the profile file" +
        " if you save it\r\nusing the Export button.");
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Cursor = System.Windows.Forms.Cursors.Help;
            this.titleTxt.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.titleTxt.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.titleTxt.Location = new System.Drawing.Point(480, 28);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(65, 45);
            this.titleTxt.TabIndex = 5;
            this.titleTxt.Text = "1.1";
            this.titleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.titleTxt, resources.GetString("titleTxt.ToolTip"));
            // 
            // expBtn
            // 
            this.expBtn.FlatAppearance.BorderSize = 0;
            this.expBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expBtn.Image = global::stac.Properties.Resources.export37;
            this.expBtn.Location = new System.Drawing.Point(138, 32);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(37, 37);
            this.expBtn.TabIndex = 6;
            this.tooltip.SetToolTip(this.expBtn, "Export\r\n\r\nExports/saves the content of the\r\nlist below into a .stac profile file." +
        "\r\nMake sure to export your profile\r\nbefore you close Stac!");
            this.expBtn.UseVisualStyleBackColor = true;
            this.expBtn.Click += new System.EventHandler(this.expBtn_Click);
            // 
            // openProfileBtn
            // 
            this.openProfileBtn.FlatAppearance.BorderSize = 0;
            this.openProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProfileBtn.Image = global::stac.Properties.Resources.import37;
            this.openProfileBtn.Location = new System.Drawing.Point(183, 32);
            this.openProfileBtn.Name = "openProfileBtn";
            this.openProfileBtn.Size = new System.Drawing.Size(37, 37);
            this.openProfileBtn.TabIndex = 7;
            this.tooltip.SetToolTip(this.openProfileBtn, "Import\r\n\r\nBrowse for a Stac profile file\r\n(.stac) and add its contents\r\nto the li" +
        "st below.");
            this.openProfileBtn.UseVisualStyleBackColor = true;
            this.openProfileBtn.Click += new System.EventHandler(this.openProfileBtn_Click);
            // 
            // runBtn
            // 
            this.runBtn.FlatAppearance.BorderSize = 0;
            this.runBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runBtn.Image = global::stac.Properties.Resources.run37;
            this.runBtn.Location = new System.Drawing.Point(274, 32);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(37, 37);
            this.runBtn.TabIndex = 8;
            this.tooltip.SetToolTip(this.runBtn, "Run\r\n\r\nStarts all the programs in the list below.\r\nThis button is good if you wan" +
        "t to see\r\nif all your desired programs can start\r\nfrom Stac.");
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // contextMenuLogo
            // 
            this.contextMenuLogo.Image = global::stac.Properties.Resources.icon;
            this.contextMenuLogo.Location = new System.Drawing.Point(12, 6);
            this.contextMenuLogo.Name = "contextMenuLogo";
            this.contextMenuLogo.Size = new System.Drawing.Size(20, 20);
            this.contextMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contextMenuLogo.TabIndex = 10;
            this.contextMenuLogo.TabStop = false;
            this.tooltip.SetToolTip(this.contextMenuLogo, "Hi there, I\'m Stac!");
            // 
            // stacTxt
            // 
            this.stacTxt.AutoSize = true;
            this.stacTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.stacTxt.Location = new System.Drawing.Point(38, 9);
            this.stacTxt.Name = "stacTxt";
            this.stacTxt.Size = new System.Drawing.Size(34, 15);
            this.stacTxt.TabIndex = 11;
            this.stacTxt.Text = "STAC";
            // 
            // openExeBtn
            // 
            this.openExeBtn.FlatAppearance.BorderSize = 0;
            this.openExeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openExeBtn.Image = global::stac.Properties.Resources.add37;
            this.openExeBtn.Location = new System.Drawing.Point(12, 32);
            this.openExeBtn.Name = "openExeBtn";
            this.openExeBtn.Size = new System.Drawing.Size(37, 37);
            this.openExeBtn.TabIndex = 12;
            this.openExeBtn.UseMnemonic = false;
            this.openExeBtn.UseVisualStyleBackColor = false;
            this.openExeBtn.Click += new System.EventHandler(this.openExeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.closeBtn.Location = new System.Drawing.Point(513, -4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 32);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.Text = "×";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minimizeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeBtn.Location = new System.Drawing.Point(480, -4);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(32, 32);
            this.minimizeBtn.TabIndex = 14;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // Stac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(557, 240);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.openExeBtn);
            this.Controls.Add(this.stacTxt);
            this.Controls.Add(this.contextMenuLogo);
            this.Controls.Add(helpBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.openProfileBtn);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.startedProgsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 1000);
            this.MaximizeBox = false;
            this.Name = "Stac";
            this.Text = "Stac";
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView startedProgsList;
        private ColumnHeader NameHeader;
        private ColumnHeader PathHeader;
        private Button removeBtn;
        private Label titleTxt;
        private Button expBtn;
        private Button openProfileBtn;
        private Button runBtn;
        private Button helpBtn;
        private ToolTip tooltip;
        private PictureBox contextMenuLogo;
        private Label stacTxt;
        private Button openExeBtn;
        private Button closeBtn;
        private Button minimizeBtn;
    }
}