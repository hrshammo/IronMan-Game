namespace Sample_game
{
    partial class Form1
    {   //All Copyright © goes to HR Shammo (https://github.com/hrshammo/) 
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.barDown = new System.Windows.Forms.PictureBox();
            this.barUp = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.citory = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citory)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::Sample_game.Properties.Resources.Untitled_design__23_;
            this.ground.Location = new System.Drawing.Point(-1, 435);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(923, 82);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // barDown
            // 
            this.barDown.BackColor = System.Drawing.Color.Transparent;
            this.barDown.Image = global::Sample_game.Properties.Resources.dduuedk_0f01db7f_0166_4969_b0f0_19d72a25b5aa_removebg_preview2;
            this.barDown.Location = new System.Drawing.Point(780, 251);
            this.barDown.Name = "barDown";
            this.barDown.Size = new System.Drawing.Size(116, 431);
            this.barDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.barDown.TabIndex = 1;
            this.barDown.TabStop = false;
            this.barDown.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // barUp
            // 
            this.barUp.BackColor = System.Drawing.Color.Transparent;
            this.barUp.Image = global::Sample_game.Properties.Resources.Pink_Brush_Feminine_Beauty_Makeup_Logo1;
            this.barUp.Location = new System.Drawing.Point(137, 9);
            this.barUp.Name = "barUp";
            this.barUp.Size = new System.Drawing.Size(131, 70);
            this.barUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barUp.TabIndex = 2;
            this.barUp.TabStop = false;
            this.barUp.Click += new System.EventHandler(this.barUp_Click);
            // 
            // hero
            // 
            this.hero.BackColor = System.Drawing.Color.Transparent;
            this.hero.Image = global::Sample_game.Properties.Resources.unnamed__1_;
            this.hero.Location = new System.Drawing.Point(383, 251);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(58, 82);
            this.hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hero.TabIndex = 3;
            this.hero.TabStop = false;
            this.hero.Click += new System.EventHandler(this.hero_Click);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreText.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(12, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(110, 31);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score :  0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // citory
            // 
            this.citory.BackColor = System.Drawing.Color.Transparent;
            this.citory.Image = global::Sample_game.Properties.Resources.png_transparent_chitauri_ship_marvel_cinematic_universe_drawing_others_marvel_avengers_assemble_dragon_carnivoran__1__removebg_preview;
            this.citory.Location = new System.Drawing.Point(177, 150);
            this.citory.Name = "citory";
            this.citory.Size = new System.Drawing.Size(106, 56);
            this.citory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.citory.TabIndex = 5;
            this.citory.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sample_game.Properties.Resources.Untitled_design__21_;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.citory);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.hero);
            this.Controls.Add(this.barUp);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.barDown);
            this.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Sample Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox barDown;
        private System.Windows.Forms.PictureBox barUp;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox citory;
    }
}

