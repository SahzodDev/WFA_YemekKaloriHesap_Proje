﻿namespace YemekKalori.UI.Properties
{
    partial class FrmProfil
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfil));
            lnkLblSifreDegistir = new LinkLabel();
            label1 = new Label();
            lblAdSoyad = new Label();
            txtBoxGoalType = new TextBox();
            txtBoxDietType = new TextBox();
            txtBoxBoy = new TextBox();
            txtBoxKilo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblHedefKcal = new Label();
            lblKalanKcal = new Label();
            chartFavoriBesin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lLabelGrafikler = new LinkLabel();
            label4 = new Label();
            lblEnCokTuketilenYiyecek = new Label();
            label9 = new Label();
            lblBmi = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)chartFavoriBesin).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lnkLblSifreDegistir
            // 
            lnkLblSifreDegistir.AutoSize = true;
            lnkLblSifreDegistir.BackColor = Color.Transparent;
            lnkLblSifreDegistir.Location = new Point(65, 330);
            lnkLblSifreDegistir.Name = "lnkLblSifreDegistir";
            lnkLblSifreDegistir.Size = new Size(73, 15);
            lnkLblSifreDegistir.TabIndex = 1;
            lnkLblSifreDegistir.TabStop = true;
            lnkLblSifreDegistir.Text = "Şifre Değiştir";
            lnkLblSifreDegistir.LinkClicked += lnkLblSifreDegistir_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(447, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 2;
            label1.Text = "Profilim";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.BackColor = Color.Transparent;
            lblAdSoyad.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdSoyad.Location = new Point(65, 27);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(42, 14);
            lblAdSoyad.TabIndex = 3;
            lblAdSoyad.Text = "label2";
            // 
            // txtBoxGoalType
            // 
            txtBoxGoalType.Location = new Point(122, 107);
            txtBoxGoalType.Margin = new Padding(3, 2, 3, 2);
            txtBoxGoalType.Name = "txtBoxGoalType";
            txtBoxGoalType.Size = new Size(136, 23);
            txtBoxGoalType.TabIndex = 5;
            // 
            // txtBoxDietType
            // 
            txtBoxDietType.Location = new Point(122, 153);
            txtBoxDietType.Margin = new Padding(3, 2, 3, 2);
            txtBoxDietType.Name = "txtBoxDietType";
            txtBoxDietType.Size = new Size(136, 23);
            txtBoxDietType.TabIndex = 6;
            // 
            // txtBoxBoy
            // 
            txtBoxBoy.Location = new Point(337, 153);
            txtBoxBoy.Margin = new Padding(3, 2, 3, 2);
            txtBoxBoy.Name = "txtBoxBoy";
            txtBoxBoy.Size = new Size(136, 23);
            txtBoxBoy.TabIndex = 8;
            // 
            // txtBoxKilo
            // 
            txtBoxKilo.Location = new Point(337, 104);
            txtBoxKilo.Margin = new Padding(3, 2, 3, 2);
            txtBoxKilo.Name = "txtBoxKilo";
            txtBoxKilo.Size = new Size(136, 23);
            txtBoxKilo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(366, 212);
            label3.Name = "label3";
            label3.Size = new Size(90, 17);
            label3.TabIndex = 11;
            label3.Text = "Kalan kcal.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(44, 212);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 10;
            label2.Text = "Hedef kcal.";
            // 
            // lblHedefKcal
            // 
            lblHedefKcal.AutoSize = true;
            lblHedefKcal.BackColor = Color.Transparent;
            lblHedefKcal.Location = new Point(65, 265);
            lblHedefKcal.Name = "lblHedefKcal";
            lblHedefKcal.Size = new Size(38, 15);
            lblHedefKcal.TabIndex = 12;
            lblHedefKcal.Text = "label5";
            // 
            // lblKalanKcal
            // 
            lblKalanKcal.AutoSize = true;
            lblKalanKcal.BackColor = Color.Transparent;
            lblKalanKcal.Location = new Point(402, 265);
            lblKalanKcal.Name = "lblKalanKcal";
            lblKalanKcal.Size = new Size(38, 15);
            lblKalanKcal.TabIndex = 13;
            lblKalanKcal.Text = "label6";
            // 
            // chartFavoriBesin
            // 
            chartArea1.Name = "ChartArea1";
            chartFavoriBesin.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFavoriBesin.Legends.Add(legend1);
            chartFavoriBesin.Location = new Point(504, 43);
            chartFavoriBesin.Margin = new Padding(3, 2, 3, 2);
            chartFavoriBesin.Name = "chartFavoriBesin";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFavoriBesin.Series.Add(series1);
            chartFavoriBesin.Size = new Size(423, 286);
            chartFavoriBesin.TabIndex = 16;
            chartFavoriBesin.Text = "chart2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(287, 110);
            label5.Name = "label5";
            label5.Size = new Size(36, 14);
            label5.TabIndex = 18;
            label5.Text = "Kilo :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(66, 110);
            label6.Name = "label6";
            label6.Size = new Size(49, 14);
            label6.TabIndex = 19;
            label6.Text = "Hedef :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(291, 158);
            label7.Name = "label7";
            label7.Size = new Size(37, 14);
            label7.TabIndex = 20;
            label7.Text = "Boy :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(18, 158);
            label8.Name = "label8";
            label8.Size = new Size(102, 14);
            label8.TabIndex = 21;
            label8.Text = "Beslenme Türü :";
            // 
            // lLabelGrafikler
            // 
            lLabelGrafikler.AutoSize = true;
            lLabelGrafikler.BackColor = Color.Transparent;
            lLabelGrafikler.Location = new Point(393, 330);
            lLabelGrafikler.Name = "lLabelGrafikler";
            lLabelGrafikler.Size = new Size(81, 15);
            lLabelGrafikler.TabIndex = 22;
            lLabelGrafikler.TabStop = true;
            lLabelGrafikler.Text = "Kalori Takibim";
            lLabelGrafikler.LinkClicked += lLabelGrafikler_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(159, 212);
            label4.Name = "label4";
            label4.Size = new Size(176, 17);
            label4.TabIndex = 23;
            label4.Text = "En Çok Tüketilen Besin";
            // 
            // lblEnCokTuketilenYiyecek
            // 
            lblEnCokTuketilenYiyecek.AutoSize = true;
            lblEnCokTuketilenYiyecek.BackColor = Color.Transparent;
            lblEnCokTuketilenYiyecek.Location = new Point(223, 265);
            lblEnCokTuketilenYiyecek.Name = "lblEnCokTuketilenYiyecek";
            lblEnCokTuketilenYiyecek.Size = new Size(38, 15);
            lblEnCokTuketilenYiyecek.TabIndex = 24;
            lblEnCokTuketilenYiyecek.Text = "label9";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(65, 62);
            label9.Name = "label9";
            label9.Size = new Size(124, 14);
            label9.TabIndex = 25;
            label9.Text = "Vücut Kitle İndeksi : ";
            // 
            // lblBmi
            // 
            lblBmi.AutoSize = true;
            lblBmi.BackColor = Color.Transparent;
            lblBmi.Location = new Point(193, 62);
            lblBmi.Name = "lblBmi";
            lblBmi.Size = new Size(12, 15);
            lblBmi.TabIndex = 26;
            lblBmi.Text = "-";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-7, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 26);
            panel1.TabIndex = 27;
            // 
            // FrmProfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1012, 354);
            Controls.Add(panel1);
            Controls.Add(lblBmi);
            Controls.Add(label9);
            Controls.Add(lblEnCokTuketilenYiyecek);
            Controls.Add(label4);
            Controls.Add(lLabelGrafikler);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(chartFavoriBesin);
            Controls.Add(lblKalanKcal);
            Controls.Add(lblHedefKcal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxBoy);
            Controls.Add(txtBoxKilo);
            Controls.Add(txtBoxDietType);
            Controls.Add(txtBoxGoalType);
            Controls.Add(lblAdSoyad);
            Controls.Add(lnkLblSifreDegistir);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmProfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profil";
            Load += FrmProfil_Load;
            ((System.ComponentModel.ISupportInitialize)chartFavoriBesin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel lnkLblSifreDegistir;
        private Label label1;
        private Label lblAdSoyad;
        private TextBox txtBoxGoalType;
        private TextBox txtBoxDietType;
        private TextBox txtBoxBoy;
        private TextBox txtBoxKilo;
        private Label label3;
        private Label label2;
        private Label lblHedefKcal;
        private Label lblKalanKcal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFavoriBesin;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private LinkLabel lLabelGrafikler;
        private Label label4;
        private Label lblEnCokTuketilenYiyecek;
        private Label label9;
        private Label lblBmi;
        private Panel panel1;
    }
}