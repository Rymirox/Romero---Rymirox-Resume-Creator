namespace Romero___Rymirox_Resume_Creator
{
    partial class StartingScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingScreenForm));
            this.buttonSSF1 = new System.Windows.Forms.Button();
            this.buttonSSF2 = new System.Windows.Forms.Button();
            this.buttonSSF3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSSF1
            // 
            this.buttonSSF1.BackgroundImage = global::Romero___Rymirox_Resume_Creator.Properties.Resources.Purple_and_Yellow_Retro_Neon_Gradient_Starting_Soon_Twitch_Background;
            this.buttonSSF1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSSF1.ForeColor = System.Drawing.Color.White;
            this.buttonSSF1.Location = new System.Drawing.Point(349, 273);
            this.buttonSSF1.Name = "buttonSSF1";
            this.buttonSSF1.Size = new System.Drawing.Size(117, 47);
            this.buttonSSF1.TabIndex = 0;
            this.buttonSSF1.Text = "Start";
            this.buttonSSF1.UseVisualStyleBackColor = true;
            this.buttonSSF1.Click += new System.EventHandler(this.buttonSSF1_Click);
            // 
            // buttonSSF2
            // 
            this.buttonSSF2.BackgroundImage = global::Romero___Rymirox_Resume_Creator.Properties.Resources.Purple_and_Yellow_Retro_Neon_Gradient_Starting_Soon_Twitch_Background;
            this.buttonSSF2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSSF2.ForeColor = System.Drawing.Color.White;
            this.buttonSSF2.Location = new System.Drawing.Point(349, 326);
            this.buttonSSF2.Name = "buttonSSF2";
            this.buttonSSF2.Size = new System.Drawing.Size(117, 47);
            this.buttonSSF2.TabIndex = 1;
            this.buttonSSF2.Text = "About";
            this.buttonSSF2.UseVisualStyleBackColor = true;
            this.buttonSSF2.Click += new System.EventHandler(this.buttonSSF2_Click);
            // 
            // buttonSSF3
            // 
            this.buttonSSF3.BackgroundImage = global::Romero___Rymirox_Resume_Creator.Properties.Resources.Purple_and_Yellow_Retro_Neon_Gradient_Starting_Soon_Twitch_Background;
            this.buttonSSF3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSSF3.ForeColor = System.Drawing.Color.White;
            this.buttonSSF3.Location = new System.Drawing.Point(349, 379);
            this.buttonSSF3.Name = "buttonSSF3";
            this.buttonSSF3.Size = new System.Drawing.Size(117, 47);
            this.buttonSSF3.TabIndex = 2;
            this.buttonSSF3.Text = "Exit";
            this.buttonSSF3.UseVisualStyleBackColor = true;
            this.buttonSSF3.Click += new System.EventHandler(this.buttonSSF3_Click);
            // 
            // StartingScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Romero___Rymirox_Resume_Creator.Properties.Resources.Purple_and_Yellow_Retro_Neon_Gradient_Starting_Soon_Twitch_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 517);
            this.Controls.Add(this.buttonSSF3);
            this.Controls.Add(this.buttonSSF2);
            this.Controls.Add(this.buttonSSF1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartingScreenForm";
            this.Text = "Rymirox\' Resume Creator";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonSSF1;
        private Button buttonSSF2;
        private Button buttonSSF3;
    }
}