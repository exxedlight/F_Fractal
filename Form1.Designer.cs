namespace Fractal
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
			drawPicBox = new PictureBox();
			startButton = new Button();
			resetButton = new Button();
			((System.ComponentModel.ISupportInitialize)drawPicBox).BeginInit();
			SuspendLayout();
			// 
			// drawPicBox
			// 
			drawPicBox.BorderStyle = BorderStyle.FixedSingle;
			drawPicBox.Location = new Point(12, 12);
			drawPicBox.Name = "drawPicBox";
			drawPicBox.Size = new Size(800, 800);
			drawPicBox.TabIndex = 0;
			drawPicBox.TabStop = false;
			// 
			// startButton
			// 
			startButton.FlatStyle = FlatStyle.Flat;
			startButton.Location = new Point(12, 12);
			startButton.Name = "startButton";
			startButton.Size = new Size(98, 33);
			startButton.TabIndex = 1;
			startButton.Text = "Draw";
			startButton.UseVisualStyleBackColor = true;
			startButton.Click += startButton_Click;
			// 
			// resetButton
			// 
			resetButton.FlatStyle = FlatStyle.Flat;
			resetButton.Location = new Point(818, 12);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(98, 33);
			resetButton.TabIndex = 2;
			resetButton.Text = "Reset";
			resetButton.UseVisualStyleBackColor = true;
			resetButton.Click += resetButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			ClientSize = new Size(923, 822);
			Controls.Add(resetButton);
			Controls.Add(startButton);
			Controls.Add(drawPicBox);
			ForeColor = SystemColors.ButtonHighlight;
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)drawPicBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox drawPicBox;
		private Button startButton;
		private Button resetButton;
	}
}