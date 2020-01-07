namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappyTortilla = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endText1 = new System.Windows.Forms.Label();
            this.endText2 = new System.Windows.Forms.Label();
            this.gameDesigner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyTortilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pipeTop.Image = global::WindowsFormsApp1.Properties.Resources.attempt31;
            this.pipeTop.Location = new System.Drawing.Point(472, -52);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(48, 91);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            this.pipeTop.Click += new System.EventHandler(this.pipeBottom_Click);
            // 
            // flappyTortilla
            // 
            this.flappyTortilla.BackColor = System.Drawing.Color.Transparent;
            this.flappyTortilla.Image = global::WindowsFormsApp1.Properties.Resources.evil_tortilla_games_inc_07;
            this.flappyTortilla.Location = new System.Drawing.Point(12, 74);
            this.flappyTortilla.Name = "flappyTortilla";
            this.flappyTortilla.Size = new System.Drawing.Size(45, 43);
            this.flappyTortilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flappyTortilla.TabIndex = 2;
            this.flappyTortilla.TabStop = false;
            this.flappyTortilla.Click += new System.EventHandler(this.flappyTortilla_Click_1);
            // 
            // ground
            // 
            this.ground.Location = new System.Drawing.Point(-3, 187);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(818, 12);
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pipeBottom.Enabled = false;
            this.pipeBottom.Image = global::WindowsFormsApp1.Properties.Resources.attempt31;
            this.pipeBottom.Location = new System.Drawing.Point(472, 117);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(48, 91);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeBottom.TabIndex = 4;
            this.pipeBottom.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Location = new System.Drawing.Point(86, 26);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(0, 13);
            this.scoreText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "scoreText";
            // 
            // endText1
            // 
            this.endText1.AutoSize = true;
            this.endText1.Location = new System.Drawing.Point(1383, 26);
            this.endText1.Name = "endText1";
            this.endText1.Size = new System.Drawing.Size(52, 13);
            this.endText1.TabIndex = 7;
            this.endText1.Text = "endText1";
            // 
            // endText2
            // 
            this.endText2.AutoSize = true;
            this.endText2.Location = new System.Drawing.Point(1383, 49);
            this.endText2.Name = "endText2";
            this.endText2.Size = new System.Drawing.Size(52, 13);
            this.endText2.TabIndex = 8;
            this.endText2.Text = "endText2";
            // 
            // gameDesigner
            // 
            this.gameDesigner.AutoSize = true;
            this.gameDesigner.Location = new System.Drawing.Point(1360, 74);
            this.gameDesigner.Name = "gameDesigner";
            this.gameDesigner.Size = new System.Drawing.Size(75, 13);
            this.gameDesigner.TabIndex = 9;
            this.gameDesigner.Text = "gameDesigner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.flappybackground;
            this.ClientSize = new System.Drawing.Size(1447, 210);
            this.Controls.Add(this.gameDesigner);
            this.Controls.Add(this.endText2);
            this.Controls.Add(this.endText1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.flappyTortilla);
            this.Controls.Add(this.pipeTop);
            this.Name = "Form1";
            this.Text = "Background";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyTortilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox flappyTortilla;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label endText1;
        private System.Windows.Forms.Label endText2;
        private System.Windows.Forms.Label gameDesigner;

    }
}

