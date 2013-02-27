namespace WindowsFormsApplication1
{
    partial class Evolution
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
            this.evolve = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.startingnumbers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.thefittest = new System.Windows.Forms.TextBox();
            this.clicksleft = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.evolvedbar = new System.Windows.Forms.ProgressBar();
            this.percentbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // evolve
            // 
            this.evolve.Location = new System.Drawing.Point(13, 13);
            this.evolve.Name = "evolve";
            this.evolve.Size = new System.Drawing.Size(75, 23);
            this.evolve.TabIndex = 0;
            this.evolve.Text = "Evolve";
            this.evolve.UseVisualStyleBackColor = true;
            this.evolve.Click += new System.EventHandler(this.evolve_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(13, 43);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(899, 444);
            this.output.TabIndex = 1;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(95, 13);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 2;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // startingnumbers
            // 
            this.startingnumbers.Location = new System.Drawing.Point(736, 12);
            this.startingnumbers.Name = "startingnumbers";
            this.startingnumbers.Size = new System.Drawing.Size(32, 20);
            this.startingnumbers.TabIndex = 3;
            this.startingnumbers.Text = "100";
            this.startingnumbers.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Starting Numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Average Population";
            // 
            // amt
            // 
            this.amt.Location = new System.Drawing.Point(590, 12);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(32, 20);
            this.amt.TabIndex = 5;
            this.amt.Text = "3000";
            this.amt.TextChanged += new System.EventHandler(this.amt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "The Fittest";
            // 
            // thefittest
            // 
            this.thefittest.Location = new System.Drawing.Point(301, 12);
            this.thefittest.Name = "thefittest";
            this.thefittest.ReadOnly = true;
            this.thefittest.Size = new System.Drawing.Size(32, 20);
            this.thefittest.TabIndex = 8;
            // 
            // clicksleft
            // 
            this.clicksleft.Location = new System.Drawing.Point(424, 12);
            this.clicksleft.Name = "clicksleft";
            this.clicksleft.ReadOnly = true;
            this.clicksleft.Size = new System.Drawing.Size(32, 20);
            this.clicksleft.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clicks Left";
            // 
            // evolvedbar
            // 
            this.evolvedbar.Location = new System.Drawing.Point(13, 492);
            this.evolvedbar.Name = "evolvedbar";
            this.evolvedbar.Size = new System.Drawing.Size(899, 23);
            this.evolvedbar.TabIndex = 11;
            this.evolvedbar.Click += new System.EventHandler(this.evolvedbar_Click);
            // 
            // percentbox
            // 
            this.percentbox.Location = new System.Drawing.Point(444, 494);
            this.percentbox.Name = "percentbox";
            this.percentbox.ReadOnly = true;
            this.percentbox.Size = new System.Drawing.Size(32, 20);
            this.percentbox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(793, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Created By Stuart Hunt";
            // 
            // Evolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 520);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.percentbox);
            this.Controls.Add(this.evolvedbar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clicksleft);
            this.Controls.Add(this.thefittest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startingnumbers);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.output);
            this.Controls.Add(this.evolve);
            this.Name = "Evolution";
            this.Text = "Evolution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button evolve;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox startingnumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox thefittest;
        private System.Windows.Forms.TextBox clicksleft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar evolvedbar;
        private System.Windows.Forms.TextBox percentbox;
        private System.Windows.Forms.Label label5;
    }
}

