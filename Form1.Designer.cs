namespace MusicLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            searchButton = new Button();
            linkLabel = new LinkLabel();
            pressLabel = new Label();
            searchListBox = new ListBox();
            infoLabel = new Label();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            tabPage2 = new TabPage();
            addToPlayListButton = new Button();
            deleteButton = new Button();
            uppdateInfoButton = new Button();
            spotifyLinkLabel1 = new LinkLabel();
            genreLabel = new Label();
            artistLabel = new Label();
            songLabel = new Label();
            rankLabel = new Label();
            label1 = new Label();
            topListBox = new ListBox();
            tabPage3 = new TabPage();
            songsInPlaylistLabel = new Label();
            songsInPlayListBox = new ListBox();
            PlayListListenLabel = new Label();
            playListLabel = new Label();
            playListBox = new ListBox();
            addNewSongButton = new Button();
            logoutButton = new Button();
            registerButton = new Button();
            loginButton = new Button();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            fontDialog1 = new FontDialog();
            linkLabel11 = new LinkLabel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-3, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(825, 471);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(searchButton);
            tabPage1.Controls.Add(linkLabel);
            tabPage1.Controls.Add(pressLabel);
            tabPage1.Controls.Add(searchListBox);
            tabPage1.Controls.Add(infoLabel);
            tabPage1.Controls.Add(searchLabel);
            tabPage1.Controls.Add(searchTextBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(817, 438);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(454, 72);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new Point(234, 389);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(97, 20);
            linkLabel.TabIndex = 6;
            linkLabel.TabStop = true;
            linkLabel.Text = "Select a song";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // pressLabel
            // 
            pressLabel.AutoSize = true;
            pressLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            pressLabel.ForeColor = SystemColors.Window;
            pressLabel.Location = new Point(6, 380);
            pressLabel.Name = "pressLabel";
            pressLabel.Size = new Size(222, 31);
            pressLabel.TabIndex = 5;
            pressLabel.Text = "Press here to listen:";
            // 
            // searchListBox
            // 
            searchListBox.FormattingEnabled = true;
            searchListBox.ItemHeight = 20;
            searchListBox.Location = new Point(6, 190);
            searchListBox.Name = "searchListBox";
            searchListBox.Size = new Size(805, 104);
            searchListBox.TabIndex = 3;
            searchListBox.SelectedIndexChanged += searchListBox_SelectedIndexChanged;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabel.ForeColor = SystemColors.Window;
            infoLabel.Location = new Point(6, 101);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(497, 31);
            infoLabel.TabIndex = 2;
            infoLabel.Text = "Search either for a song, artist or by an genre";
            infoLabel.Click += infoLabel_Click;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.ForeColor = SystemColors.Window;
            searchLabel.Location = new Point(3, 74);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(56, 20);
            searchLabel.TabIndex = 1;
            searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(65, 71);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(351, 27);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.Controls.Add(addToPlayListButton);
            tabPage2.Controls.Add(deleteButton);
            tabPage2.Controls.Add(uppdateInfoButton);
            tabPage2.Controls.Add(spotifyLinkLabel1);
            tabPage2.Controls.Add(genreLabel);
            tabPage2.Controls.Add(artistLabel);
            tabPage2.Controls.Add(songLabel);
            tabPage2.Controls.Add(rankLabel);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(topListBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(817, 438);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Top Songs";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // addToPlayListButton
            // 
            addToPlayListButton.Location = new Point(458, 366);
            addToPlayListButton.Name = "addToPlayListButton";
            addToPlayListButton.Size = new Size(116, 29);
            addToPlayListButton.TabIndex = 15;
            addToPlayListButton.Text = "Add to playlist";
            addToPlayListButton.UseVisualStyleBackColor = true;
            addToPlayListButton.Visible = false;
            addToPlayListButton.Click += addToPlayListButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(700, 366);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // uppdateInfoButton
            // 
            uppdateInfoButton.Location = new Point(591, 366);
            uppdateInfoButton.Name = "uppdateInfoButton";
            uppdateInfoButton.Size = new Size(94, 29);
            uppdateInfoButton.TabIndex = 13;
            uppdateInfoButton.Text = "Update";
            uppdateInfoButton.UseVisualStyleBackColor = true;
            uppdateInfoButton.Visible = false;
            uppdateInfoButton.Click += uppdateInfoButton_Click;
            // 
            // spotifyLinkLabel1
            // 
            spotifyLinkLabel1.AutoSize = true;
            spotifyLinkLabel1.Location = new Point(239, 409);
            spotifyLinkLabel1.Name = "spotifyLinkLabel1";
            spotifyLinkLabel1.Size = new Size(101, 20);
            spotifyLinkLabel1.TabIndex = 12;
            spotifyLinkLabel1.TabStop = true;
            spotifyLinkLabel1.Text = "Select a song!";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            genreLabel.ForeColor = SystemColors.Window;
            genreLabel.Location = new Point(206, 5);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(68, 28);
            genreLabel.TabIndex = 11;
            genreLabel.Text = "Genre";
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            artistLabel.ForeColor = SystemColors.Window;
            artistLabel.Location = new Point(134, 5);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(66, 28);
            artistLabel.TabIndex = 10;
            artistLabel.Text = "Artist";
            // 
            // songLabel
            // 
            songLabel.AutoSize = true;
            songLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            songLabel.ForeColor = SystemColors.Window;
            songLabel.Location = new Point(69, 5);
            songLabel.Name = "songLabel";
            songLabel.Size = new Size(59, 28);
            songLabel.TabIndex = 9;
            songLabel.Text = "Song";
            // 
            // rankLabel
            // 
            rankLabel.AutoSize = true;
            rankLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rankLabel.ForeColor = SystemColors.Window;
            rankLabel.Location = new Point(11, 5);
            rankLabel.Name = "rankLabel";
            rankLabel.Size = new Size(59, 28);
            rankLabel.TabIndex = 8;
            rankLabel.Text = "Rank";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(11, 400);
            label1.Name = "label1";
            label1.Size = new Size(222, 31);
            label1.TabIndex = 7;
            label1.Text = "Press here to listen:";
            // 
            // topListBox
            // 
            topListBox.FormattingEnabled = true;
            topListBox.ItemHeight = 20;
            topListBox.Location = new Point(11, 36);
            topListBox.Name = "topListBox";
            topListBox.Size = new Size(795, 324);
            topListBox.TabIndex = 0;
            topListBox.SelectedIndexChanged += topListBox_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.Controls.Add(linkLabel11);
            tabPage3.Controls.Add(songsInPlaylistLabel);
            tabPage3.Controls.Add(songsInPlayListBox);
            tabPage3.Controls.Add(PlayListListenLabel);
            tabPage3.Controls.Add(playListLabel);
            tabPage3.Controls.Add(playListBox);
            tabPage3.Controls.Add(addNewSongButton);
            tabPage3.Controls.Add(logoutButton);
            tabPage3.Controls.Add(registerButton);
            tabPage3.Controls.Add(loginButton);
            tabPage3.Controls.Add(passwordLabel);
            tabPage3.Controls.Add(passwordTextBox);
            tabPage3.Controls.Add(usernameLabel);
            tabPage3.Controls.Add(usernameTextBox);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(817, 438);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Log In";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // songsInPlaylistLabel
            // 
            songsInPlaylistLabel.AutoSize = true;
            songsInPlaylistLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            songsInPlaylistLabel.ForeColor = SystemColors.Window;
            songsInPlaylistLabel.Location = new Point(512, 60);
            songsInPlaylistLabel.Name = "songsInPlaylistLabel";
            songsInPlaylistLabel.Size = new Size(196, 31);
            songsInPlaylistLabel.TabIndex = 13;
            songsInPlaylistLabel.Text = "Songs in playlist:";
            songsInPlaylistLabel.Visible = false;
            // 
            // songsInPlayListBox
            // 
            songsInPlayListBox.FormattingEnabled = true;
            songsInPlayListBox.ItemHeight = 20;
            songsInPlayListBox.Location = new Point(512, 94);
            songsInPlayListBox.Name = "songsInPlayListBox";
            songsInPlayListBox.Size = new Size(265, 304);
            songsInPlayListBox.TabIndex = 12;
            songsInPlayListBox.Visible = false;
            songsInPlayListBox.SelectedIndexChanged += songsInPlayListBox_SelectedIndexChanged;
            // 
            // PlayListListenLabel
            // 
            PlayListListenLabel.AutoSize = true;
            PlayListListenLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PlayListListenLabel.ForeColor = SystemColors.Window;
            PlayListListenLabel.Location = new Point(0, 404);
            PlayListListenLabel.Name = "PlayListListenLabel";
            PlayListListenLabel.Size = new Size(222, 31);
            PlayListListenLabel.TabIndex = 11;
            PlayListListenLabel.Text = "Press here to listen:";
            PlayListListenLabel.Visible = false;
            // 
            // playListLabel
            // 
            playListLabel.AutoSize = true;
            playListLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            playListLabel.ForeColor = SystemColors.Window;
            playListLabel.Location = new Point(109, 60);
            playListLabel.Name = "playListLabel";
            playListLabel.Size = new Size(163, 31);
            playListLabel.TabIndex = 10;
            playListLabel.Text = "Your playlists:";
            playListLabel.Visible = false;
            // 
            // playListBox
            // 
            playListBox.FormattingEnabled = true;
            playListBox.ItemHeight = 20;
            playListBox.Location = new Point(114, 94);
            playListBox.Name = "playListBox";
            playListBox.Size = new Size(265, 304);
            playListBox.TabIndex = 8;
            playListBox.Visible = false;
            playListBox.SelectedIndexChanged += playListBox_SelectedIndexChanged;
            // 
            // addNewSongButton
            // 
            addNewSongButton.Location = new Point(683, 6);
            addNewSongButton.Name = "addNewSongButton";
            addNewSongButton.Size = new Size(128, 42);
            addNewSongButton.TabIndex = 7;
            addNewSongButton.Text = "Add a new song";
            addNewSongButton.UseVisualStyleBackColor = true;
            addNewSongButton.Visible = false;
            addNewSongButton.Click += addNewSongButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(6, 6);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(115, 41);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "Log out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Visible = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(677, 6);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(129, 29);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(132, 123);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(129, 29);
            loginButton.TabIndex = 4;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = SystemColors.Window;
            passwordLabel.Location = new Point(6, 74);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(97, 25);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(114, 75);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(219, 27);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = SystemColors.Window;
            usernameLabel.Location = new Point(6, 31);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(102, 25);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(114, 32);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(219, 27);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // linkLabel11
            // 
            linkLabel11.AutoSize = true;
            linkLabel11.Location = new Point(228, 413);
            linkLabel11.Name = "linkLabel11";
            linkLabel11.Size = new Size(101, 20);
            linkLabel11.TabIndex = 14;
            linkLabel11.TabStop = true;
            linkLabel11.Text = "Select a song!";
            linkLabel11.LinkClicked += linkLabel11_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 466);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Music Library";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label searchLabel;
        private TextBox searchTextBox;
        private FontDialog fontDialog1;
        private Label pressLabel;
        private ListBox searchListBox;
        private Label infoLabel;
        private Label label1;
        private ListBox topListBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private Button loginButton;
        private LinkLabel linkLabel;
        private Label genreLabel;
        private Label artistLabel;
        private Label songLabel;
        private Label rankLabel;
        private LinkLabel spotifyLinkLabel1;
        private Button deleteButton;
        private Button uppdateInfoButton;
        private Button registerButton;
        private Button logoutButton;
        private Button addNewSongButton;
        private Button searchButton;
        private Button addToPlayListButton;
        private Label PlayListListenLabel;
        private Label playListLabel;
        private ListBox playListBox;
        private Label songsInPlaylistLabel;
        private ListBox songsInPlayListBox;
        private LinkLabel linkLabel11;
    }
}