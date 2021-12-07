
namespace CargoShipApp
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.track_motorCycle = new System.Windows.Forms.TrackBar();
            this.track_trucks = new System.Windows.Forms.TrackBar();
            this.track_cars = new System.Windows.Forms.TrackBar();
            this.track_trainTrucks = new System.Windows.Forms.TrackBar();
            this.label_CyclesCount = new System.Windows.Forms.Label();
            this.label_TrucksCount = new System.Windows.Forms.Label();
            this.label_CarsCount = new System.Windows.Forms.Label();
            this.label_TraincarCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_newShip = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Shiplevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(171, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(617, 79);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 45;
            // 
            // track_motorCycle
            // 
            this.track_motorCycle.Location = new System.Drawing.Point(53, 239);
            this.track_motorCycle.Name = "track_motorCycle";
            this.track_motorCycle.Size = new System.Drawing.Size(192, 56);
            this.track_motorCycle.TabIndex = 2;
            this.track_motorCycle.Scroll += new System.EventHandler(this.track_motorCycle_Scroll);
            // 
            // track_trucks
            // 
            this.track_trucks.Location = new System.Drawing.Point(515, 239);
            this.track_trucks.Name = "track_trucks";
            this.track_trucks.Size = new System.Drawing.Size(191, 56);
            this.track_trucks.TabIndex = 3;
            this.track_trucks.Scroll += new System.EventHandler(this.track_trucks_Scroll);
            // 
            // track_cars
            // 
            this.track_cars.Location = new System.Drawing.Point(53, 340);
            this.track_cars.Name = "track_cars";
            this.track_cars.Size = new System.Drawing.Size(192, 56);
            this.track_cars.TabIndex = 4;
            this.track_cars.Scroll += new System.EventHandler(this.track_cars_Scroll);
            // 
            // track_trainTrucks
            // 
            this.track_trainTrucks.Location = new System.Drawing.Point(498, 340);
            this.track_trainTrucks.Name = "track_trainTrucks";
            this.track_trainTrucks.Size = new System.Drawing.Size(191, 56);
            this.track_trainTrucks.TabIndex = 5;
            this.track_trainTrucks.Scroll += new System.EventHandler(this.track_trainTrucks_Scroll);
            // 
            // label_CyclesCount
            // 
            this.label_CyclesCount.AutoSize = true;
            this.label_CyclesCount.Location = new System.Drawing.Point(87, 228);
            this.label_CyclesCount.Name = "label_CyclesCount";
            this.label_CyclesCount.Size = new System.Drawing.Size(46, 17);
            this.label_CyclesCount.TabIndex = 6;
            this.label_CyclesCount.Text = "label1";
            // 
            // label_TrucksCount
            // 
            this.label_TrucksCount.AutoSize = true;
            this.label_TrucksCount.Location = new System.Drawing.Point(562, 228);
            this.label_TrucksCount.Name = "label_TrucksCount";
            this.label_TrucksCount.Size = new System.Drawing.Size(46, 17);
            this.label_TrucksCount.TabIndex = 7;
            this.label_TrucksCount.Text = "label2";
            // 
            // label_CarsCount
            // 
            this.label_CarsCount.AutoSize = true;
            this.label_CarsCount.Location = new System.Drawing.Point(87, 330);
            this.label_CarsCount.Name = "label_CarsCount";
            this.label_CarsCount.Size = new System.Drawing.Size(46, 17);
            this.label_CarsCount.TabIndex = 8;
            this.label_CarsCount.Text = "label3";
            // 
            // label_TraincarCount
            // 
            this.label_TraincarCount.AutoSize = true;
            this.label_TraincarCount.Location = new System.Drawing.Point(543, 330);
            this.label_TraincarCount.Name = "label_TraincarCount";
            this.label_TraincarCount.Size = new System.Drawing.Size(46, 17);
            this.label_TraincarCount.TabIndex = 9;
            this.label_TraincarCount.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "MotorCycles (3 units)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trucks (11 units)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cars(5 units)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Train Car(17 units)";
            // 
            // btn_newShip
            // 
            this.btn_newShip.Location = new System.Drawing.Point(90, 437);
            this.btn_newShip.Name = "btn_newShip";
            this.btn_newShip.Size = new System.Drawing.Size(138, 51);
            this.btn_newShip.TabIndex = 14;
            this.btn_newShip.Text = "New Boat";
            this.btn_newShip.UseVisualStyleBackColor = true;
            this.btn_newShip.Click += new System.EventHandler(this.btn_newShip_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CargoShipApp.Properties.Resources.cargoship1;
            this.pictureBox1.Location = new System.Drawing.Point(24, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Shiplevel
            // 
            this.label_Shiplevel.AutoSize = true;
            this.label_Shiplevel.Location = new System.Drawing.Point(181, 120);
            this.label_Shiplevel.Name = "label_Shiplevel";
            this.label_Shiplevel.Size = new System.Drawing.Size(46, 17);
            this.label_Shiplevel.TabIndex = 15;
            this.label_Shiplevel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label_Shiplevel);
            this.Controls.Add(this.btn_newShip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_TraincarCount);
            this.Controls.Add(this.label_CarsCount);
            this.Controls.Add(this.label_TrucksCount);
            this.Controls.Add(this.label_CyclesCount);
            this.Controls.Add(this.track_trainTrucks);
            this.Controls.Add(this.track_cars);
            this.Controls.Add(this.track_trucks);
            this.Controls.Add(this.track_motorCycle);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Fill the boat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar track_motorCycle;
        private System.Windows.Forms.TrackBar track_trucks;
        private System.Windows.Forms.TrackBar track_cars;
        private System.Windows.Forms.TrackBar track_trainTrucks;
        private System.Windows.Forms.Label label_CyclesCount;
        private System.Windows.Forms.Label label_TrucksCount;
        private System.Windows.Forms.Label label_CarsCount;
        private System.Windows.Forms.Label label_TraincarCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_newShip;
        private System.Windows.Forms.Label label_Shiplevel;
    }
}