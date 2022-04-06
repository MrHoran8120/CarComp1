namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.carComp1 = new WindowsFormsApp1.CarComp();
            this.carComp2 = new WindowsFormsApp1.CarComp();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.populateCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExtraCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Cars";
            // 
            // carComp1
            // 
            this.carComp1.Location = new System.Drawing.Point(31, 105);
            this.carComp1.Name = "carComp1";
            this.carComp1.Size = new System.Drawing.Size(227, 86);
            this.carComp1.TabIndex = 1;
            // 
            // carComp2
            // 
            this.carComp2.Location = new System.Drawing.Point(31, 197);
            this.carComp2.Name = "carComp2";
            this.carComp2.Size = new System.Drawing.Size(227, 80);
            this.carComp2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carStuffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carStuffToolStripMenuItem
            // 
            this.carStuffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.populateCarsToolStripMenuItem,
            this.addExtraCarToolStripMenuItem,
            this.clearAllCarsToolStripMenuItem});
            this.carStuffToolStripMenuItem.Name = "carStuffToolStripMenuItem";
            this.carStuffToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.carStuffToolStripMenuItem.Text = "Car stuff";
            // 
            // populateCarsToolStripMenuItem
            // 
            this.populateCarsToolStripMenuItem.Name = "populateCarsToolStripMenuItem";
            this.populateCarsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.populateCarsToolStripMenuItem.Text = "Populate Cars";
            this.populateCarsToolStripMenuItem.Click += new System.EventHandler(this.populateCarsToolStripMenuItem_Click);
            // 
            // addExtraCarToolStripMenuItem
            // 
            this.addExtraCarToolStripMenuItem.Name = "addExtraCarToolStripMenuItem";
            this.addExtraCarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addExtraCarToolStripMenuItem.Text = "Add Extra Car";
            this.addExtraCarToolStripMenuItem.Click += new System.EventHandler(this.addExtraCarToolStripMenuItem_Click);
            // 
            // clearAllCarsToolStripMenuItem
            // 
            this.clearAllCarsToolStripMenuItem.Name = "clearAllCarsToolStripMenuItem";
            this.clearAllCarsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearAllCarsToolStripMenuItem.Text = "Clear All Cars";
            this.clearAllCarsToolStripMenuItem.Click += new System.EventHandler(this.clearAllCarsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 526);
            this.Controls.Add(this.carComp2);
            this.Controls.Add(this.carComp1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CarComp carComp1;
        private CarComp carComp2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carStuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem populateCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExtraCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllCarsToolStripMenuItem;
    }
}

