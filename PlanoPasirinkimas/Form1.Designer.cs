
namespace PlanoPasirinkimas
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
            this.selectPlan_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataCapacityUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesCapacityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.SMSCapacityUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.priceUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.unlimitedDataChckBox = new System.Windows.Forms.CheckBox();
            this.unlimitedMinutesChckBox = new System.Windows.Forms.CheckBox();
            this.unlimitedSMSChckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCapacityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesCapacityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMSCapacityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectPlan_btn
            // 
            this.selectPlan_btn.Location = new System.Drawing.Point(6, 21);
            this.selectPlan_btn.Name = "selectPlan_btn";
            this.selectPlan_btn.Size = new System.Drawing.Size(149, 29);
            this.selectPlan_btn.TabIndex = 0;
            this.selectPlan_btn.Text = "Įkelti sąrašą";
            this.selectPlan_btn.UseVisualStyleBackColor = true;
            this.selectPlan_btn.Click += new System.EventHandler(this.selectPlan_btn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(602, 236);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Operatorius";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Duomenys GB";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pokalbių minutės";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SMS kiekis";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kaina";
            this.columnHeader5.Width = 50;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectPlan_btn);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 299);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mokėjimo planai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Įveskite pageidaujamą duomenų kiekį:";
            // 
            // dataCapacityUpDown
            // 
            this.dataCapacityUpDown.Location = new System.Drawing.Point(263, 328);
            this.dataCapacityUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.dataCapacityUpDown.Name = "dataCapacityUpDown";
            this.dataCapacityUpDown.Size = new System.Drawing.Size(120, 22);
            this.dataCapacityUpDown.TabIndex = 4;
            // 
            // minutesCapacityUpDown
            // 
            this.minutesCapacityUpDown.Location = new System.Drawing.Point(263, 364);
            this.minutesCapacityUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minutesCapacityUpDown.Name = "minutesCapacityUpDown";
            this.minutesCapacityUpDown.Size = new System.Drawing.Size(120, 22);
            this.minutesCapacityUpDown.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Įveskite pageidaujamą minučių kiekį:";
            // 
            // SMSCapacityUpDown
            // 
            this.SMSCapacityUpDown.Location = new System.Drawing.Point(263, 405);
            this.SMSCapacityUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SMSCapacityUpDown.Name = "SMSCapacityUpDown";
            this.SMSCapacityUpDown.Size = new System.Drawing.Size(120, 22);
            this.SMSCapacityUpDown.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Įveskite pageidaujamą SMS kiekį:";
            // 
            // priceUpDown
            // 
            this.priceUpDown.Location = new System.Drawing.Point(263, 446);
            this.priceUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.priceUpDown.Name = "priceUpDown";
            this.priceUpDown.Size = new System.Drawing.Size(120, 22);
            this.priceUpDown.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Įveskite pageidaujamą plano kainą:";
            // 
            // calculate_btn
            // 
            this.calculate_btn.Location = new System.Drawing.Point(399, 439);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(227, 29);
            this.calculate_btn.TabIndex = 11;
            this.calculate_btn.Text = "Skaičiuoti";
            this.calculate_btn.UseVisualStyleBackColor = true;
            // 
            // unlimitedDataChckBox
            // 
            this.unlimitedDataChckBox.AutoSize = true;
            this.unlimitedDataChckBox.Location = new System.Drawing.Point(399, 330);
            this.unlimitedDataChckBox.Name = "unlimitedDataChckBox";
            this.unlimitedDataChckBox.Size = new System.Drawing.Size(87, 21);
            this.unlimitedDataChckBox.TabIndex = 12;
            this.unlimitedDataChckBox.Text = "Neribotai";
            this.unlimitedDataChckBox.UseVisualStyleBackColor = true;
            // 
            // unlimitedMinutesChckBox
            // 
            this.unlimitedMinutesChckBox.AutoSize = true;
            this.unlimitedMinutesChckBox.Location = new System.Drawing.Point(399, 365);
            this.unlimitedMinutesChckBox.Name = "unlimitedMinutesChckBox";
            this.unlimitedMinutesChckBox.Size = new System.Drawing.Size(87, 21);
            this.unlimitedMinutesChckBox.TabIndex = 13;
            this.unlimitedMinutesChckBox.Text = "Neribotai";
            this.unlimitedMinutesChckBox.UseVisualStyleBackColor = true;
            // 
            // unlimitedSMSChckBox
            // 
            this.unlimitedSMSChckBox.AutoSize = true;
            this.unlimitedSMSChckBox.Location = new System.Drawing.Point(399, 406);
            this.unlimitedSMSChckBox.Name = "unlimitedSMSChckBox";
            this.unlimitedSMSChckBox.Size = new System.Drawing.Size(87, 21);
            this.unlimitedSMSChckBox.TabIndex = 14;
            this.unlimitedSMSChckBox.Text = "Neribotai";
            this.unlimitedSMSChckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Location = new System.Drawing.Point(632, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 299);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezultatai";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 57);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(681, 236);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Operatorius";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Duomenys GB";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Pokalbių minutės";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "SMS kiekis";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Kaina";
            this.columnHeader10.Width = 50;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Reitingas";
            this.columnHeader11.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.unlimitedSMSChckBox);
            this.Controls.Add(this.unlimitedMinutesChckBox);
            this.Controls.Add(this.unlimitedDataChckBox);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.priceUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SMSCapacityUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minutesCapacityUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataCapacityUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCapacityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesCapacityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMSCapacityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectPlan_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown dataCapacityUpDown;
        private System.Windows.Forms.NumericUpDown minutesCapacityUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SMSCapacityUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown priceUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.CheckBox unlimitedDataChckBox;
        private System.Windows.Forms.CheckBox unlimitedMinutesChckBox;
        private System.Windows.Forms.CheckBox unlimitedSMSChckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}

