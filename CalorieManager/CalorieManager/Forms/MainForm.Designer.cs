using System.Windows.Forms;

namespace CalorieManager.Forms
{
	partial class MainForm
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeCaloriesGoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeWeightGoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newMealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.weeklyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.monthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelChildForm = new System.Windows.Forms.Panel();
			this.panelChild = new System.Windows.Forms.Panel();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.addToolStripMenuItem,
            this.summaryToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1184, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// profileToolStripMenuItem
			// 
			this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileToolStripMenuItem,
            this.logoutToolStripMenuItem});
			this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
			this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.profileToolStripMenuItem.Text = "Profile";
			this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
			// 
			// editProfileToolStripMenuItem
			// 
			this.editProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCaloriesGoalToolStripMenuItem,
            this.changeWeightGoalToolStripMenuItem});
			this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
			this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.editProfileToolStripMenuItem.Text = "Edit Profile";
			// 
			// changeCaloriesGoalToolStripMenuItem
			// 
			this.changeCaloriesGoalToolStripMenuItem.Name = "changeCaloriesGoalToolStripMenuItem";
			this.changeCaloriesGoalToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.changeCaloriesGoalToolStripMenuItem.Text = "Change Calories Goal";
			this.changeCaloriesGoalToolStripMenuItem.Click += new System.EventHandler(this.changeCaloriesGoalToolStripMenuItem_Click);
			// 
			// changeWeightGoalToolStripMenuItem
			// 
			this.changeWeightGoalToolStripMenuItem.Name = "changeWeightGoalToolStripMenuItem";
			this.changeWeightGoalToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.changeWeightGoalToolStripMenuItem.Text = "Change Weight Goal";
			this.changeWeightGoalToolStripMenuItem.Click += new System.EventHandler(this.changeWeightGoalToolStripMenuItem_Click);
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.logoutToolStripMenuItem.Text = "Logout";
			this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMealToolStripMenuItem,
            this.newActivityToolStripMenuItem});
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.addToolStripMenuItem.Text = "New";
			// 
			// newMealToolStripMenuItem
			// 
			this.newMealToolStripMenuItem.Name = "newMealToolStripMenuItem";
			this.newMealToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.newMealToolStripMenuItem.Text = "New meal";
			this.newMealToolStripMenuItem.Click += new System.EventHandler(this.newMealToolStripMenuItem_Click);
			// 
			// newActivityToolStripMenuItem
			// 
			this.newActivityToolStripMenuItem.Name = "newActivityToolStripMenuItem";
			this.newActivityToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.newActivityToolStripMenuItem.Text = "New activity";
			this.newActivityToolStripMenuItem.Click += new System.EventHandler(this.newActivityToolStripMenuItem_Click);
			// 
			// summaryToolStripMenuItem
			// 
			this.summaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyToolStripMenuItem,
            this.weeklyToolStripMenuItem,
            this.monthlyToolStripMenuItem});
			this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
			this.summaryToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.summaryToolStripMenuItem.Text = "Summary";
			// 
			// dailyToolStripMenuItem
			// 
			this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
			this.dailyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.dailyToolStripMenuItem.Text = "Daily";
			this.dailyToolStripMenuItem.Click += new System.EventHandler(this.dailyToolStripMenuItem_Click);
			// 
			// weeklyToolStripMenuItem
			// 
			this.weeklyToolStripMenuItem.Name = "weeklyToolStripMenuItem";
			this.weeklyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.weeklyToolStripMenuItem.Text = "Weekly";
			// 
			// monthlyToolStripMenuItem
			// 
			this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
			this.monthlyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.monthlyToolStripMenuItem.Text = "Monthly";
			// 
			// panelChildForm
			// 
			this.panelChildForm.Location = new System.Drawing.Point(0, 0);
			this.panelChildForm.Name = "panelChildForm";
			this.panelChildForm.Size = new System.Drawing.Size(200, 100);
			this.panelChildForm.TabIndex = 0;
			// 
			// panelChild
			// 
			this.panelChild.Location = new System.Drawing.Point(12, 27);
			this.panelChild.Name = "panelChild";
			this.panelChild.Size = new System.Drawing.Size(1160, 663);
			this.panelChild.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 702);
			this.Controls.Add(this.panelChild);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeCaloriesGoalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeWeightGoalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newMealToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newActivityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem weeklyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem monthlyToolStripMenuItem;
		private System.Windows.Forms.Panel panelChildForm;
        private Panel panelChild;
    }
}