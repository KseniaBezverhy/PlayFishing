namespace Fishing
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.frog1 = new System.Windows.Forms.PictureBox();
            this.frog2 = new System.Windows.Forms.PictureBox();
            this.labellose = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.fish1 = new System.Windows.Forms.PictureBox();
            this.labelfish = new System.Windows.Forms.Label();
            this.seaweed = new System.Windows.Forms.PictureBox();
            this.labelLife = new System.Windows.Forms.Label();
            this.buttonRestorationHeart = new System.Windows.Forms.Button();
            this.timerExtraLife = new System.Windows.Forms.Timer(this.components);
            this.labelExtraLife = new System.Windows.Forms.Label();
            this.fish2 = new System.Windows.Forms.PictureBox();
            this.timerChangeColor = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaweed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish2)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(291, 421);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(148, 146);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.WaitOnLoad = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frog1
            // 
            this.frog1.BackColor = System.Drawing.Color.Transparent;
            this.frog1.Image = ((System.Drawing.Image)(resources.GetObject("frog1.Image")));
            this.frog1.Location = new System.Drawing.Point(130, -200);
            this.frog1.Name = "frog1";
            this.frog1.Size = new System.Drawing.Size(49, 42);
            this.frog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frog1.TabIndex = 3;
            this.frog1.TabStop = false;
            // 
            // frog2
            // 
            this.frog2.BackColor = System.Drawing.Color.Transparent;
            this.frog2.Image = ((System.Drawing.Image)(resources.GetObject("frog2.Image")));
            this.frog2.Location = new System.Drawing.Point(564, -400);
            this.frog2.Name = "frog2";
            this.frog2.Size = new System.Drawing.Size(48, 37);
            this.frog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frog2.TabIndex = 4;
            this.frog2.TabStop = false;
            // 
            // labellose
            // 
            this.labellose.AutoSize = true;
            this.labellose.BackColor = System.Drawing.Color.Red;
            this.labellose.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labellose.Location = new System.Drawing.Point(216, 126);
            this.labellose.Name = "labellose";
            this.labellose.Size = new System.Drawing.Size(314, 51);
            this.labellose.TabIndex = 5;
            this.labellose.Text = "Вы проиграли";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(198, 196);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(375, 74);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Начать новую игру";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // fish1
            // 
            this.fish1.BackColor = System.Drawing.Color.Transparent;
            this.fish1.Image = ((System.Drawing.Image)(resources.GetObject("fish1.Image")));
            this.fish1.Location = new System.Drawing.Point(600, -300);
            this.fish1.Margin = new System.Windows.Forms.Padding(0);
            this.fish1.Name = "fish1";
            this.fish1.Size = new System.Drawing.Size(87, 73);
            this.fish1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish1.TabIndex = 9;
            this.fish1.TabStop = false;
            // 
            // labelfish
            // 
            this.labelfish.AutoSize = true;
            this.labelfish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelfish.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfish.Location = new System.Drawing.Point(0, 0);
            this.labelfish.Name = "labelfish";
            this.labelfish.Size = new System.Drawing.Size(208, 51);
            this.labelfish.TabIndex = 10;
            this.labelfish.Text = "Рыбки: 0";
            // 
            // seaweed
            // 
            this.seaweed.BackColor = System.Drawing.Color.Transparent;
            this.seaweed.Image = ((System.Drawing.Image)(resources.GetObject("seaweed.Image")));
            this.seaweed.Location = new System.Drawing.Point(370, -600);
            this.seaweed.Name = "seaweed";
            this.seaweed.Size = new System.Drawing.Size(161, 141);
            this.seaweed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seaweed.TabIndex = 11;
            this.seaweed.TabStop = false;
            // 
            // labelLife
            // 
            this.labelLife.AutoSize = true;
            this.labelLife.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLife.Location = new System.Drawing.Point(-2, 51);
            this.labelLife.Name = "labelLife";
            this.labelLife.Size = new System.Drawing.Size(210, 51);
            this.labelLife.TabIndex = 12;
            this.labelLife.Text = "Жизни: 3";
            // 
            // buttonRestorationHeart
            // 
            this.buttonRestorationHeart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRestorationHeart.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonRestorationHeart.CausesValidation = false;
            this.buttonRestorationHeart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRestorationHeart.Location = new System.Drawing.Point(690, 1);
            this.buttonRestorationHeart.Name = "buttonRestorationHeart";
            this.buttonRestorationHeart.Size = new System.Drawing.Size(94, 50);
            this.buttonRestorationHeart.TabIndex = 14;
            this.buttonRestorationHeart.Text = "Увеличить жизни";
            this.buttonRestorationHeart.UseVisualStyleBackColor = false;
            this.buttonRestorationHeart.Click += new System.EventHandler(this.buttonRestorationHeart_Click);
            // 
            // timerExtraLife
            // 
            this.timerExtraLife.Interval = 1000;
            this.timerExtraLife.Tick += new System.EventHandler(this.timerExtraLife_Tick);
            // 
            // labelExtraLife
            // 
            this.labelExtraLife.AutoSize = true;
            this.labelExtraLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExtraLife.Location = new System.Drawing.Point(731, 54);
            this.labelExtraLife.Name = "labelExtraLife";
            this.labelExtraLife.Size = new System.Drawing.Size(53, 38);
            this.labelExtraLife.TabIndex = 14;
            this.labelExtraLife.Text = "10";
            // 
            // fish2
            // 
            this.fish2.BackColor = System.Drawing.Color.Transparent;
            this.fish2.Image = ((System.Drawing.Image)(resources.GetObject("fish2.Image")));
            this.fish2.Location = new System.Drawing.Point(10, -100);
            this.fish2.Name = "fish2";
            this.fish2.Size = new System.Drawing.Size(73, 65);
            this.fish2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish2.TabIndex = 7;
            this.fish2.TabStop = false;
            // 
            // timerChangeColor
            // 
            this.timerChangeColor.Interval = 1000;
            this.timerChangeColor.Tick += new System.EventHandler(this.timerChangeColor_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.labelExtraLife);
            this.Controls.Add(this.buttonRestorationHeart);
            this.Controls.Add(this.labelfish);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labellose);
            this.Controls.Add(this.labelLife);
            this.Controls.Add(this.seaweed);
            this.Controls.Add(this.fish1);
            this.Controls.Add(this.fish2);
            this.Controls.Add(this.frog2);
            this.Controls.Add(this.frog1);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaweed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox frog1;
        private System.Windows.Forms.PictureBox frog2;
        private System.Windows.Forms.Label labellose;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox fish1;
        private System.Windows.Forms.Label labelfish;
        private System.Windows.Forms.PictureBox seaweed;
        private System.Windows.Forms.Label labelLife;
        private System.Windows.Forms.Button buttonRestorationHeart;
        private System.Windows.Forms.Timer timerExtraLife;
        private System.Windows.Forms.Label labelExtraLife;
        private System.Windows.Forms.PictureBox fish2;
        private System.Windows.Forms.Timer timerChangeColor;
    }
}

