namespace Leon_Project_5
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.compLabel = new System.Windows.Forms.Label();
            this.playerPicBox = new System.Windows.Forms.PictureBox();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.drawScoreLabel = new System.Windows.Forms.Label();
            this.compScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.compPanel = new System.Windows.Forms.Panel();
            this.compPicBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.outputLabel3 = new System.Windows.Forms.Label();
            this.outputLabel4 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicBox)).BeginInit();
            this.scorePanel.SuspendLayout();
            this.playerPanel.SuspendLayout();
            this.compPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(374, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(302, 36);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Rock Paper Scissors";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(147, 43);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(78, 23);
            this.playerLabel.TabIndex = 1;
            this.playerLabel.Text = "Player";
            // 
            // compLabel
            // 
            this.compLabel.AutoSize = true;
            this.compLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compLabel.Location = new System.Drawing.Point(782, 43);
            this.compLabel.Name = "compLabel";
            this.compLabel.Size = new System.Drawing.Size(115, 23);
            this.compLabel.TabIndex = 2;
            this.compLabel.Text = "Computer";
            // 
            // playerPicBox
            // 
            this.playerPicBox.BackColor = System.Drawing.Color.White;
            this.playerPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerPicBox.Location = new System.Drawing.Point(22, 25);
            this.playerPicBox.Margin = new System.Windows.Forms.Padding(0);
            this.playerPicBox.Name = "playerPicBox";
            this.playerPicBox.Size = new System.Drawing.Size(301, 301);
            this.playerPicBox.TabIndex = 6;
            this.playerPicBox.TabStop = false;
            // 
            // scissorsButton
            // 
            this.scissorsButton.BackColor = System.Drawing.Color.White;
            this.scissorsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.scissorsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.scissorsButton.FlatAppearance.BorderSize = 2;
            this.scissorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scissorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorsButton.Image = global::Leon_Project_5.Properties.Resources.scissors35;
            this.scissorsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scissorsButton.Location = new System.Drawing.Point(250, 438);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scissorsButton.Size = new System.Drawing.Size(113, 41);
            this.scissorsButton.TabIndex = 5;
            this.scissorsButton.Text = "Scissors";
            this.scissorsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scissorsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.scissorsButton.UseVisualStyleBackColor = false;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.BackColor = System.Drawing.Color.White;
            this.paperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paperButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.paperButton.FlatAppearance.BorderSize = 2;
            this.paperButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperButton.Image = global::Leon_Project_5.Properties.Resources.paper35;
            this.paperButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paperButton.Location = new System.Drawing.Point(131, 438);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(113, 41);
            this.paperButton.TabIndex = 4;
            this.paperButton.Text = "  Paper";
            this.paperButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.paperButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paperButton.UseVisualStyleBackColor = false;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.BackColor = System.Drawing.Color.White;
            this.rockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rockButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rockButton.FlatAppearance.BorderSize = 2;
            this.rockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockButton.Image = global::Leon_Project_5.Properties.Resources.rock35;
            this.rockButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rockButton.Location = new System.Drawing.Point(12, 438);
            this.rockButton.Name = "rockButton";
            this.rockButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rockButton.Size = new System.Drawing.Size(113, 41);
            this.rockButton.TabIndex = 3;
            this.rockButton.Text = "      Rock";
            this.rockButton.UseVisualStyleBackColor = false;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.BackColor = System.Drawing.Color.Yellow;
            this.playerScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.playerScoreLabel.Location = new System.Drawing.Point(13, 63);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(65, 65);
            this.playerScoreLabel.TabIndex = 8;
            this.playerScoreLabel.Text = "0";
            this.playerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawScoreLabel
            // 
            this.drawScoreLabel.BackColor = System.Drawing.Color.Yellow;
            this.drawScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawScoreLabel.Location = new System.Drawing.Point(103, 63);
            this.drawScoreLabel.Name = "drawScoreLabel";
            this.drawScoreLabel.Size = new System.Drawing.Size(65, 65);
            this.drawScoreLabel.TabIndex = 9;
            this.drawScoreLabel.Text = "0";
            this.drawScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compScoreLabel
            // 
            this.compScoreLabel.BackColor = System.Drawing.Color.Yellow;
            this.compScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compScoreLabel.Location = new System.Drawing.Point(192, 63);
            this.compScoreLabel.Name = "compScoreLabel";
            this.compScoreLabel.Size = new System.Drawing.Size(65, 65);
            this.compScoreLabel.TabIndex = 10;
            this.compScoreLabel.Text = "0";
            this.compScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Draw";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Score";
            // 
            // scorePanel
            // 
            this.scorePanel.BackColor = System.Drawing.Color.Black;
            this.scorePanel.Controls.Add(this.label4);
            this.scorePanel.Controls.Add(this.label3);
            this.scorePanel.Controls.Add(this.compScoreLabel);
            this.scorePanel.Controls.Add(this.label2);
            this.scorePanel.Controls.Add(this.drawScoreLabel);
            this.scorePanel.Controls.Add(this.label1);
            this.scorePanel.Controls.Add(this.playerScoreLabel);
            this.scorePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.scorePanel.Location = new System.Drawing.Point(380, 81);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Padding = new System.Windows.Forms.Padding(10);
            this.scorePanel.Size = new System.Drawing.Size(270, 141);
            this.scorePanel.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(192, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Comp.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Player";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerPanel
            // 
            this.playerPanel.BackColor = System.Drawing.Color.White;
            this.playerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerPanel.Controls.Add(this.playerPicBox);
            this.playerPanel.Location = new System.Drawing.Point(12, 81);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(351, 351);
            this.playerPanel.TabIndex = 15;
            // 
            // compPanel
            // 
            this.compPanel.BackColor = System.Drawing.Color.White;
            this.compPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compPanel.Controls.Add(this.compPicBox);
            this.compPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.compPanel.Location = new System.Drawing.Point(667, 81);
            this.compPanel.Name = "compPanel";
            this.compPanel.Size = new System.Drawing.Size(351, 351);
            this.compPanel.TabIndex = 16;
            // 
            // compPicBox
            // 
            this.compPicBox.BackColor = System.Drawing.Color.White;
            this.compPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.compPicBox.Location = new System.Drawing.Point(23, 25);
            this.compPicBox.Margin = new System.Windows.Forms.Padding(0);
            this.compPicBox.Name = "compPicBox";
            this.compPicBox.Size = new System.Drawing.Size(301, 301);
            this.compPicBox.TabIndex = 6;
            this.compPicBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(921, 438);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 39);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputLabel1
            // 
            this.outputLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel1.Location = new System.Drawing.Point(380, 237);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(270, 37);
            this.outputLabel1.TabIndex = 18;
            this.outputLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabel2
            // 
            this.outputLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel2.Location = new System.Drawing.Point(380, 274);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(270, 37);
            this.outputLabel2.TabIndex = 19;
            this.outputLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabel3
            // 
            this.outputLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel3.Location = new System.Drawing.Point(380, 311);
            this.outputLabel3.Name = "outputLabel3";
            this.outputLabel3.Size = new System.Drawing.Size(270, 37);
            this.outputLabel3.TabIndex = 20;
            this.outputLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabel4
            // 
            this.outputLabel4.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel4.Location = new System.Drawing.Point(380, 371);
            this.outputLabel4.Name = "outputLabel4";
            this.outputLabel4.Size = new System.Drawing.Size(270, 37);
            this.outputLabel4.TabIndex = 21;
            this.outputLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(667, 441);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(97, 39);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 503);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.outputLabel4);
            this.Controls.Add(this.outputLabel3);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.compPanel);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.compLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Rock-Paper-Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.playerPicBox)).EndInit();
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            this.playerPanel.ResumeLayout(false);
            this.compPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label compLabel;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.PictureBox playerPicBox;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label drawScoreLabel;
        private System.Windows.Forms.Label compScoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Panel compPanel;
        private System.Windows.Forms.PictureBox compPicBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label outputLabel2;
        private System.Windows.Forms.Label outputLabel3;
        private System.Windows.Forms.Label outputLabel4;
        private System.Windows.Forms.Button resetButton;
    }
}

