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
            System.Windows.Forms.Button helpBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stac));
            this.openExeBtn = new System.Windows.Forms.Button();
            this.startedProgsList = new System.Windows.Forms.ListView();
            this.NameHeader = new System.Windows.Forms.ColumnHeader();
            this.PathHeader = new System.Windows.Forms.ColumnHeader();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.expBtn = new System.Windows.Forms.Button();
            this.openProfileBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            helpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openExeBtn
            // 
            this.openExeBtn.AutoSize = true;
            this.openExeBtn.Location = new System.Drawing.Point(12, 12);
            this.openExeBtn.Name = "openExeBtn";
            this.openExeBtn.Size = new System.Drawing.Size(39, 37);
            this.openExeBtn.TabIndex = 0;
            this.openExeBtn.Text = "Add";
            this.openExeBtn.UseVisualStyleBackColor = true;
            this.openExeBtn.Click += new System.EventHandler(this.openExeBtn_Click);
            // 
            // startedProgsList
            // 
            this.startedProgsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.PathHeader});
            this.startedProgsList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startedProgsList.Location = new System.Drawing.Point(12, 55);
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
            this.removeBtn.Location = new System.Drawing.Point(57, 12);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(39, 37);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Rem";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(447, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "STAC\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // expBtn
            // 
            this.expBtn.Location = new System.Drawing.Point(140, 12);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(39, 37);
            this.expBtn.TabIndex = 6;
            this.expBtn.Text = "Exp";
            this.expBtn.UseVisualStyleBackColor = true;
            this.expBtn.Click += new System.EventHandler(this.expBtn_Click);
            // 
            // openProfileBtn
            // 
            this.openProfileBtn.Location = new System.Drawing.Point(185, 12);
            this.openProfileBtn.Name = "openProfileBtn";
            this.openProfileBtn.Size = new System.Drawing.Size(39, 37);
            this.openProfileBtn.TabIndex = 7;
            this.openProfileBtn.Text = "Imp";
            this.openProfileBtn.UseVisualStyleBackColor = true;
            this.openProfileBtn.Click += new System.EventHandler(this.openProfileBtn_Click);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(276, 12);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(39, 37);
            this.runBtn.TabIndex = 8;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // helpBtn
            // 
            helpBtn.Location = new System.Drawing.Point(402, 12);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new System.Drawing.Size(39, 37);
            helpBtn.TabIndex = 9;
            helpBtn.Text = "Info";
            helpBtn.UseVisualStyleBackColor = true;
            helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // Stac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(557, 223);
            this.Controls.Add(helpBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.openProfileBtn);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.startedProgsList);
            this.Controls.Add(this.openExeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Stac";
            this.Text = "Stac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button openExeBtn;
        private ListView startedProgsList;
        private ColumnHeader NameHeader;
        private ColumnHeader PathHeader;
        private Button removeBtn;
        private Label label1;
        private Button expBtn;
        private Button openProfileBtn;
        private Button runBtn;
        private Button helpBtn;
    }
}