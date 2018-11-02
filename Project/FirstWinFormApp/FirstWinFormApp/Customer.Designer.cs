namespace FirstWinFormApp
{
    partial class Customer
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.countryNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountrySaveButton = new System.Windows.Forms.Button();
            this.CitySaveButton = new System.Windows.Forms.Button();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countryNameCTextBoxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(232, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(209, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(296, 65);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // countryNameTextBox
            // 
            this.countryNameTextBox.Location = new System.Drawing.Point(144, 136);
            this.countryNameTextBox.Name = "countryNameTextBox";
            this.countryNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.countryNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Country Name";
            // 
            // CountrySaveButton
            // 
            this.CountrySaveButton.Location = new System.Drawing.Point(177, 162);
            this.CountrySaveButton.Name = "CountrySaveButton";
            this.CountrySaveButton.Size = new System.Drawing.Size(121, 23);
            this.CountrySaveButton.TabIndex = 1;
            this.CountrySaveButton.Text = "Save Country";
            this.CountrySaveButton.UseVisualStyleBackColor = true;
            this.CountrySaveButton.Click += new System.EventHandler(this.CountrySaveButton_Click);
            // 
            // CitySaveButton
            // 
            this.CitySaveButton.Location = new System.Drawing.Point(707, 281);
            this.CitySaveButton.Name = "CitySaveButton";
            this.CitySaveButton.Size = new System.Drawing.Size(121, 23);
            this.CitySaveButton.TabIndex = 1;
            this.CitySaveButton.Text = "Save City";
            this.CitySaveButton.UseVisualStyleBackColor = true;
            this.CitySaveButton.Click += new System.EventHandler(this.CitySaveButton_Click);
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(674, 255);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.cityNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "City";
            // 
            // countryNameCTextBoxt
            // 
            this.countryNameCTextBoxt.Location = new System.Drawing.Point(674, 220);
            this.countryNameCTextBoxt.Name = "countryNameCTextBoxt";
            this.countryNameCTextBoxt.Size = new System.Drawing.Size(188, 20);
            this.countryNameCTextBoxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Country";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryNameCTextBoxt);
            this.Controls.Add(this.cityNameTextBox);
            this.Controls.Add(this.CitySaveButton);
            this.Controls.Add(this.countryNameTextBox);
            this.Controls.Add(this.CountrySaveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox countryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CountrySaveButton;
        private System.Windows.Forms.Button CitySaveButton;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryNameCTextBoxt;
        private System.Windows.Forms.Label label3;
    }
}