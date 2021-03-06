﻿namespace vIDsafe
{
    partial class FormOverview
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 146D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 30D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 7D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 17D);
            this.panelBack = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCredentialSummary = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.chartCredentials = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlHealthScores = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tlpIdentities = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lvSecurityAlerts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIdentityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAlert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBack.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlCredentialSummary.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCredentials)).BeginInit();
            this.pnlHealthScores.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.panelBack.Controls.Add(this.pnlMain);
            this.panelBack.Controls.Add(this.panel1);
            this.panelBack.Controls.Add(this.panelTitle);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Padding = new System.Windows.Forms.Padding(25);
            this.panelBack.Size = new System.Drawing.Size(823, 618);
            this.panelBack.TabIndex = 1;
            this.panelBack.Tag = "BackPanel";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.pnlMain.Controls.Add(this.pnlCredentialSummary);
            this.pnlMain.Controls.Add(this.pnlHealthScores);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(25, 92);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(25);
            this.pnlMain.Size = new System.Drawing.Size(482, 501);
            this.pnlMain.TabIndex = 6;
            this.pnlMain.Tag = "MainPanel";
            // 
            // pnlCredentialSummary
            // 
            this.pnlCredentialSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.pnlCredentialSummary.Controls.Add(this.panel9);
            this.pnlCredentialSummary.Controls.Add(this.label5);
            this.pnlCredentialSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCredentialSummary.Location = new System.Drawing.Point(25, 172);
            this.pnlCredentialSummary.Name = "pnlCredentialSummary";
            this.pnlCredentialSummary.Size = new System.Drawing.Size(432, 304);
            this.pnlCredentialSummary.TabIndex = 7;
            this.pnlCredentialSummary.Tag = "MainPanel";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 22);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.panel9.Size = new System.Drawing.Size(432, 282);
            this.panel9.TabIndex = 9;
            this.panel9.Tag = "MainPanel";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.chartCredentials);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 25);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(432, 257);
            this.panel11.TabIndex = 0;
            this.panel11.Tag = "MainPanel";
            // 
            // chartCredentials
            // 
            this.chartCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartCredentials.ChartAreas.Add(chartArea1);
            this.chartCredentials.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend1.Name = "Legend1";
            this.chartCredentials.Legends.Add(legend1);
            this.chartCredentials.Location = new System.Drawing.Point(0, 0);
            this.chartCredentials.Name = "chartCredentials";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.Legend = "Legend1";
            series1.Name = "Credentials";
            dataPoint1.Color = System.Drawing.Color.LightSeaGreen;
            dataPoint1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataPoint1.Label = "";
            dataPoint2.Color = System.Drawing.Color.Khaki;
            dataPoint2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataPoint2.Label = "";
            dataPoint3.Color = System.Drawing.Color.MediumSlateBlue;
            dataPoint3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataPoint3.Label = "";
            dataPoint4.Color = System.Drawing.Color.Salmon;
            dataPoint4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataPoint4.Label = "";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            this.chartCredentials.Series.Add(series1);
            this.chartCredentials.Size = new System.Drawing.Size(432, 257);
            this.chartCredentials.TabIndex = 1;
            this.chartCredentials.Tag = "MainPanel";
            this.chartCredentials.Text = "chart1";
            this.chartCredentials.PrePaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.chartCredentials_PrePaint);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(432, 22);
            this.label5.TabIndex = 8;
            this.label5.Tag = "FrontTitleLabel";
            this.label5.Text = "Credential summary";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseMnemonic = false;
            // 
            // pnlHealthScores
            // 
            this.pnlHealthScores.AutoSize = true;
            this.pnlHealthScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.pnlHealthScores.Controls.Add(this.panel10);
            this.pnlHealthScores.Controls.Add(this.label4);
            this.pnlHealthScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHealthScores.Location = new System.Drawing.Point(25, 25);
            this.pnlHealthScores.Name = "pnlHealthScores";
            this.pnlHealthScores.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.pnlHealthScores.Size = new System.Drawing.Size(432, 147);
            this.pnlHealthScores.TabIndex = 6;
            this.pnlHealthScores.Tag = "MainPanel";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.panel10.Controls.Add(this.tlpIdentities);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 22);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.panel10.Size = new System.Drawing.Size(432, 100);
            this.panel10.TabIndex = 8;
            this.panel10.Tag = "MainPanel";
            // 
            // tlpIdentities
            // 
            this.tlpIdentities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.tlpIdentities.ColumnCount = 1;
            this.tlpIdentities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpIdentities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpIdentities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpIdentities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpIdentities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpIdentities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpIdentities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpIdentities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpIdentities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIdentities.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpIdentities.Location = new System.Drawing.Point(0, 25);
            this.tlpIdentities.Name = "tlpIdentities";
            this.tlpIdentities.RowCount = 1;
            this.tlpIdentities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIdentities.Size = new System.Drawing.Size(432, 75);
            this.tlpIdentities.TabIndex = 0;
            this.tlpIdentities.Tag = "MainPanel";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 22);
            this.label4.TabIndex = 7;
            this.label4.Tag = "FrontTitleLabel";
            this.label4.Text = "Health scores";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(507, 92);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(25);
            this.panel1.Size = new System.Drawing.Size(291, 501);
            this.panel1.TabIndex = 8;
            this.panel1.Tag = "SubPanel";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lvSecurityAlerts);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(25, 43);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.panel6.Size = new System.Drawing.Size(241, 433);
            this.panel6.TabIndex = 7;
            this.panel6.Tag = "SubPanel";
            // 
            // lvSecurityAlerts
            // 
            this.lvSecurityAlerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.lvSecurityAlerts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSecurityAlerts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnIdentityName,
            this.columnAlert});
            this.lvSecurityAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSecurityAlerts.ForeColor = System.Drawing.Color.Gainsboro;
            this.lvSecurityAlerts.FullRowSelect = true;
            this.lvSecurityAlerts.HideSelection = false;
            this.lvSecurityAlerts.Location = new System.Drawing.Point(0, 25);
            this.lvSecurityAlerts.Name = "lvSecurityAlerts";
            this.lvSecurityAlerts.Size = new System.Drawing.Size(241, 408);
            this.lvSecurityAlerts.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvSecurityAlerts.TabIndex = 5;
            this.lvSecurityAlerts.Tag = "InnerSubPanel";
            this.lvSecurityAlerts.UseCompatibleStateImageBehavior = false;
            this.lvSecurityAlerts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // columnIdentityName
            // 
            this.columnIdentityName.Text = "Identity";
            this.columnIdentityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnIdentityName.Width = 120;
            // 
            // columnAlert
            // 
            this.columnAlert.Text = "Alert";
            this.columnAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnAlert.Width = 121;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(25, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 18);
            this.label3.TabIndex = 5;
            this.label3.Tag = "FrontSubTitleLabel";
            this.label3.Text = "Security alerts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitle
            // 
            this.panelTitle.AutoSize = true;
            this.panelTitle.Controls.Add(this.label2);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(25, 25);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.panelTitle.Size = new System.Drawing.Size(773, 67);
            this.panelTitle.TabIndex = 7;
            this.panelTitle.Tag = "TitlePanel";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(0, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(773, 21);
            this.label2.TabIndex = 4;
            this.label2.Tag = "SubTitleLabel";
            this.label2.Text = "A summary of your vault";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 21);
            this.label1.TabIndex = 3;
            this.label1.Tag = "TitleLabel";
            this.label1.Text = "Overview";
            // 
            // FormOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(823, 618);
            this.Controls.Add(this.panelBack);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "FormOverview";
            this.Text = "Overview";
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlCredentialSummary.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCredentials)).EndInit();
            this.pnlHealthScores.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tlpIdentities;
        private System.Windows.Forms.Panel pnlCredentialSummary;
        private System.Windows.Forms.Panel pnlHealthScores;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvSecurityAlerts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnIdentityName;
        private System.Windows.Forms.ColumnHeader columnAlert;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCredentials;
    }
}