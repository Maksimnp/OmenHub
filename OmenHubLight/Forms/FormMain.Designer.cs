﻿using Hp.Omen.DeviceLib.Models.DeviceEnums;
using Hp.Omen.OmenCommonLib.PowerControl.Enum;

namespace OmenHubLight.Forms
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonShowSysInfo = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuFanModeSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFanModeDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFanModePerformance = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFanModeCool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelModel = new System.Windows.Forms.Label();
            this.timerUpdateTempInfo = new System.Windows.Forms.Timer(this.components);
            this.labelCpuTemp = new System.Windows.Forms.Label();
            this.labelGpuTemp = new System.Windows.Forms.Label();
            this.buttonFanMode = new System.Windows.Forms.Button();
            this.buttonKeyboardLight = new System.Windows.Forms.Button();
            this.menuNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowSysInfo
            // 
            this.buttonShowSysInfo.BackColor = System.Drawing.Color.Transparent;
            this.buttonShowSysInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowSysInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonShowSysInfo.Location = new System.Drawing.Point(251, 191);
            this.buttonShowSysInfo.Name = "buttonShowSysInfo";
            this.buttonShowSysInfo.Size = new System.Drawing.Size(174, 37);
            this.buttonShowSysInfo.TabIndex = 0;
            this.buttonShowSysInfo.Text = "System Information";
            this.buttonShowSysInfo.UseVisualStyleBackColor = false;
            this.buttonShowSysInfo.Click += new System.EventHandler(this.buttonShowSysInfo_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Wow";
            this.notifyIcon.BalloonTipTitle = "Amazing";
            this.notifyIcon.ContextMenuStrip = this.menuNotifyIcon;
            this.notifyIcon.Icon = global::OmenHubLight.Resource.AppIcon;
            this.notifyIcon.Text = "OMEN Hub Light";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // menuNotifyIcon
            // 
            this.menuNotifyIcon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFanModeSelect,
            this.toolStripSeparator1,
            this.menuItemQuit});
            this.menuNotifyIcon.Name = "menuNotifyIcon";
            this.menuNotifyIcon.Size = new System.Drawing.Size(128, 54);
            // 
            // menuFanModeSelect
            // 
            this.menuFanModeSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFanModeDefault,
            this.menuFanModePerformance,
            this.menuFanModeCool});
            this.menuFanModeSelect.Name = "menuFanModeSelect";
            this.menuFanModeSelect.Size = new System.Drawing.Size(127, 22);
            this.menuFanModeSelect.Text = "Fan Mode";
            // 
            // menuFanModeDefault
            // 
            this.menuFanModeDefault.CheckOnClick = true;
            this.menuFanModeDefault.Name = "menuFanModeDefault";
            this.menuFanModeDefault.Size = new System.Drawing.Size(142, 22);
            this.menuFanModeDefault.Text = "Default";
            // 
            // menuFanModePerformance
            // 
            this.menuFanModePerformance.CheckOnClick = true;
            this.menuFanModePerformance.Name = "menuFanModePerformance";
            this.menuFanModePerformance.Size = new System.Drawing.Size(142, 22);
            this.menuFanModePerformance.Text = "Performance";
            // 
            // menuFanModeCool
            // 
            this.menuFanModeCool.CheckOnClick = true;
            this.menuFanModeCool.Name = "menuFanModeCool";
            this.menuFanModeCool.Size = new System.Drawing.Size(142, 22);
            this.menuFanModeCool.Text = "Cool";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // menuItemQuit
            // 
            this.menuItemQuit.Name = "menuItemQuit";
            this.menuItemQuit.Size = new System.Drawing.Size(127, 22);
            this.menuItemQuit.Text = "&Quit";
            this.menuItemQuit.Click += new System.EventHandler(this.menuItemQuit_Click);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelModel.Location = new System.Drawing.Point(13, 9);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(197, 32);
            this.labelModel.TabIndex = 1;
            this.labelModel.Text = "Computer Model";
            // 
            // timerUpdateTempInfo
            // 
            this.timerUpdateTempInfo.Interval = 1000;
            this.timerUpdateTempInfo.Tick += new System.EventHandler(this.timerUpdateTempInfo_Tick);
            // 
            // labelCpuTemp
            // 
            this.labelCpuTemp.AutoSize = true;
            this.labelCpuTemp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCpuTemp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCpuTemp.Location = new System.Drawing.Point(13, 102);
            this.labelCpuTemp.Name = "labelCpuTemp";
            this.labelCpuTemp.Size = new System.Drawing.Size(120, 19);
            this.labelCpuTemp.TabIndex = 2;
            this.labelCpuTemp.Text = "CPU Temperature:";
            // 
            // labelGpuTemp
            // 
            this.labelGpuTemp.AutoSize = true;
            this.labelGpuTemp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGpuTemp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelGpuTemp.Location = new System.Drawing.Point(13, 134);
            this.labelGpuTemp.Name = "labelGpuTemp";
            this.labelGpuTemp.Size = new System.Drawing.Size(121, 19);
            this.labelGpuTemp.TabIndex = 3;
            this.labelGpuTemp.Text = "GPU Temperature:";
            // 
            // buttonFanMode
            // 
            this.buttonFanMode.BackColor = System.Drawing.Color.Transparent;
            this.buttonFanMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFanMode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonFanMode.Location = new System.Drawing.Point(251, 102);
            this.buttonFanMode.Name = "buttonFanMode";
            this.buttonFanMode.Size = new System.Drawing.Size(174, 37);
            this.buttonFanMode.TabIndex = 5;
            this.buttonFanMode.Text = "Performance Mode";
            this.buttonFanMode.UseVisualStyleBackColor = false;
            this.buttonFanMode.Click += new System.EventHandler(this.buttonFanMode_Click);
            // 
            // buttonKeyboardLight
            // 
            this.buttonKeyboardLight.BackColor = System.Drawing.Color.Transparent;
            this.buttonKeyboardLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeyboardLight.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonKeyboardLight.Location = new System.Drawing.Point(251, 145);
            this.buttonKeyboardLight.Name = "buttonKeyboardLight";
            this.buttonKeyboardLight.Size = new System.Drawing.Size(174, 37);
            this.buttonKeyboardLight.TabIndex = 7;
            this.buttonKeyboardLight.Text = "Keyboard Light";
            this.buttonKeyboardLight.UseVisualStyleBackColor = false;
            this.buttonKeyboardLight.Click += new System.EventHandler(this.buttonKeyboardLight_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(456, 267);
            this.Controls.Add(this.buttonKeyboardLight);
            this.Controls.Add(this.buttonFanMode);
            this.Controls.Add(this.labelGpuTemp);
            this.Controls.Add(this.labelCpuTemp);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.buttonShowSysInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::OmenHubLight.Resource.AppIcon;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OMEN Hub Light";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.VisibleChanged += new System.EventHandler(this.FormMain_VisibleChanged);
            this.menuNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowSysInfo;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip menuNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuit;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Timer timerUpdateTempInfo;
        private System.Windows.Forms.Label labelCpuTemp;
        private System.Windows.Forms.Label labelGpuTemp;
        private System.Windows.Forms.ToolStripMenuItem menuFanModeSelect;
        private System.Windows.Forms.ToolStripMenuItem menuFanModeDefault;
        private System.Windows.Forms.ToolStripMenuItem menuFanModePerformance;
        private System.Windows.Forms.ToolStripMenuItem menuFanModeCool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button buttonFanMode;
        private System.Windows.Forms.Button buttonKeyboardLight;
    }
}

