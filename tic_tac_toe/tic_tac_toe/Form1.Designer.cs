namespace tic_tac_toe
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            lb_pl1 = new Label();
            lb_pls1 = new Label();
            lb_pl2 = new Label();
            lb_pls2 = new Label();
            btn_reset = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(79, 49);
            btn1.Margin = new Padding(1);
            btn1.Name = "btn1";
            btn1.Size = new Size(189, 154);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(271, 49);
            btn2.Margin = new Padding(1);
            btn2.Name = "btn2";
            btn2.Size = new Size(189, 154);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(462, 49);
            btn3.Margin = new Padding(1);
            btn3.Name = "btn3";
            btn3.Size = new Size(189, 154);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(79, 205);
            btn4.Margin = new Padding(1);
            btn4.Name = "btn4";
            btn4.Size = new Size(189, 154);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(271, 205);
            btn5.Margin = new Padding(1);
            btn5.Name = "btn5";
            btn5.Size = new Size(189, 154);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(462, 205);
            btn6.Margin = new Padding(1);
            btn6.Name = "btn6";
            btn6.Size = new Size(189, 154);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(79, 361);
            btn7.Margin = new Padding(1);
            btn7.Name = "btn7";
            btn7.Size = new Size(189, 154);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(271, 361);
            btn8.Margin = new Padding(1);
            btn8.Name = "btn8";
            btn8.Size = new Size(189, 154);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(462, 361);
            btn9.Margin = new Padding(1);
            btn9.Name = "btn9";
            btn9.Size = new Size(189, 154);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // lb_pl1
            // 
            lb_pl1.AutoSize = true;
            lb_pl1.Location = new Point(218, 13);
            lb_pl1.Margin = new Padding(1, 0, 1, 0);
            lb_pl1.Name = "lb_pl1";
            lb_pl1.Size = new Size(61, 20);
            lb_pl1.TabIndex = 9;
            lb_pl1.Text = "player1:";
            // 
            // lb_pls1
            // 
            lb_pls1.AutoSize = true;
            lb_pls1.Location = new Point(281, 13);
            lb_pls1.Margin = new Padding(1, 0, 1, 0);
            lb_pls1.Name = "lb_pls1";
            lb_pls1.Size = new Size(17, 20);
            lb_pls1.TabIndex = 10;
            lb_pls1.Text = "0";
            // 
            // lb_pl2
            // 
            lb_pl2.AutoSize = true;
            lb_pl2.Location = new Point(431, 14);
            lb_pl2.Margin = new Padding(1, 0, 1, 0);
            lb_pl2.Name = "lb_pl2";
            lb_pl2.Size = new Size(61, 20);
            lb_pl2.TabIndex = 11;
            lb_pl2.Text = "player2:";
            // 
            // lb_pls2
            // 
            lb_pls2.AutoSize = true;
            lb_pls2.Location = new Point(494, 14);
            lb_pls2.Margin = new Padding(1, 0, 1, 0);
            lb_pls2.Name = "lb_pls2";
            lb_pls2.Size = new Size(17, 20);
            lb_pls2.TabIndex = 12;
            lb_pls2.Text = "0";
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(300, 10);
            btn_reset.Margin = new Padding(1);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(119, 28);
            btn_reset.TabIndex = 13;
            btn_reset.Text = "reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 578);
            Controls.Add(btn_reset);
            Controls.Add(lb_pls2);
            Controls.Add(lb_pl2);
            Controls.Add(lb_pls1);
            Controls.Add(lb_pl1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Margin = new Padding(1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label lb_pl1;
        private Label lb_pls1;
        private Label lb_pl2;
        private Label lb_pls2;
        private Button btn_reset;
    }
}