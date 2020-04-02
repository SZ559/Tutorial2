namespace Tutorial2
{
    partial class MathQuiz
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.plusLabel = new System.Windows.Forms.Label();
            this.equalLabel = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.mutiplyLeftLabel = new System.Windows.Forms.Label();
            this.mutiplyRightLabel = new System.Windows.Forms.Label();
            this.divideLeftLabel = new System.Windows.Forms.Label();
            this.divideRightLabel = new System.Windows.Forms.Label();
            this.minusLabel = new System.Windows.Forms.Label();
            this.mutiplyLabel = new System.Windows.Forms.Label();
            this.divideLabel = new System.Windows.Forms.Label();
            this.equalLabel2 = new System.Windows.Forms.Label();
            this.equalLabel3 = new System.Windows.Forms.Label();
            this.equalLabel4 = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(494, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(210, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.Location = new System.Drawing.Point(288, 9);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLeftLabel.TabIndex = 1;
            this.timeLeftLabel.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(120, 143);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(71, 33);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(326, 143);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(88, 33);
            this.plusRightLabel.TabIndex = 3;
            this.plusRightLabel.Text = "?";
            // 
            // plusLabel
            // 
            this.plusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLabel.Location = new System.Drawing.Point(238, 143);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(47, 33);
            this.plusLabel.TabIndex = 4;
            this.plusLabel.Text = "+";
            // 
            // equalLabel
            // 
            this.equalLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel.Location = new System.Drawing.Point(420, 143);
            this.equalLabel.Name = "equalLabel";
            this.equalLabel.Size = new System.Drawing.Size(47, 33);
            this.equalLabel.TabIndex = 5;
            this.equalLabel.Text = "=";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(495, 143);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 42);
            this.sum.TabIndex = 2;
            this.sum.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(114, 216);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(77, 33);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(326, 216);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(88, 33);
            this.minusRightLabel.TabIndex = 8;
            this.minusRightLabel.Text = "?";
            // 
            // mutiplyLeftLabel
            // 
            this.mutiplyLeftLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutiplyLeftLabel.Location = new System.Drawing.Point(114, 285);
            this.mutiplyLeftLabel.Name = "mutiplyLeftLabel";
            this.mutiplyLeftLabel.Size = new System.Drawing.Size(77, 33);
            this.mutiplyLeftLabel.TabIndex = 9;
            this.mutiplyLeftLabel.Text = "?";
            // 
            // mutiplyRightLabel
            // 
            this.mutiplyRightLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutiplyRightLabel.Location = new System.Drawing.Point(326, 285);
            this.mutiplyRightLabel.Name = "mutiplyRightLabel";
            this.mutiplyRightLabel.Size = new System.Drawing.Size(98, 33);
            this.mutiplyRightLabel.TabIndex = 10;
            this.mutiplyRightLabel.Text = "?";
            // 
            // divideLeftLabel
            // 
            this.divideLeftLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideLeftLabel.Location = new System.Drawing.Point(114, 356);
            this.divideLeftLabel.Name = "divideLeftLabel";
            this.divideLeftLabel.Size = new System.Drawing.Size(77, 33);
            this.divideLeftLabel.TabIndex = 11;
            this.divideLeftLabel.Text = "?";
            // 
            // divideRightLabel
            // 
            this.divideRightLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideRightLabel.Location = new System.Drawing.Point(326, 356);
            this.divideRightLabel.Name = "divideRightLabel";
            this.divideRightLabel.Size = new System.Drawing.Size(98, 33);
            this.divideRightLabel.TabIndex = 12;
            this.divideRightLabel.Text = "?";
            // 
            // minusLabel
            // 
            this.minusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLabel.Location = new System.Drawing.Point(238, 216);
            this.minusLabel.Name = "minusLabel";
            this.minusLabel.Size = new System.Drawing.Size(47, 33);
            this.minusLabel.TabIndex = 13;
            this.minusLabel.Text = "-";
            // 
            // mutiplyLabel
            // 
            this.mutiplyLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutiplyLabel.Location = new System.Drawing.Point(238, 285);
            this.mutiplyLabel.Name = "mutiplyLabel";
            this.mutiplyLabel.Size = new System.Drawing.Size(47, 33);
            this.mutiplyLabel.TabIndex = 14;
            this.mutiplyLabel.Text = "*";
            // 
            // divideLabel
            // 
            this.divideLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideLabel.Location = new System.Drawing.Point(238, 356);
            this.divideLabel.Name = "divideLabel";
            this.divideLabel.Size = new System.Drawing.Size(47, 33);
            this.divideLabel.TabIndex = 15;
            this.divideLabel.Text = "/";
            // 
            // equalLabel2
            // 
            this.equalLabel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel2.Location = new System.Drawing.Point(420, 216);
            this.equalLabel2.Name = "equalLabel2";
            this.equalLabel2.Size = new System.Drawing.Size(47, 33);
            this.equalLabel2.TabIndex = 16;
            this.equalLabel2.Text = "=";
            // 
            // equalLabel3
            // 
            this.equalLabel3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel3.Location = new System.Drawing.Point(420, 285);
            this.equalLabel3.Name = "equalLabel3";
            this.equalLabel3.Size = new System.Drawing.Size(47, 33);
            this.equalLabel3.TabIndex = 17;
            this.equalLabel3.Text = "=";
            // 
            // equalLabel4
            // 
            this.equalLabel4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel4.Location = new System.Drawing.Point(420, 356);
            this.equalLabel4.Name = "equalLabel4";
            this.equalLabel4.Size = new System.Drawing.Size(47, 33);
            this.equalLabel4.TabIndex = 18;
            this.equalLabel4.Text = "=";
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(495, 207);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(120, 42);
            this.difference.TabIndex = 3;
            this.difference.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(495, 276);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(120, 42);
            this.product.TabIndex = 4;
            this.product.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // quotient
            // 
            this.quotient.Location = new System.Drawing.Point(495, 347);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(120, 42);
            this.quotient.TabIndex = 5;
            this.quotient.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.startButton.Location = new System.Drawing.Point(183, 455);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(369, 71);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start The Quiz";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MathQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 634);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.product);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.equalLabel4);
            this.Controls.Add(this.equalLabel3);
            this.Controls.Add(this.equalLabel2);
            this.Controls.Add(this.divideLabel);
            this.Controls.Add(this.mutiplyLabel);
            this.Controls.Add(this.minusLabel);
            this.Controls.Add(this.divideRightLabel);
            this.Controls.Add(this.divideLeftLabel);
            this.Controls.Add(this.mutiplyRightLabel);
            this.Controls.Add(this.mutiplyLeftLabel);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.equalLabel);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MathQuiz";
            this.Text = "Math Quiz";

            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label equalLabel;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label mutiplyLeftLabel;
        private System.Windows.Forms.Label mutiplyRightLabel;
        private System.Windows.Forms.Label divideLeftLabel;
        private System.Windows.Forms.Label divideRightLabel;
        private System.Windows.Forms.Label minusLabel;
        private System.Windows.Forms.Label mutiplyLabel;
        private System.Windows.Forms.Label divideLabel;
        private System.Windows.Forms.Label equalLabel2;
        private System.Windows.Forms.Label equalLabel3;
        private System.Windows.Forms.Label equalLabel4;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

