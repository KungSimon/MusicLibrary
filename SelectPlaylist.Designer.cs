namespace MusicLibrary
{
    partial class SelectPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPlaylist));
            addToPLaylistButton = new Button();
            playListBox = new ListBox();
            SuspendLayout();
            // 
            // addToPLaylistButton
            // 
            addToPLaylistButton.Location = new Point(282, 186);
            addToPLaylistButton.Name = "addToPLaylistButton";
            addToPLaylistButton.Size = new Size(94, 29);
            addToPLaylistButton.TabIndex = 0;
            addToPLaylistButton.Text = "button1";
            addToPLaylistButton.UseVisualStyleBackColor = true;
            addToPLaylistButton.Click += addToPLaylistButton_Click;
            // 
            // playListBox
            // 
            playListBox.FormattingEnabled = true;
            playListBox.ItemHeight = 20;
            playListBox.Location = new Point(42, 74);
            playListBox.Name = "playListBox";
            playListBox.Size = new Size(196, 284);
            playListBox.TabIndex = 1;
            playListBox.SelectedIndexChanged += playListBox_SelectedIndexChanged;
            // 
            // SelectPlaylist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(playListBox);
            Controls.Add(addToPLaylistButton);
            Name = "SelectPlaylist";
            Text = "SelectPlaylist";
            Load += SelectPlaylist_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addToPLaylistButton;
        private ListBox playListBox;
    }
}