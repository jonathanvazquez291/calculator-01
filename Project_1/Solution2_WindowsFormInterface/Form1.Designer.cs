namespace Solution2_WindowsFormInterface
{
    partial class Project1_Interface
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(173, 103);
            button1.Name = "button1";
            button1.Size = new Size(511, 58);
            button1.TabIndex = 0;
            button1.Text = "Test divisibility of two integers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseClick += button1_MouseClick;
            // 
            // button2
            // 
            button2.Location = new Point(173, 184);
            button2.Name = "button2";
            button2.Size = new Size(511, 58);
            button2.TabIndex = 1;
            button2.Text = "Compute n-th Fermat number";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(325, 265);
            button3.Name = "button3";
            button3.Size = new Size(188, 58);
            button3.TabIndex = 2;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Project1_Interface
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 495);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Project1_Interface";
            Text = "Basic Integer Operations";
            Load += button1_Click;
            ResumeLayout(false);
        }

        #endregion

        public Button button1;
        private Button button2;
        private Button button3;
    }
}
