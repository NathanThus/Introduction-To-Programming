namespace Introduction_To_Programming
{
    partial class ParkingApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkingApplication));
            this.NewVehicles_ListBox = new System.Windows.Forms.ListBox();
            this.Receipt_Label = new System.Windows.Forms.Label();
            this.Car_Button = new System.Windows.Forms.Button();
            this.Car_PictureBox = new System.Windows.Forms.PictureBox();
            this.TotalPrice_Label = new System.Windows.Forms.Label();
            this.TotalPrice_TextBox = new System.Windows.Forms.TextBox();
            this.Clear_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Car_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NewVehicles_ListBox
            // 
            this.NewVehicles_ListBox.FormattingEnabled = true;
            this.NewVehicles_ListBox.ItemHeight = 17;
            this.NewVehicles_ListBox.Location = new System.Drawing.Point(656, 33);
            this.NewVehicles_ListBox.Name = "NewVehicles_ListBox";
            this.NewVehicles_ListBox.Size = new System.Drawing.Size(132, 361);
            this.NewVehicles_ListBox.TabIndex = 0;
            // 
            // Receipt_Label
            // 
            this.Receipt_Label.AutoSize = true;
            this.Receipt_Label.Location = new System.Drawing.Point(656, 13);
            this.Receipt_Label.Name = "Receipt_Label";
            this.Receipt_Label.Size = new System.Drawing.Size(87, 17);
            this.Receipt_Label.TabIndex = 1;
            this.Receipt_Label.Text = "New Vehicles:";
            // 
            // Car_Button
            // 
            this.Car_Button.Location = new System.Drawing.Point(146, 71);
            this.Car_Button.Name = "Car_Button";
            this.Car_Button.Size = new System.Drawing.Size(83, 25);
            this.Car_Button.TabIndex = 2;
            this.Car_Button.Text = "Car";
            this.Car_Button.UseVisualStyleBackColor = true;
            this.Car_Button.Click += new System.EventHandler(this.Car_Button_Click);
            // 
            // Car_PictureBox
            // 
            this.Car_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Car_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Car_PictureBox.Image")));
            this.Car_PictureBox.InitialImage = null;
            this.Car_PictureBox.Location = new System.Drawing.Point(12, 15);
            this.Car_PictureBox.Name = "Car_PictureBox";
            this.Car_PictureBox.Size = new System.Drawing.Size(128, 128);
            this.Car_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car_PictureBox.TabIndex = 3;
            this.Car_PictureBox.TabStop = false;
            // 
            // TotalPrice_Label
            // 
            this.TotalPrice_Label.AutoSize = true;
            this.TotalPrice_Label.Location = new System.Drawing.Point(611, 416);
            this.TotalPrice_Label.Name = "TotalPrice_Label";
            this.TotalPrice_Label.Size = new System.Drawing.Size(39, 17);
            this.TotalPrice_Label.TabIndex = 4;
            this.TotalPrice_Label.Text = "Total:";
            // 
            // TotalPrice_TextBox
            // 
            this.TotalPrice_TextBox.Location = new System.Drawing.Point(656, 413);
            this.TotalPrice_TextBox.Name = "TotalPrice_TextBox";
            this.TotalPrice_TextBox.ReadOnly = true;
            this.TotalPrice_TextBox.Size = new System.Drawing.Size(132, 25);
            this.TotalPrice_TextBox.TabIndex = 5;
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(567, 369);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(83, 25);
            this.Clear_Button.TabIndex = 6;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // ParkingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.TotalPrice_TextBox);
            this.Controls.Add(this.TotalPrice_Label);
            this.Controls.Add(this.Car_PictureBox);
            this.Controls.Add(this.Car_Button);
            this.Controls.Add(this.Receipt_Label);
            this.Controls.Add(this.NewVehicles_ListBox);
            this.Name = "ParkingApplication";
            this.Text = "Parking App";
            ((System.ComponentModel.ISupportInitialize)(this.Car_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox NewVehicles_ListBox;
        private Label Receipt_Label;
        private Button Car_Button;
        private PictureBox Car_PictureBox;
        private Label TotalPrice_Label;
        private TextBox TotalPrice_TextBox;
        private Button Clear_Button;
    }
}