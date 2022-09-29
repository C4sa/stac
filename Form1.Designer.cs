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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stac));
            this.openExeBtn = new System.Windows.Forms.Button();
            this.startedProgsList = new System.Windows.Forms.ListView();
            this.NameHeader = new System.Windows.Forms.ColumnHeader();
            this.PathHeader = new System.Windows.Forms.ColumnHeader();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(341, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Stac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.startedProgsList);
            this.Controls.Add(this.openExeBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}