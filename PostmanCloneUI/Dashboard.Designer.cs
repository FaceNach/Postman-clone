namespace PostmanCloneUI
{
    partial class Dashboard
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
			formHeader = new Label();
			apiLabel = new Label();
			apiText = new TextBox();
			callAPI = new Button();
			bodyText = new TextBox();
			statusStrip = new StatusStrip();
			systemStatus = new ToolStripStatusLabel();
			httpVerbSelection = new ComboBox();
			callData = new TabControl();
			bodyTab = new TabPage();
			resultsTab = new TabPage();
			resultsText = new TextBox();
			statusStrip.SuspendLayout();
			callData.SuspendLayout();
			bodyTab.SuspendLayout();
			resultsTab.SuspendLayout();
			SuspendLayout();
			// 
			// formHeader
			// 
			formHeader.AutoSize = true;
			formHeader.Location = new Point(16, 9);
			formHeader.Name = "formHeader";
			formHeader.Size = new Size(138, 25);
			formHeader.TabIndex = 0;
			formHeader.Text = "Postman Clone";
			formHeader.Click += formHeader_Click;
			// 
			// apiLabel
			// 
			apiLabel.AutoSize = true;
			apiLabel.Location = new Point(12, 69);
			apiLabel.Name = "apiLabel";
			apiLabel.Size = new Size(44, 25);
			apiLabel.TabIndex = 1;
			apiLabel.Text = "API:";
			// 
			// apiText
			// 
			apiText.BackColor = Color.White;
			apiText.BorderStyle = BorderStyle.FixedSingle;
			apiText.Location = new Point(178, 66);
			apiText.Margin = new Padding(3, 2, 3, 2);
			apiText.Name = "apiText";
			apiText.Size = new Size(765, 33);
			apiText.TabIndex = 2;
			// 
			// callAPI
			// 
			callAPI.BackColor = Color.DimGray;
			callAPI.Location = new Point(976, 67);
			callAPI.Margin = new Padding(3, 2, 3, 2);
			callAPI.Name = "callAPI";
			callAPI.Size = new Size(75, 32);
			callAPI.TabIndex = 3;
			callAPI.Text = "Go";
			callAPI.UseVisualStyleBackColor = false;
			callAPI.Click += callAPI_Click;
			// 
			// bodyText
			// 
			bodyText.BackColor = Color.White;
			bodyText.BorderStyle = BorderStyle.FixedSingle;
			bodyText.Dock = DockStyle.Fill;
			bodyText.Location = new Point(3, 3);
			bodyText.Margin = new Padding(3, 2, 3, 2);
			bodyText.Multiline = true;
			bodyText.Name = "bodyText";
			bodyText.ScrollBars = ScrollBars.Both;
			bodyText.Size = new Size(1058, 372);
			bodyText.TabIndex = 4;
			// 
			// statusStrip
			// 
			statusStrip.BackColor = Color.White;
			statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
			statusStrip.Location = new Point(0, 557);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(1096, 22);
			statusStrip.TabIndex = 5;
			statusStrip.Text = "System Status";
			// 
			// systemStatus
			// 
			systemStatus.AccessibleName = "";
			systemStatus.Name = "systemStatus";
			systemStatus.Size = new Size(39, 17);
			systemStatus.Text = "Ready";
			// 
			// httpVerbSelection
			// 
			httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
			httpVerbSelection.FormattingEnabled = true;
			httpVerbSelection.Items.AddRange(new object[] { "GET", "POST" });
			httpVerbSelection.Location = new Point(62, 66);
			httpVerbSelection.Name = "httpVerbSelection";
			httpVerbSelection.Size = new Size(97, 33);
			httpVerbSelection.TabIndex = 7;
			// 
			// callData
			// 
			callData.Controls.Add(bodyTab);
			callData.Controls.Add(resultsTab);
			callData.Location = new Point(12, 138);
			callData.Name = "callData";
			callData.SelectedIndex = 0;
			callData.Size = new Size(1072, 416);
			callData.TabIndex = 8;
			// 
			// bodyTab
			// 
			bodyTab.Controls.Add(bodyText);
			bodyTab.Location = new Point(4, 34);
			bodyTab.Name = "bodyTab";
			bodyTab.Padding = new Padding(3);
			bodyTab.Size = new Size(1064, 378);
			bodyTab.TabIndex = 0;
			bodyTab.Text = "Body";
			bodyTab.UseVisualStyleBackColor = true;
			// 
			// resultsTab
			// 
			resultsTab.Controls.Add(resultsText);
			resultsTab.Location = new Point(4, 34);
			resultsTab.Name = "resultsTab";
			resultsTab.Padding = new Padding(3);
			resultsTab.Size = new Size(1064, 378);
			resultsTab.TabIndex = 1;
			resultsTab.Text = "Results";
			resultsTab.UseVisualStyleBackColor = true;
			// 
			// resultsText
			// 
			resultsText.BackColor = Color.White;
			resultsText.BorderStyle = BorderStyle.FixedSingle;
			resultsText.Dock = DockStyle.Fill;
			resultsText.Location = new Point(3, 3);
			resultsText.Margin = new Padding(3, 2, 3, 2);
			resultsText.Multiline = true;
			resultsText.Name = "resultsText";
			resultsText.ReadOnly = true;
			resultsText.ScrollBars = ScrollBars.Both;
			resultsText.Size = new Size(1058, 372);
			resultsText.TabIndex = 5;
			resultsText.TextChanged += textBox1_TextChanged;
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1096, 579);
			Controls.Add(callData);
			Controls.Add(httpVerbSelection);
			Controls.Add(statusStrip);
			Controls.Add(callAPI);
			Controls.Add(apiText);
			Controls.Add(apiLabel);
			Controls.Add(formHeader);
			Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(6, 5, 6, 5);
			Name = "Dashboard";
			Text = "Postman Clone by Nach";
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			callData.ResumeLayout(false);
			bodyTab.ResumeLayout(false);
			bodyTab.PerformLayout();
			resultsTab.ResumeLayout(false);
			resultsTab.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private Button callAPI;
        private TextBox bodyText;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
		private ComboBox httpVerbSelection;
		private TabControl callData;
		private TabPage bodyTab;
		private TabPage resultsTab;
		private TextBox resultsText;
	}
}
