namespace Lab_2
{
    partial class Window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BlackButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.PencilSize = new System.Windows.Forms.TrackBar();
            this.PenSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PencilSize)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.SaveButton);
            this.splitContainer1.Panel1.Controls.Add(this.OpenButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Canvas);
            this.splitContainer1.Size = new System.Drawing.Size(798, 449);
            this.splitContainer1.SplitterDistance = 51;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PenSize);
            this.panel1.Controls.Add(this.PencilSize);
            this.panel1.Controls.Add(this.BlackButton);
            this.panel1.Controls.Add(this.YellowButton);
            this.panel1.Controls.Add(this.BlueButton);
            this.panel1.Controls.Add(this.RedButton);
            this.panel1.Controls.Add(this.GreenButton);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(191, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 50);
            this.panel1.TabIndex = 5;
            // 
            // BlackButton
            // 
            this.BlackButton.BackColor = System.Drawing.Color.Black;
            this.BlackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlackButton.Location = new System.Drawing.Point(375, 27);
            this.BlackButton.Name = "BlackButton";
            this.BlackButton.Size = new System.Drawing.Size(23, 23);
            this.BlackButton.TabIndex = 8;
            this.BlackButton.UseVisualStyleBackColor = false;
            this.BlackButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YellowButton.Location = new System.Drawing.Point(433, 27);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(23, 23);
            this.YellowButton.TabIndex = 6;
            this.YellowButton.UseVisualStyleBackColor = false;
            this.YellowButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.Blue;
            this.BlueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlueButton.Location = new System.Drawing.Point(433, 3);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(23, 23);
            this.BlueButton.TabIndex = 5;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.Red;
            this.RedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedButton.Location = new System.Drawing.Point(404, 3);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(23, 23);
            this.RedButton.TabIndex = 3;
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.Lime;
            this.GreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenButton.Location = new System.Drawing.Point(404, 27);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(23, 23);
            this.GreenButton.TabIndex = 2;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // button5
            // 
            this.button5.AccessibleDescription = "WhiteButton";
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(375, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(93, 16);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(12, 16);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(798, 394);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // PencilSize
            // 
            this.PencilSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.PencilSize.Location = new System.Drawing.Point(0, 0);
            this.PencilSize.Maximum = 40;
            this.PencilSize.Minimum = 1;
            this.PencilSize.Name = "PencilSize";
            this.PencilSize.Size = new System.Drawing.Size(271, 50);
            this.PencilSize.TabIndex = 10;
            this.PencilSize.Value = 11;
            this.PencilSize.Scroll += new System.EventHandler(this.PencilSize_Scroll);
            // 
            // PenSize
            // 
            this.PenSize.AutoSize = true;
            this.PenSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PenSize.Location = new System.Drawing.Point(280, 13);
            this.PenSize.Name = "PenSize";
            this.PenSize.Size = new System.Drawing.Size(30, 24);
            this.PenSize.TabIndex = 11;
            this.PenSize.Text = "11";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 449);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Window";
            this.Text = "Paint";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PencilSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button BlackButton;
        private System.Windows.Forms.TrackBar PencilSize;
        private System.Windows.Forms.Label PenSize;
    }
}

