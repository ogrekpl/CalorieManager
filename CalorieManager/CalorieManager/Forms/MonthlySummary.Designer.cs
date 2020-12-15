
namespace CalorieManager.Forms
{
    partial class MonthlySummary
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
            this.MonthlySummaryScore = new System.Windows.Forms.Label();
            this.MonthlySummaryActivities = new System.Windows.Forms.Label();
            this.MonthlySummaryCommentValue = new System.Windows.Forms.Label();
            this.MonthlySummaryCommentTitle = new System.Windows.Forms.Label();
            this.MonthlySummaryCalories = new System.Windows.Forms.Label();
            this.MonthlySummaryTitle = new System.Windows.Forms.Label();
            this.MonthlySummaryWeightChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MonthlySummaryScore
            // 
            this.MonthlySummaryScore.AutoSize = true;
            this.MonthlySummaryScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MonthlySummaryScore.Location = new System.Drawing.Point(257, 323);
            this.MonthlySummaryScore.Name = "MonthlySummaryScore";
            this.MonthlySummaryScore.Size = new System.Drawing.Size(635, 39);
            this.MonthlySummaryScore.TabIndex = 21;
            this.MonthlySummaryScore.Text = "Yo\'ve reached your daily score on 7 days";
            this.MonthlySummaryScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MonthlySummaryActivities
            // 
            this.MonthlySummaryActivities.AutoSize = true;
            this.MonthlySummaryActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MonthlySummaryActivities.Location = new System.Drawing.Point(70, 256);
            this.MonthlySummaryActivities.Name = "MonthlySummaryActivities";
            this.MonthlySummaryActivities.Size = new System.Drawing.Size(1014, 39);
            this.MonthlySummaryActivities.TabIndex = 20;
            this.MonthlySummaryActivities.Text = "During your actvities in following month you have burned 500 kcal ";
            this.MonthlySummaryActivities.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MonthlySummaryCommentValue
            // 
            this.MonthlySummaryCommentValue.AutoSize = true;
            this.MonthlySummaryCommentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MonthlySummaryCommentValue.Location = new System.Drawing.Point(318, 512);
            this.MonthlySummaryCommentValue.Name = "MonthlySummaryCommentValue";
            this.MonthlySummaryCommentValue.Size = new System.Drawing.Size(509, 29);
            this.MonthlySummaryCommentValue.TabIndex = 18;
            this.MonthlySummaryCommentValue.Text = "Super, you\'ve reached your daily calories goal!";
            this.MonthlySummaryCommentValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MonthlySummaryCommentTitle
            // 
            this.MonthlySummaryCommentTitle.AutoSize = true;
            this.MonthlySummaryCommentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MonthlySummaryCommentTitle.Location = new System.Drawing.Point(476, 471);
            this.MonthlySummaryCommentTitle.Name = "MonthlySummaryCommentTitle";
            this.MonthlySummaryCommentTitle.Size = new System.Drawing.Size(164, 29);
            this.MonthlySummaryCommentTitle.TabIndex = 17;
            this.MonthlySummaryCommentTitle.Text = "Our comment:";
            this.MonthlySummaryCommentTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MonthlySummaryCalories
            // 
            this.MonthlySummaryCalories.AutoSize = true;
            this.MonthlySummaryCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MonthlySummaryCalories.Location = new System.Drawing.Point(165, 188);
            this.MonthlySummaryCalories.Name = "MonthlySummaryCalories";
            this.MonthlySummaryCalories.Size = new System.Drawing.Size(826, 39);
            this.MonthlySummaryCalories.TabIndex = 16;
            this.MonthlySummaryCalories.Text = "Your monthly score is 14000 from declare 14000 kcal.";
            this.MonthlySummaryCalories.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MonthlySummaryCalories.Click += new System.EventHandler(this.WeeklySummaryCalories_Click);
            // 
            // MonthlySummaryTitle
            // 
            this.MonthlySummaryTitle.AutoSize = true;
            this.MonthlySummaryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MonthlySummaryTitle.Location = new System.Drawing.Point(85, 75);
            this.MonthlySummaryTitle.Name = "MonthlySummaryTitle";
            this.MonthlySummaryTitle.Size = new System.Drawing.Size(953, 76);
            this.MonthlySummaryTitle.TabIndex = 15;
            this.MonthlySummaryTitle.Text = "Summmary for month 12.2020 ";
            this.MonthlySummaryTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MonthlySummaryWeightChange
            // 
            this.MonthlySummaryWeightChange.AutoSize = true;
            this.MonthlySummaryWeightChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MonthlySummaryWeightChange.Location = new System.Drawing.Point(174, 390);
            this.MonthlySummaryWeightChange.Name = "MonthlySummaryWeightChange";
            this.MonthlySummaryWeightChange.Size = new System.Drawing.Size(803, 39);
            this.MonthlySummaryWeightChange.TabIndex = 22;
            this.MonthlySummaryWeightChange.Text = "Your weight has changed in follownig month for 5 kg";
            this.MonthlySummaryWeightChange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MonthlySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 624);
            this.Controls.Add(this.MonthlySummaryWeightChange);
            this.Controls.Add(this.MonthlySummaryScore);
            this.Controls.Add(this.MonthlySummaryActivities);
            this.Controls.Add(this.MonthlySummaryCommentValue);
            this.Controls.Add(this.MonthlySummaryCommentTitle);
            this.Controls.Add(this.MonthlySummaryCalories);
            this.Controls.Add(this.MonthlySummaryTitle);
            this.Name = "MonthlySummary";
            this.Text = "MonthlySummary";
            this.Load += new System.EventHandler(this.MonthlySummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MonthlySummaryScore;
        private System.Windows.Forms.Label MonthlySummaryActivities;
        private System.Windows.Forms.Label MonthlySummaryCommentValue;
        private System.Windows.Forms.Label MonthlySummaryCommentTitle;
        private System.Windows.Forms.Label MonthlySummaryCalories;
        private System.Windows.Forms.Label MonthlySummaryTitle;
        private System.Windows.Forms.Label MonthlySummaryWeightChange;
    }
}