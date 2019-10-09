namespace CashRegisterSummative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.weeksLabel = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.daysInput = new System.Windows.Forms.TextBox();
            this.WeeksInput = new System.Windows.Forms.TextBox();
            this.monthsInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.subtotalOP = new System.Windows.Forms.Label();
            this.taxOP = new System.Windows.Forms.Label();
            this.totalOP = new System.Windows.Forms.Label();
            this.blackLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedOutput = new System.Windows.Forms.TextBox();
            this.calculatechangeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printreceiptButton = new System.Windows.Forms.Button();
            this.neworderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("MV Boli", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ben\'s Bed and Breakfast";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // daysLabel
            // 
            this.daysLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(19, 64);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(100, 29);
            this.daysLabel.TabIndex = 1;
            this.daysLabel.Text = "Days:";
            // 
            // weeksLabel
            // 
            this.weeksLabel.AutoSize = true;
            this.weeksLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeksLabel.Location = new System.Drawing.Point(19, 120);
            this.weeksLabel.Name = "weeksLabel";
            this.weeksLabel.Size = new System.Drawing.Size(84, 28);
            this.weeksLabel.TabIndex = 2;
            this.weeksLabel.Text = "Weeks:";
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabel.Location = new System.Drawing.Point(19, 172);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(101, 28);
            this.MonthLabel.TabIndex = 3;
            this.MonthLabel.Text = "Months:";
            // 
            // daysInput
            // 
            this.daysInput.Location = new System.Drawing.Point(135, 73);
            this.daysInput.Name = "daysInput";
            this.daysInput.Size = new System.Drawing.Size(51, 20);
            this.daysInput.TabIndex = 4;
            this.daysInput.Text = "0";
            // 
            // WeeksInput
            // 
            this.WeeksInput.Location = new System.Drawing.Point(134, 128);
            this.WeeksInput.Name = "WeeksInput";
            this.WeeksInput.Size = new System.Drawing.Size(52, 20);
            this.WeeksInput.TabIndex = 5;
            this.WeeksInput.Text = "0";
            // 
            // monthsInput
            // 
            this.monthsInput.Location = new System.Drawing.Point(134, 180);
            this.monthsInput.Name = "monthsInput";
            this.monthsInput.Size = new System.Drawing.Size(52, 20);
            this.monthsInput.TabIndex = 6;
            this.monthsInput.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(24, 223);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(162, 44);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(16, 293);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(117, 28);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(12, 344);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(45, 25);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 389);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(63, 25);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(145, 295);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(0, 25);
            this.subtotalOutput.TabIndex = 11;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(144, 344);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 25);
            this.taxOutput.TabIndex = 12;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(144, 389);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 25);
            this.totalOutput.TabIndex = 13;
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(17, 47);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(276, 23);
            this.messageLabel.TabIndex = 14;
            // 
            // subtotalOP
            // 
            this.subtotalOP.BackColor = System.Drawing.Color.White;
            this.subtotalOP.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOP.Location = new System.Drawing.Point(178, 295);
            this.subtotalOP.Name = "subtotalOP";
            this.subtotalOP.Size = new System.Drawing.Size(100, 25);
            this.subtotalOP.TabIndex = 15;
            // 
            // taxOP
            // 
            this.taxOP.AutoSize = true;
            this.taxOP.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOP.Location = new System.Drawing.Point(180, 355);
            this.taxOP.Name = "taxOP";
            this.taxOP.Size = new System.Drawing.Size(0, 25);
            this.taxOP.TabIndex = 16;
            // 
            // totalOP
            // 
            this.totalOP.AutoSize = true;
            this.totalOP.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOP.Location = new System.Drawing.Point(183, 400);
            this.totalOP.Name = "totalOP";
            this.totalOP.Size = new System.Drawing.Size(0, 25);
            this.totalOP.TabIndex = 17;
            // 
            // blackLabel
            // 
            this.blackLabel.BackColor = System.Drawing.Color.Black;
            this.blackLabel.Location = new System.Drawing.Point(21, 425);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(272, 23);
            this.blackLabel.TabIndex = 18;
            this.blackLabel.Text = "label2";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(16, 469);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(106, 28);
            this.tenderedLabel.TabIndex = 19;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedOutput
            // 
            this.tenderedOutput.Location = new System.Drawing.Point(150, 477);
            this.tenderedOutput.Name = "tenderedOutput";
            this.tenderedOutput.Size = new System.Drawing.Size(143, 20);
            this.tenderedOutput.TabIndex = 20;
            // 
            // calculatechangeButton
            // 
            this.calculatechangeButton.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatechangeButton.Location = new System.Drawing.Point(24, 512);
            this.calculatechangeButton.Name = "calculatechangeButton";
            this.calculatechangeButton.Size = new System.Drawing.Size(269, 34);
            this.calculatechangeButton.TabIndex = 21;
            this.calculatechangeButton.Text = "Calculate Change";
            this.calculatechangeButton.UseVisualStyleBackColor = true;
            this.calculatechangeButton.Click += new System.EventHandler(this.CalculatechangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(19, 549);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(99, 29);
            this.changeLabel.TabIndex = 22;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(193, 555);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(100, 23);
            this.changeOutput.TabIndex = 23;
            // 
            // printreceiptButton
            // 
            this.printreceiptButton.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printreceiptButton.Location = new System.Drawing.Point(24, 581);
            this.printreceiptButton.Name = "printreceiptButton";
            this.printreceiptButton.Size = new System.Drawing.Size(269, 33);
            this.printreceiptButton.TabIndex = 24;
            this.printreceiptButton.Text = "Print Receipt";
            this.printreceiptButton.UseVisualStyleBackColor = true;
            this.printreceiptButton.Click += new System.EventHandler(this.PrintreceiptButton_Click);
            // 
            // neworderButton
            // 
            this.neworderButton.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neworderButton.Location = new System.Drawing.Point(487, 581);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(177, 33);
            this.neworderButton.TabIndex = 25;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = true;
            this.neworderButton.Click += new System.EventHandler(this.NeworderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.printreceiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculatechangeButton);
            this.Controls.Add(this.tenderedOutput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.blackLabel);
            this.Controls.Add(this.totalOP);
            this.Controls.Add(this.taxOP);
            this.Controls.Add(this.subtotalOP);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.monthsInput);
            this.Controls.Add(this.WeeksInput);
            this.Controls.Add(this.daysInput);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.weeksLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BBB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label weeksLabel;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.TextBox daysInput;
        private System.Windows.Forms.TextBox WeeksInput;
        private System.Windows.Forms.TextBox monthsInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label subtotalOP;
        private System.Windows.Forms.Label taxOP;
        private System.Windows.Forms.Label totalOP;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedOutput;
        private System.Windows.Forms.Button calculatechangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printreceiptButton;
        private System.Windows.Forms.Button neworderButton;
    }
}

