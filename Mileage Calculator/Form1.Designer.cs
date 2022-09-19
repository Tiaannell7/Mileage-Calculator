
namespace Mileage
{
    partial class MEC_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MEC_Form));
            this.titleLabel = new System.Windows.Forms.Label();
            this.line1Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Miles_DrivenTextBox = new System.Windows.Forms.TextBox();
            this.Gallons_UsedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EfficiencyTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(225, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(259, 28);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Mileage Efficienty Calculator";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // line1Label
            // 
            this.line1Label.AutoSize = true;
            this.line1Label.Location = new System.Drawing.Point(40, 53);
            this.line1Label.Name = "line1Label";
            this.line1Label.Size = new System.Drawing.Size(617, 15);
            this.line1Label.TabIndex = 1;
            this.line1Label.Text = "_________________________________________________________________________________" +
    "_________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(159, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gallons of gas used:";
            // 
            // Miles_DrivenTextBox
            // 
            this.Miles_DrivenTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Miles_DrivenTextBox.Location = new System.Drawing.Point(347, 99);
            this.Miles_DrivenTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Miles_DrivenTextBox.Name = "Miles_DrivenTextBox";
            this.Miles_DrivenTextBox.Size = new System.Drawing.Size(294, 25);
            this.Miles_DrivenTextBox.TabIndex = 4;
            this.Miles_DrivenTextBox.Text = "0";
            // 
            // Gallons_UsedTextBox
            // 
            this.Gallons_UsedTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gallons_UsedTextBox.Location = new System.Drawing.Point(347, 150);
            this.Gallons_UsedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gallons_UsedTextBox.Name = "Gallons_UsedTextBox";
            this.Gallons_UsedTextBox.Size = new System.Drawing.Size(294, 25);
            this.Gallons_UsedTextBox.TabIndex = 5;
            this.Gallons_UsedTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Miles driven:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(118, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Efficiency (Miles / Gallon): ";
            // 
            // EfficiencyTextBox
            // 
            this.EfficiencyTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EfficiencyTextBox.Location = new System.Drawing.Point(347, 232);
            this.EfficiencyTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EfficiencyTextBox.Name = "EfficiencyTextBox";
            this.EfficiencyTextBox.ReadOnly = true;
            this.EfficiencyTextBox.Size = new System.Drawing.Size(294, 25);
            this.EfficiencyTextBox.TabIndex = 9;
            this.EfficiencyTextBox.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.LightGray;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(347, 283);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(96, 28);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(617, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "_________________________________________________________________________________" +
    "_________________________________________";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(644, 356);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(96, 26);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MEC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 391);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.EfficiencyTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gallons_UsedTextBox);
            this.Controls.Add(this.Miles_DrivenTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.line1Label);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MEC_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Mileage Efficieny Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label line1Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Miles_DrivenTextBox;
        private System.Windows.Forms.TextBox Gallons_UsedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EfficiencyTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitButton;
    }
}

