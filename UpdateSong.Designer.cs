namespace MusicLibrary
{
    partial class UpdateSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSong));
            GenreIdTextBox = new TextBox();
            artistIdTextBox = new TextBox();
            rankNumeric = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            updateSongButton = new Button();
            spotifyTextBox = new TextBox();
            playtimeTextBox = new TextBox();
            songTextBox = new TextBox();
            spotiftyLinkLabel = new Label();
            playtimeLabel = new Label();
            songLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)rankNumeric).BeginInit();
            SuspendLayout();
            // 
            // GenreIdTextBox
            // 
            GenreIdTextBox.Location = new Point(130, 122);
            GenreIdTextBox.Name = "GenreIdTextBox";
            GenreIdTextBox.Size = new Size(262, 27);
            GenreIdTextBox.TabIndex = 53;
            // 
            // artistIdTextBox
            // 
            artistIdTextBox.Location = new Point(130, 86);
            artistIdTextBox.Name = "artistIdTextBox";
            artistIdTextBox.Size = new Size(262, 27);
            artistIdTextBox.TabIndex = 52;
            // 
            // rankNumeric
            // 
            rankNumeric.Location = new Point(130, 50);
            rankNumeric.Name = "rankNumeric";
            rankNumeric.Size = new Size(262, 27);
            rankNumeric.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Menu;
            label5.Location = new Point(12, 44);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 50;
            label5.Text = "Ranking:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Menu;
            label4.Location = new Point(638, 198);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 48;
            label4.Text = "Genres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Menu;
            label3.Location = new Point(638, 4);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 47;
            label3.Text = "Artists:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(12, 121);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 44;
            label1.Text = "Genre Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 43;
            label2.Text = "Artist Id:";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(638, 226);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 144);
            listBox2.TabIndex = 42;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(638, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 144);
            listBox1.TabIndex = 41;
            // 
            // updateSongButton
            // 
            updateSongButton.Location = new Point(166, 256);
            updateSongButton.Name = "updateSongButton";
            updateSongButton.Size = new Size(203, 29);
            updateSongButton.TabIndex = 38;
            updateSongButton.Text = "Update Song";
            updateSongButton.UseVisualStyleBackColor = true;
            updateSongButton.Click += updateSongButton_Click;
            // 
            // spotifyTextBox
            // 
            spotifyTextBox.Location = new Point(130, 206);
            spotifyTextBox.Name = "spotifyTextBox";
            spotifyTextBox.Size = new Size(262, 27);
            spotifyTextBox.TabIndex = 37;
            // 
            // playtimeTextBox
            // 
            playtimeTextBox.Location = new Point(130, 164);
            playtimeTextBox.Name = "playtimeTextBox";
            playtimeTextBox.Size = new Size(262, 27);
            playtimeTextBox.TabIndex = 36;
            // 
            // songTextBox
            // 
            songTextBox.Location = new Point(130, 10);
            songTextBox.Name = "songTextBox";
            songTextBox.Size = new Size(262, 27);
            songTextBox.TabIndex = 35;
            // 
            // spotiftyLinkLabel
            // 
            spotiftyLinkLabel.AutoSize = true;
            spotiftyLinkLabel.BackColor = Color.Transparent;
            spotiftyLinkLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            spotiftyLinkLabel.ForeColor = SystemColors.Menu;
            spotiftyLinkLabel.Location = new Point(12, 208);
            spotiftyLinkLabel.Name = "spotiftyLinkLabel";
            spotiftyLinkLabel.Size = new Size(119, 25);
            spotiftyLinkLabel.TabIndex = 34;
            spotiftyLinkLabel.Text = "Spotify Link:";
            // 
            // playtimeLabel
            // 
            playtimeLabel.AutoSize = true;
            playtimeLabel.BackColor = Color.Transparent;
            playtimeLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            playtimeLabel.ForeColor = SystemColors.Menu;
            playtimeLabel.Location = new Point(12, 166);
            playtimeLabel.Name = "playtimeLabel";
            playtimeLabel.Size = new Size(91, 25);
            playtimeLabel.TabIndex = 32;
            playtimeLabel.Text = "Playtime:";
            // 
            // songLabel
            // 
            songLabel.AutoSize = true;
            songLabel.BackColor = Color.Transparent;
            songLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            songLabel.ForeColor = SystemColors.Menu;
            songLabel.Location = new Point(12, 9);
            songLabel.Name = "songLabel";
            songLabel.Size = new Size(112, 25);
            songLabel.TabIndex = 30;
            songLabel.Text = "Song name:";
            // 
            // UpdateSong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(GenreIdTextBox);
            Controls.Add(artistIdTextBox);
            Controls.Add(rankNumeric);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(updateSongButton);
            Controls.Add(spotifyTextBox);
            Controls.Add(playtimeTextBox);
            Controls.Add(songTextBox);
            Controls.Add(spotiftyLinkLabel);
            Controls.Add(playtimeLabel);
            Controls.Add(songLabel);
            Name = "UpdateSong";
            Text = "UpdateSong";
            Load += UpdateSong_Load;
            ((System.ComponentModel.ISupportInitialize)rankNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox GenreIdTextBox;
        private TextBox artistIdTextBox;
        private NumericUpDown rankNumeric;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private ListBox listBox1;
        private Button updateSongButton;
        private TextBox spotifyTextBox;
        private TextBox playtimeTextBox;
        private TextBox songTextBox;
        private Label spotiftyLinkLabel;
        private Label playtimeLabel;
        private Label songLabel;
    }
}