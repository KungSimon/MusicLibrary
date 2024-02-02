namespace MusicLibrary
{
    partial class AddNewSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewSong));
            songLabel = new Label();
            artistLabel = new Label();
            genreLabel = new Label();
            playtimeLabel = new Label();
            spotiftyLinkLabel = new Label();
            songTextBox = new TextBox();
            playtimeTextBox = new TextBox();
            spotifyTextBox = new TextBox();
            addsongButton = new Button();
            addArtistButton = new Button();
            addGenreButton = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            GenreSelectedBox1 = new TextBox();
            ArtistsSelectedTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            addArtistsOrGenresButton = new Button();
            numericUpDown3 = new NumericUpDown();
            label5 = new Label();
            artistIdTextBox = new TextBox();
            GenreIdTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // songLabel
            // 
            songLabel.AutoSize = true;
            songLabel.BackColor = Color.Transparent;
            songLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            songLabel.ForeColor = SystemColors.Menu;
            songLabel.Location = new Point(23, 217);
            songLabel.Name = "songLabel";
            songLabel.Size = new Size(112, 25);
            songLabel.TabIndex = 0;
            songLabel.Text = "Song name:";
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.BackColor = Color.Transparent;
            artistLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            artistLabel.ForeColor = SystemColors.Menu;
            artistLabel.Location = new Point(34, 26);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(65, 25);
            artistLabel.TabIndex = 1;
            artistLabel.Text = "Artist:";
            artistLabel.Visible = false;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.BackColor = Color.Transparent;
            genreLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            genreLabel.ForeColor = SystemColors.Menu;
            genreLabel.Location = new Point(34, 98);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(68, 25);
            genreLabel.TabIndex = 3;
            genreLabel.Text = "Genre:";
            genreLabel.Visible = false;
            // 
            // playtimeLabel
            // 
            playtimeLabel.AutoSize = true;
            playtimeLabel.BackColor = Color.Transparent;
            playtimeLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            playtimeLabel.ForeColor = SystemColors.Menu;
            playtimeLabel.Location = new Point(23, 374);
            playtimeLabel.Name = "playtimeLabel";
            playtimeLabel.Size = new Size(91, 25);
            playtimeLabel.TabIndex = 2;
            playtimeLabel.Text = "Playtime:";
            playtimeLabel.Click += label4_Click;
            // 
            // spotiftyLinkLabel
            // 
            spotiftyLinkLabel.AutoSize = true;
            spotiftyLinkLabel.BackColor = Color.Transparent;
            spotiftyLinkLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            spotiftyLinkLabel.ForeColor = SystemColors.Menu;
            spotiftyLinkLabel.Location = new Point(23, 416);
            spotiftyLinkLabel.Name = "spotiftyLinkLabel";
            spotiftyLinkLabel.Size = new Size(119, 25);
            spotiftyLinkLabel.TabIndex = 4;
            spotiftyLinkLabel.Text = "Spotify Link:";
            // 
            // songTextBox
            // 
            songTextBox.Location = new Point(141, 218);
            songTextBox.Name = "songTextBox";
            songTextBox.Size = new Size(262, 27);
            songTextBox.TabIndex = 5;
            songTextBox.TextChanged += songTextBox_TextChanged;
            // 
            // playtimeTextBox
            // 
            playtimeTextBox.Location = new Point(141, 372);
            playtimeTextBox.Name = "playtimeTextBox";
            playtimeTextBox.Size = new Size(262, 27);
            playtimeTextBox.TabIndex = 7;
            playtimeTextBox.TextChanged += playtimeTextBox_TextChanged;
            // 
            // spotifyTextBox
            // 
            spotifyTextBox.Location = new Point(141, 414);
            spotifyTextBox.Name = "spotifyTextBox";
            spotifyTextBox.Size = new Size(262, 27);
            spotifyTextBox.TabIndex = 9;
            spotifyTextBox.TextChanged += spotifyTextBox_TextChanged;
            // 
            // addsongButton
            // 
            addsongButton.Location = new Point(477, 312);
            addsongButton.Name = "addsongButton";
            addsongButton.Size = new Size(89, 62);
            addsongButton.TabIndex = 10;
            addsongButton.Text = "Add Song";
            addsongButton.UseVisualStyleBackColor = true;
            addsongButton.Click += addsongButton_Click;
            // 
            // addArtistButton
            // 
            addArtistButton.Location = new Point(425, 28);
            addArtistButton.Name = "addArtistButton";
            addArtistButton.Size = new Size(94, 29);
            addArtistButton.TabIndex = 13;
            addArtistButton.Text = "Add Artist";
            addArtistButton.UseVisualStyleBackColor = true;
            addArtistButton.Visible = false;
            addArtistButton.Click += addArtistButton_Click;
            // 
            // addGenreButton
            // 
            addGenreButton.Location = new Point(425, 100);
            addGenreButton.Name = "addGenreButton";
            addGenreButton.Size = new Size(94, 29);
            addGenreButton.TabIndex = 14;
            addGenreButton.Text = "Add Genre";
            addGenreButton.UseVisualStyleBackColor = true;
            addGenreButton.Visible = false;
            addGenreButton.Click += addGenreButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(638, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 144);
            listBox1.TabIndex = 15;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(638, 292);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 144);
            listBox2.TabIndex = 16;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // GenreSelectedBox1
            // 
            GenreSelectedBox1.Location = new Point(135, 100);
            GenreSelectedBox1.Name = "GenreSelectedBox1";
            GenreSelectedBox1.Size = new Size(262, 27);
            GenreSelectedBox1.TabIndex = 20;
            GenreSelectedBox1.Visible = false;
            GenreSelectedBox1.TextChanged += GenreSelectedBox1_TextChanged;
            // 
            // ArtistsSelectedTextBox
            // 
            ArtistsSelectedTextBox.Location = new Point(135, 28);
            ArtistsSelectedTextBox.Name = "ArtistsSelectedTextBox";
            ArtistsSelectedTextBox.Size = new Size(262, 27);
            ArtistsSelectedTextBox.TabIndex = 19;
            ArtistsSelectedTextBox.Visible = false;
            ArtistsSelectedTextBox.TextChanged += ArtistsSelectedTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(23, 329);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 18;
            label1.Text = "Genre Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(23, 286);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 17;
            label2.Text = "Artist Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Menu;
            label3.Location = new Point(638, 70);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 21;
            label3.Text = "Artists:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Menu;
            label4.Location = new Point(638, 264);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 22;
            label4.Text = "Genres:";
            // 
            // addArtistsOrGenresButton
            // 
            addArtistsOrGenresButton.Location = new Point(141, 55);
            addArtistsOrGenresButton.Name = "addArtistsOrGenresButton";
            addArtistsOrGenresButton.Size = new Size(242, 58);
            addArtistsOrGenresButton.TabIndex = 23;
            addArtistsOrGenresButton.Text = "Add new Artists or new Genres";
            addArtistsOrGenresButton.UseVisualStyleBackColor = true;
            addArtistsOrGenresButton.Click += addArtistsOrGenresButton_Click;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(141, 258);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(262, 27);
            numericUpDown3.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Menu;
            label5.Location = new Point(23, 252);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 26;
            label5.Text = "Ranking:";
            // 
            // artistIdTextBox
            // 
            artistIdTextBox.Location = new Point(141, 294);
            artistIdTextBox.Name = "artistIdTextBox";
            artistIdTextBox.Size = new Size(262, 27);
            artistIdTextBox.TabIndex = 28;
            // 
            // GenreIdTextBox
            // 
            GenreIdTextBox.Location = new Point(141, 330);
            GenreIdTextBox.Name = "GenreIdTextBox";
            GenreIdTextBox.Size = new Size(262, 27);
            GenreIdTextBox.TabIndex = 29;
            // 
            // AddNewSong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(GenreIdTextBox);
            Controls.Add(artistIdTextBox);
            Controls.Add(numericUpDown3);
            Controls.Add(label5);
            Controls.Add(addArtistsOrGenresButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(GenreSelectedBox1);
            Controls.Add(ArtistsSelectedTextBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(addGenreButton);
            Controls.Add(addArtistButton);
            Controls.Add(addsongButton);
            Controls.Add(spotifyTextBox);
            Controls.Add(playtimeTextBox);
            Controls.Add(songTextBox);
            Controls.Add(spotiftyLinkLabel);
            Controls.Add(genreLabel);
            Controls.Add(playtimeLabel);
            Controls.Add(artistLabel);
            Controls.Add(songLabel);
            Name = "AddNewSong";
            Text = "AddNewSong";
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label songLabel;
        private Label artistLabel;
        private Label genreLabel;
        private Label playtimeLabel;
        private Label spotiftyLinkLabel;
        private TextBox songTextBox;
        private TextBox playtimeTextBox;
        private TextBox spotifyTextBox;
        private Button addsongButton;
        private Button addArtistButton;
        private Button addGenreButton;
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox GenreSelectedBox1;
        private TextBox ArtistsSelectedTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button addArtistsOrGenresButton;
        private NumericUpDown numericUpDown3;
        private Label label5;
        private TextBox artistIdTextBox;
        private TextBox GenreIdTextBox;
    }
}