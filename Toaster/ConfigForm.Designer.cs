using System.Drawing;
using System.Windows.Forms;

namespace Toaster
{
    partial class ConfigForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.rootLayout = new System.Windows.Forms.TableLayoutPanel();
            this.configGroupBox = new System.Windows.Forms.GroupBox();
            this.configTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.inputsTable = new System.Windows.Forms.TableLayoutPanel();
            this.titleInputLabel = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.timeoutInputLabel = new System.Windows.Forms.Label();
            this.inputTimeout = new System.Windows.Forms.NumericUpDown();
            this.cornerLabel = new System.Windows.Forms.Label();
            this.inputCorner = new System.Windows.Forms.ComboBox();
            this.offsetsGroupBox = new System.Windows.Forms.GroupBox();
            this.offsetsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.inputOffsetY = new System.Windows.Forms.NumericUpDown();
            this.yOffsetLabel = new System.Windows.Forms.Label();
            this.xOffSetLabel = new System.Windows.Forms.Label();
            this.inputOffsetX = new System.Windows.Forms.NumericUpDown();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.stopButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFormMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rootLayout.SuspendLayout();
            this.configGroupBox.SuspendLayout();
            this.configTableLayout.SuspendLayout();
            this.inputsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTimeout)).BeginInit();
            this.offsetsGroupBox.SuspendLayout();
            this.offsetsTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputOffsetX)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.trayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            this.rootLayout.ColumnCount = 1;
            this.rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootLayout.Controls.Add(this.configGroupBox, 0, 0);
            this.rootLayout.Controls.Add(this.buttonsPanel, 0, 1);
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.Location = new System.Drawing.Point(0, 0);
            this.rootLayout.Name = "rootLayout";
            this.rootLayout.RowCount = 2;
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rootLayout.Size = new System.Drawing.Size(326, 372);
            this.rootLayout.TabIndex = 0;
            // 
            // configGroupBox
            // 
            this.configGroupBox.Controls.Add(this.configTableLayout);
            this.configGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configGroupBox.Location = new System.Drawing.Point(3, 3);
            this.configGroupBox.Name = "configGroupBox";
            this.configGroupBox.Size = new System.Drawing.Size(320, 328);
            this.configGroupBox.TabIndex = 1;
            this.configGroupBox.TabStop = false;
            this.configGroupBox.Text = "Config";
            // 
            // configTableLayout
            // 
            this.configTableLayout.ColumnCount = 1;
            this.configTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.configTableLayout.Controls.Add(this.inputsTable, 0, 0);
            this.configTableLayout.Controls.Add(this.offsetsGroupBox, 0, 1);
            this.configTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configTableLayout.Location = new System.Drawing.Point(3, 16);
            this.configTableLayout.Name = "configTableLayout";
            this.configTableLayout.RowCount = 2;
            this.configTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.configTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.configTableLayout.Size = new System.Drawing.Size(314, 309);
            this.configTableLayout.TabIndex = 4;
            // 
            // inputsTable
            // 
            this.inputsTable.ColumnCount = 2;
            this.inputsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.inputsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.inputsTable.Controls.Add(this.titleInputLabel, 0, 0);
            this.inputsTable.Controls.Add(this.inputTitle, 1, 0);
            this.inputsTable.Controls.Add(this.timeoutInputLabel, 0, 1);
            this.inputsTable.Controls.Add(this.inputTimeout, 1, 1);
            this.inputsTable.Controls.Add(this.cornerLabel, 0, 2);
            this.inputsTable.Controls.Add(this.inputCorner, 1, 2);
            this.inputsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputsTable.Location = new System.Drawing.Point(3, 3);
            this.inputsTable.Name = "inputsTable";
            this.inputsTable.RowCount = 3;
            this.inputsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputsTable.Size = new System.Drawing.Size(308, 90);
            this.inputsTable.TabIndex = 4;
            // 
            // titleInputLabel
            // 
            this.titleInputLabel.AutoSize = true;
            this.titleInputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleInputLabel.Location = new System.Drawing.Point(3, 0);
            this.titleInputLabel.Name = "titleInputLabel";
            this.titleInputLabel.Size = new System.Drawing.Size(101, 26);
            this.titleInputLabel.TabIndex = 0;
            this.titleInputLabel.Text = "Notification Title";
            // 
            // inputTitle
            // 
            this.inputTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTitle.Location = new System.Drawing.Point(110, 3);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(195, 20);
            this.inputTitle.TabIndex = 1;
            // 
            // timeoutInputLabel
            // 
            this.timeoutInputLabel.AutoSize = true;
            this.timeoutInputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeoutInputLabel.Location = new System.Drawing.Point(3, 26);
            this.timeoutInputLabel.Name = "timeoutInputLabel";
            this.timeoutInputLabel.Size = new System.Drawing.Size(101, 26);
            this.timeoutInputLabel.TabIndex = 2;
            this.timeoutInputLabel.Text = "Timeout:";
            // 
            // inputTimeout
            // 
            this.inputTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTimeout.Location = new System.Drawing.Point(110, 29);
            this.inputTimeout.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputTimeout.Name = "inputTimeout";
            this.inputTimeout.Size = new System.Drawing.Size(195, 20);
            this.inputTimeout.TabIndex = 3;
            // 
            // cornerLabel
            // 
            this.cornerLabel.AutoSize = true;
            this.cornerLabel.Location = new System.Drawing.Point(3, 52);
            this.cornerLabel.Name = "cornerLabel";
            this.cornerLabel.Size = new System.Drawing.Size(41, 13);
            this.cornerLabel.TabIndex = 4;
            this.cornerLabel.Text = "Corner:";
            // 
            // inputCorner
            // 
            this.inputCorner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputCorner.FormattingEnabled = true;
            this.inputCorner.Items.AddRange(new object[] {
            "Top Left",
            "Top Right",
            "Bottom Left",
            "Bottom Right"});
            this.inputCorner.Location = new System.Drawing.Point(110, 55);
            this.inputCorner.Name = "inputCorner";
            this.inputCorner.Size = new System.Drawing.Size(195, 21);
            this.inputCorner.TabIndex = 5;
            // 
            // offsetsGroupBox
            // 
            this.offsetsGroupBox.Controls.Add(this.offsetsTableLayout);
            this.offsetsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offsetsGroupBox.Location = new System.Drawing.Point(3, 99);
            this.offsetsGroupBox.Name = "offsetsGroupBox";
            this.offsetsGroupBox.Size = new System.Drawing.Size(308, 212);
            this.offsetsGroupBox.TabIndex = 5;
            this.offsetsGroupBox.TabStop = false;
            this.offsetsGroupBox.Text = "Offsets";
            // 
            // offsetsTableLayout
            // 
            this.offsetsTableLayout.ColumnCount = 2;
            this.offsetsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.offsetsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.offsetsTableLayout.Controls.Add(this.inputOffsetY, 1, 1);
            this.offsetsTableLayout.Controls.Add(this.yOffsetLabel, 0, 1);
            this.offsetsTableLayout.Controls.Add(this.xOffSetLabel, 0, 0);
            this.offsetsTableLayout.Controls.Add(this.inputOffsetX, 1, 0);
            this.offsetsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offsetsTableLayout.Location = new System.Drawing.Point(3, 16);
            this.offsetsTableLayout.Name = "offsetsTableLayout";
            this.offsetsTableLayout.RowCount = 2;
            this.offsetsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.offsetsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.offsetsTableLayout.Size = new System.Drawing.Size(302, 193);
            this.offsetsTableLayout.TabIndex = 0;
            // 
            // inputOffsetY
            // 
            this.inputOffsetY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputOffsetY.Location = new System.Drawing.Point(108, 29);
            this.inputOffsetY.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.inputOffsetY.Minimum = new decimal(new int[] {
            4096,
            0,
            0,
            -2147483648});
            this.inputOffsetY.Name = "inputOffsetY";
            this.inputOffsetY.Size = new System.Drawing.Size(191, 20);
            this.inputOffsetY.TabIndex = 4;
            // 
            // yOffsetLabel
            // 
            this.yOffsetLabel.AutoSize = true;
            this.yOffsetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yOffsetLabel.Location = new System.Drawing.Point(3, 26);
            this.yOffsetLabel.Name = "yOffsetLabel";
            this.yOffsetLabel.Size = new System.Drawing.Size(99, 167);
            this.yOffsetLabel.TabIndex = 2;
            this.yOffsetLabel.Text = "Y:";
            // 
            // xOffSetLabel
            // 
            this.xOffSetLabel.AutoSize = true;
            this.xOffSetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xOffSetLabel.Location = new System.Drawing.Point(3, 0);
            this.xOffSetLabel.Name = "xOffSetLabel";
            this.xOffSetLabel.Size = new System.Drawing.Size(99, 26);
            this.xOffSetLabel.TabIndex = 0;
            this.xOffSetLabel.Text = "X:";
            // 
            // inputOffsetX
            // 
            this.inputOffsetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputOffsetX.Location = new System.Drawing.Point(108, 3);
            this.inputOffsetX.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.inputOffsetX.Minimum = new decimal(new int[] {
            4096,
            0,
            0,
            -2147483648});
            this.inputOffsetX.Name = "inputOffsetX";
            this.inputOffsetX.Size = new System.Drawing.Size(191, 20);
            this.inputOffsetX.TabIndex = 3;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.stopButton);
            this.buttonsPanel.Controls.Add(this.okButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(3, 337);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(320, 32);
            this.buttonsPanel.TabIndex = 2;
            // 
            // stopButton
            // 
            this.stopButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.stopButton.Location = new System.Drawing.Point(245, 0);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 32);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += stopButton_Click;
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.okButton.Location = new System.Drawing.Point(0, 0);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 32);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += okButton_Click;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += trayIcon_MouseDoubleClick;
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFormMenuItem,
            this.exitMenuItem});
            this.trayContextMenu.Name = "contextMenuStrip1";
            this.trayContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // openFormMenuItem
            // 
            this.openFormMenuItem.Name = "openFormMenuItem";
            this.openFormMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFormMenuItem.Text = "Open Configuration";
            this.openFormMenuItem.Click += openFormMenuItem_Click;
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += exitMenuItem_Click;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 372);
            this.Controls.Add(this.rootLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.Name = "ConfigForm";
            this.Text = "Toaster";
            this.rootLayout.ResumeLayout(false);
            this.configGroupBox.ResumeLayout(false);
            this.configTableLayout.ResumeLayout(false);
            this.inputsTable.ResumeLayout(false);
            this.inputsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTimeout)).EndInit();
            this.offsetsGroupBox.ResumeLayout(false);
            this.offsetsTableLayout.ResumeLayout(false);
            this.offsetsTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputOffsetX)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.trayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel rootLayout;
        private GroupBox configGroupBox;
        private TableLayoutPanel configTableLayout;
        private NumericUpDown inputTimeout;
        private TableLayoutPanel inputsTable;
        private Label titleInputLabel;
        private TextBox inputTitle;
        private Label timeoutInputLabel;
        private Label cornerLabel;
        private ComboBox inputCorner;
        private GroupBox offsetsGroupBox;
        private TableLayoutPanel offsetsTableLayout;
        private Label xOffSetLabel;
        private Label yOffsetLabel;
        private NumericUpDown inputOffsetX;
        private NumericUpDown inputOffsetY;
        private NotifyIcon trayIcon;
        private ContextMenuStrip trayContextMenu;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem openFormMenuItem;
        private Panel buttonsPanel;
        private Button okButton;
        private Button stopButton;
    }
}
