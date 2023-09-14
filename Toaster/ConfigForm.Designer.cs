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
            components = new System.ComponentModel.Container();
            rootLayout = new TableLayoutPanel();
            configGroupBox = new GroupBox();
            configTableLayout = new TableLayoutPanel();
            inputsTable = new TableLayoutPanel();
            titleInputLabel = new Label();
            inputTitle = new TextBox();
            timeoutInputLabel = new Label();
            inputTimeout = new NumericUpDown();
            cornerLabel = new Label();
            inputCorner = new ComboBox();
            offsetsGroupBox = new GroupBox();
            offsetsTableLayout = new TableLayoutPanel();
            inputOffsetY = new NumericUpDown();
            yOffsetLabel = new Label();
            xOffSetLabel = new Label();
            inputOffsetX = new NumericUpDown();
            buttonsPanel = new Panel();
            stopButton = new Button();
            okButton = new Button();
            trayIcon = new NotifyIcon(components);
            trayContextMenu = new ContextMenuStrip(components);
            openFormMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            rootLayout.SuspendLayout();
            configGroupBox.SuspendLayout();
            configTableLayout.SuspendLayout();
            inputsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputTimeout).BeginInit();
            offsetsGroupBox.SuspendLayout();
            offsetsTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputOffsetY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputOffsetX).BeginInit();
            buttonsPanel.SuspendLayout();
            trayContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            rootLayout.Controls.Add(configGroupBox, 0, 0);
            rootLayout.Controls.Add(buttonsPanel, 0, 1);
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Location = new Point(0, 0);
            rootLayout.Margin = new Padding(4, 3, 4, 3);
            rootLayout.Name = "rootLayout";
            rootLayout.RowCount = 2;
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            rootLayout.Size = new Size(380, 429);
            rootLayout.TabIndex = 0;
            // 
            // configGroupBox
            // 
            configGroupBox.Controls.Add(configTableLayout);
            configGroupBox.Dock = DockStyle.Fill;
            configGroupBox.Location = new Point(4, 3);
            configGroupBox.Margin = new Padding(4, 3, 4, 3);
            configGroupBox.Name = "configGroupBox";
            configGroupBox.Padding = new Padding(4, 3, 4, 3);
            configGroupBox.Size = new Size(372, 380);
            configGroupBox.TabIndex = 1;
            configGroupBox.TabStop = false;
            configGroupBox.Text = "Config";
            // 
            // configTableLayout
            // 
            configTableLayout.ColumnCount = 1;
            configTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            configTableLayout.Controls.Add(inputsTable, 0, 0);
            configTableLayout.Controls.Add(offsetsGroupBox, 0, 1);
            configTableLayout.Dock = DockStyle.Fill;
            configTableLayout.Location = new Point(4, 19);
            configTableLayout.Margin = new Padding(4, 3, 4, 3);
            configTableLayout.Name = "configTableLayout";
            configTableLayout.RowCount = 2;
            configTableLayout.RowStyles.Add(new RowStyle());
            configTableLayout.RowStyles.Add(new RowStyle());
            configTableLayout.Size = new Size(364, 358);
            configTableLayout.TabIndex = 4;
            // 
            // inputsTable
            // 
            inputsTable.ColumnCount = 2;
            inputsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            inputsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            inputsTable.Controls.Add(titleInputLabel, 0, 0);
            inputsTable.Controls.Add(inputTitle, 1, 0);
            inputsTable.Controls.Add(timeoutInputLabel, 0, 1);
            inputsTable.Controls.Add(inputTimeout, 1, 1);
            inputsTable.Controls.Add(cornerLabel, 0, 2);
            inputsTable.Controls.Add(inputCorner, 1, 2);
            inputsTable.Dock = DockStyle.Fill;
            inputsTable.Location = new Point(4, 3);
            inputsTable.Margin = new Padding(4, 3, 4, 3);
            inputsTable.Name = "inputsTable";
            inputsTable.RowCount = 3;
            inputsTable.RowStyles.Add(new RowStyle());
            inputsTable.RowStyles.Add(new RowStyle());
            inputsTable.RowStyles.Add(new RowStyle());
            inputsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            inputsTable.Size = new Size(356, 104);
            inputsTable.TabIndex = 4;
            // 
            // titleInputLabel
            // 
            titleInputLabel.AutoSize = true;
            titleInputLabel.Dock = DockStyle.Fill;
            titleInputLabel.Location = new Point(4, 0);
            titleInputLabel.Margin = new Padding(4, 0, 4, 0);
            titleInputLabel.Name = "titleInputLabel";
            titleInputLabel.Size = new Size(116, 29);
            titleInputLabel.TabIndex = 0;
            titleInputLabel.Text = "Notification Title";
            // 
            // inputTitle
            // 
            inputTitle.Dock = DockStyle.Fill;
            inputTitle.Location = new Point(128, 3);
            inputTitle.Margin = new Padding(4, 3, 4, 3);
            inputTitle.Name = "inputTitle";
            inputTitle.Size = new Size(224, 23);
            inputTitle.TabIndex = 1;
            // 
            // timeoutInputLabel
            // 
            timeoutInputLabel.AutoSize = true;
            timeoutInputLabel.Dock = DockStyle.Fill;
            timeoutInputLabel.Location = new Point(4, 29);
            timeoutInputLabel.Margin = new Padding(4, 0, 4, 0);
            timeoutInputLabel.Name = "timeoutInputLabel";
            timeoutInputLabel.Size = new Size(116, 29);
            timeoutInputLabel.TabIndex = 2;
            timeoutInputLabel.Text = "Timeout:";
            // 
            // inputTimeout
            // 
            inputTimeout.Dock = DockStyle.Fill;
            inputTimeout.Location = new Point(128, 32);
            inputTimeout.Margin = new Padding(4, 3, 4, 3);
            inputTimeout.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            inputTimeout.Name = "inputTimeout";
            inputTimeout.Size = new Size(224, 23);
            inputTimeout.TabIndex = 3;
            // 
            // cornerLabel
            // 
            cornerLabel.AutoSize = true;
            cornerLabel.Location = new Point(4, 58);
            cornerLabel.Margin = new Padding(4, 0, 4, 0);
            cornerLabel.Name = "cornerLabel";
            cornerLabel.Size = new Size(46, 15);
            cornerLabel.TabIndex = 4;
            cornerLabel.Text = "Corner:";
            // 
            // inputCorner
            // 
            inputCorner.Dock = DockStyle.Fill;
            inputCorner.FormattingEnabled = true;
            inputCorner.Items.AddRange(new object[] { "Top Left", "Top Right", "Bottom Left", "Bottom Right" });
            inputCorner.Location = new Point(128, 61);
            inputCorner.Margin = new Padding(4, 3, 4, 3);
            inputCorner.Name = "inputCorner";
            inputCorner.Size = new Size(224, 23);
            inputCorner.TabIndex = 5;
            // 
            // offsetsGroupBox
            // 
            offsetsGroupBox.Controls.Add(offsetsTableLayout);
            offsetsGroupBox.Dock = DockStyle.Fill;
            offsetsGroupBox.Location = new Point(4, 113);
            offsetsGroupBox.Margin = new Padding(4, 3, 4, 3);
            offsetsGroupBox.Name = "offsetsGroupBox";
            offsetsGroupBox.Padding = new Padding(4, 3, 4, 3);
            offsetsGroupBox.Size = new Size(356, 242);
            offsetsGroupBox.TabIndex = 5;
            offsetsGroupBox.TabStop = false;
            offsetsGroupBox.Text = "Offsets";
            // 
            // offsetsTableLayout
            // 
            offsetsTableLayout.ColumnCount = 2;
            offsetsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            offsetsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            offsetsTableLayout.Controls.Add(inputOffsetY, 1, 1);
            offsetsTableLayout.Controls.Add(yOffsetLabel, 0, 1);
            offsetsTableLayout.Controls.Add(xOffSetLabel, 0, 0);
            offsetsTableLayout.Controls.Add(inputOffsetX, 1, 0);
            offsetsTableLayout.Dock = DockStyle.Fill;
            offsetsTableLayout.Location = new Point(4, 19);
            offsetsTableLayout.Margin = new Padding(4, 3, 4, 3);
            offsetsTableLayout.Name = "offsetsTableLayout";
            offsetsTableLayout.RowCount = 2;
            offsetsTableLayout.RowStyles.Add(new RowStyle());
            offsetsTableLayout.RowStyles.Add(new RowStyle());
            offsetsTableLayout.Size = new Size(348, 220);
            offsetsTableLayout.TabIndex = 0;
            // 
            // inputOffsetY
            // 
            inputOffsetY.Dock = DockStyle.Fill;
            inputOffsetY.Location = new Point(125, 32);
            inputOffsetY.Margin = new Padding(4, 3, 4, 3);
            inputOffsetY.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            inputOffsetY.Minimum = new decimal(new int[] { 4096, 0, 0, int.MinValue });
            inputOffsetY.Name = "inputOffsetY";
            inputOffsetY.Size = new Size(219, 23);
            inputOffsetY.TabIndex = 4;
            // 
            // yOffsetLabel
            // 
            yOffsetLabel.AutoSize = true;
            yOffsetLabel.Dock = DockStyle.Fill;
            yOffsetLabel.Location = new Point(4, 29);
            yOffsetLabel.Margin = new Padding(4, 0, 4, 0);
            yOffsetLabel.Name = "yOffsetLabel";
            yOffsetLabel.Size = new Size(113, 191);
            yOffsetLabel.TabIndex = 2;
            yOffsetLabel.Text = "Y:";
            // 
            // xOffSetLabel
            // 
            xOffSetLabel.AutoSize = true;
            xOffSetLabel.Dock = DockStyle.Fill;
            xOffSetLabel.Location = new Point(4, 0);
            xOffSetLabel.Margin = new Padding(4, 0, 4, 0);
            xOffSetLabel.Name = "xOffSetLabel";
            xOffSetLabel.Size = new Size(113, 29);
            xOffSetLabel.TabIndex = 0;
            xOffSetLabel.Text = "X:";
            // 
            // inputOffsetX
            // 
            inputOffsetX.Dock = DockStyle.Fill;
            inputOffsetX.Location = new Point(125, 3);
            inputOffsetX.Margin = new Padding(4, 3, 4, 3);
            inputOffsetX.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            inputOffsetX.Minimum = new decimal(new int[] { 4096, 0, 0, int.MinValue });
            inputOffsetX.Name = "inputOffsetX";
            inputOffsetX.Size = new Size(219, 23);
            inputOffsetX.TabIndex = 3;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(stopButton);
            buttonsPanel.Controls.Add(okButton);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Location = new Point(3, 389);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(374, 37);
            buttonsPanel.TabIndex = 2;
            // 
            // stopButton
            // 
            stopButton.Dock = DockStyle.Right;
            stopButton.Location = new Point(286, 0);
            stopButton.Margin = new Padding(4, 3, 4, 3);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(88, 37);
            stopButton.TabIndex = 4;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // okButton
            // 
            okButton.Dock = DockStyle.Left;
            okButton.Location = new Point(0, 0);
            okButton.Margin = new Padding(4, 3, 4, 3);
            okButton.Name = "okButton";
            okButton.Size = new Size(88, 37);
            okButton.TabIndex = 3;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // trayIcon
            // 
            trayIcon.ContextMenuStrip = trayContextMenu;
            trayIcon.Text = "s";
            trayIcon.Visible = true;
            trayIcon.MouseDoubleClick += trayIcon_MouseDoubleClick;
            // 
            // trayContextMenu
            // 
            trayContextMenu.Items.AddRange(new ToolStripItem[] { openFormMenuItem, exitMenuItem });
            trayContextMenu.Name = "contextMenuStrip1";
            trayContextMenu.Size = new Size(181, 48);
            // 
            // openFormMenuItem
            // 
            openFormMenuItem.Name = "openFormMenuItem";
            openFormMenuItem.Size = new Size(180, 22);
            openFormMenuItem.Text = "Open Configuration";
            openFormMenuItem.Click += openFormMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(180, 22);
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 429);
            Controls.Add(rootLayout);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ConfigForm";
            Text = "Toaster";
            rootLayout.ResumeLayout(false);
            configGroupBox.ResumeLayout(false);
            configTableLayout.ResumeLayout(false);
            inputsTable.ResumeLayout(false);
            inputsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputTimeout).EndInit();
            offsetsGroupBox.ResumeLayout(false);
            offsetsTableLayout.ResumeLayout(false);
            offsetsTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputOffsetY).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputOffsetX).EndInit();
            buttonsPanel.ResumeLayout(false);
            trayContextMenu.ResumeLayout(false);
            ResumeLayout(false);
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
