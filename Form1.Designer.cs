namespace Assignment2
{
    partial class Form1
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
            makeLabelBox = new Label();
            carListBox = new ListBox();
            yearLabel = new Label();
            textBoxYear = new TextBox();
            label3 = new Label();
            colorGroupBox = new GroupBox();
            radioButtonWhite = new RadioButton();
            radioButtonBlack = new RadioButton();
            radioButtonRed = new RadioButton();
            radioButtonBlue = new RadioButton();
            featuresGroupBox = new GroupBox();
            checkBoxLane = new CheckBox();
            checkBoxSyrius = new CheckBox();
            checkBoxPower = new CheckBox();
            checkBoxAC = new CheckBox();
            purchaseButton = new Button();
            label2 = new Label();
            summaryLabel = new Label();
            colorGroupBox.SuspendLayout();
            featuresGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // makeLabelBox
            // 
            makeLabelBox.AutoSize = true;
            makeLabelBox.Location = new Point(12, 43);
            makeLabelBox.Name = "makeLabelBox";
            makeLabelBox.Size = new Size(146, 25);
            makeLabelBox.TabIndex = 0;
            makeLabelBox.Text = "&Make and Model";
            makeLabelBox.Click += label1_Click;
            // 
            // carListBox
            // 
            carListBox.FormattingEnabled = true;
            carListBox.ItemHeight = 25;
            carListBox.Items.AddRange(new object[] { "Chevy Silverado", "Ford F-150", "Toyota Yaris", "Honda" });
            carListBox.Location = new Point(12, 70);
            carListBox.Name = "carListBox";
            carListBox.Size = new Size(180, 129);
            carListBox.TabIndex = 1;
            carListBox.SelectedIndexChanged += carListBox_SelectedIndexChanged;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(243, 43);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(44, 25);
            yearLabel.TabIndex = 2;
            yearLabel.Text = "&Year";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(243, 71);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(150, 31);
            textBoxYear.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(452, 90);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 5;
            // 
            // colorGroupBox
            // 
            colorGroupBox.Controls.Add(radioButtonWhite);
            colorGroupBox.Controls.Add(radioButtonBlack);
            colorGroupBox.Controls.Add(radioButtonRed);
            colorGroupBox.Controls.Add(radioButtonBlue);
            colorGroupBox.Location = new Point(436, 53);
            colorGroupBox.Name = "colorGroupBox";
            colorGroupBox.Size = new Size(186, 192);
            colorGroupBox.TabIndex = 4;
            colorGroupBox.TabStop = false;
            colorGroupBox.Text = "&Color";
            colorGroupBox.Enter += groupBox1_Enter;
            // 
            // radioButtonWhite
            // 
            radioButtonWhite.AutoSize = true;
            radioButtonWhite.Location = new Point(22, 132);
            radioButtonWhite.Name = "radioButtonWhite";
            radioButtonWhite.Size = new Size(83, 29);
            radioButtonWhite.TabIndex = 8;
            radioButtonWhite.TabStop = true;
            radioButtonWhite.Text = "White";
            radioButtonWhite.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlack
            // 
            radioButtonBlack.AutoSize = true;
            radioButtonBlack.Location = new Point(22, 97);
            radioButtonBlack.Name = "radioButtonBlack";
            radioButtonBlack.Size = new Size(77, 29);
            radioButtonBlack.TabIndex = 7;
            radioButtonBlack.TabStop = true;
            radioButtonBlack.Text = "Black";
            radioButtonBlack.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            radioButtonRed.AutoSize = true;
            radioButtonRed.Location = new Point(22, 35);
            radioButtonRed.Name = "radioButtonRed";
            radioButtonRed.Size = new Size(67, 29);
            radioButtonRed.TabIndex = 5;
            radioButtonRed.TabStop = true;
            radioButtonRed.Text = "Red";
            radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlue
            // 
            radioButtonBlue.AutoSize = true;
            radioButtonBlue.Location = new Point(22, 64);
            radioButtonBlue.Name = "radioButtonBlue";
            radioButtonBlue.Size = new Size(70, 29);
            radioButtonBlue.TabIndex = 6;
            radioButtonBlue.TabStop = true;
            radioButtonBlue.Text = "Blue";
            radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // featuresGroupBox
            // 
            featuresGroupBox.Controls.Add(checkBoxLane);
            featuresGroupBox.Controls.Add(checkBoxSyrius);
            featuresGroupBox.Controls.Add(checkBoxPower);
            featuresGroupBox.Controls.Add(checkBoxAC);
            featuresGroupBox.Location = new Point(699, 53);
            featuresGroupBox.Name = "featuresGroupBox";
            featuresGroupBox.Size = new Size(252, 192);
            featuresGroupBox.TabIndex = 9;
            featuresGroupBox.TabStop = false;
            featuresGroupBox.Text = "&Features";
            // 
            // checkBoxLane
            // 
            checkBoxLane.AutoSize = true;
            checkBoxLane.Location = new Point(19, 135);
            checkBoxLane.Name = "checkBoxLane";
            checkBoxLane.Size = new Size(125, 29);
            checkBoxLane.TabIndex = 3;
            checkBoxLane.Text = "Lane Assist";
            checkBoxLane.UseVisualStyleBackColor = true;
            // 
            // checkBoxSyrius
            // 
            checkBoxSyrius.AutoSize = true;
            checkBoxSyrius.Location = new Point(19, 100);
            checkBoxSyrius.Name = "checkBoxSyrius";
            checkBoxSyrius.Size = new Size(135, 29);
            checkBoxSyrius.TabIndex = 2;
            checkBoxSyrius.Text = "Syrius Radio";
            checkBoxSyrius.UseVisualStyleBackColor = true;
            // 
            // checkBoxPower
            // 
            checkBoxPower.AutoSize = true;
            checkBoxPower.Location = new Point(19, 65);
            checkBoxPower.Name = "checkBoxPower";
            checkBoxPower.Size = new Size(165, 29);
            checkBoxPower.TabIndex = 1;
            checkBoxPower.Text = "Power Windows";
            checkBoxPower.UseVisualStyleBackColor = true;
            // 
            // checkBoxAC
            // 
            checkBoxAC.AutoSize = true;
            checkBoxAC.Location = new Point(19, 30);
            checkBoxAC.Name = "checkBoxAC";
            checkBoxAC.Size = new Size(61, 29);
            checkBoxAC.TabIndex = 0;
            checkBoxAC.Text = "AC";
            checkBoxAC.UseVisualStyleBackColor = true;
            // 
            // purchaseButton
            // 
            purchaseButton.Location = new Point(46, 314);
            purchaseButton.Name = "purchaseButton";
            purchaseButton.Size = new Size(112, 34);
            purchaseButton.TabIndex = 14;
            purchaseButton.Text = "&Purchase";
            purchaseButton.UseVisualStyleBackColor = true;
            purchaseButton.Click += button1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(222, 345);
            label2.Name = "label2";
            label2.Size = new Size(88, 38);
            label2.TabIndex = 9;
            // 
            // summaryLabel
            // 
            summaryLabel.BorderStyle = BorderStyle.FixedSingle;
            summaryLabel.Location = new Point(243, 314);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(708, 88);
            summaryLabel.TabIndex = 15;
            summaryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1018, 450);
            Controls.Add(summaryLabel);
            Controls.Add(label2);
            Controls.Add(purchaseButton);
            Controls.Add(featuresGroupBox);
            Controls.Add(colorGroupBox);
            Controls.Add(label3);
            Controls.Add(textBoxYear);
            Controls.Add(yearLabel);
            Controls.Add(carListBox);
            Controls.Add(makeLabelBox);
            Name = "Form1";
            Text = "Assignment 2";
            colorGroupBox.ResumeLayout(false);
            colorGroupBox.PerformLayout();
            featuresGroupBox.ResumeLayout(false);
            featuresGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label makeLabelBox;
        private ListBox carListBox;
        private Label yearLabel;
        private TextBox textBoxYear;
        private Label label3;
        private GroupBox colorGroupBox;
        private RadioButton radioButtonBlue;
        private RadioButton radioButtonWhite;
        private RadioButton radioButtonBlack;
        private RadioButton radioButtonRed;
        private GroupBox featuresGroupBox;
        private Button purchaseButton;
        private Label label2;
        private Label summaryLabel;
        private CheckBox checkBoxLane;
        private CheckBox checkBoxSyrius;
        private CheckBox checkBoxPower;
        private CheckBox checkBoxAC;
    }
}
