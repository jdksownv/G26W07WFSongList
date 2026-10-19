namespace G26W07WFSongList
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
            listSong = new ListBox();
            txtTitle = new TextBox();
            txtArtist = new TextBox();
            txtRating = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // listSong
            // 
            listSong.FormattingEnabled = true;
            listSong.Location = new Point(12, 12);
            listSong.Name = "listSong";
            listSong.Size = new Size(608, 349);
            listSong.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 367);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "제목";
            txtTitle.Size = new Size(150, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(168, 367);
            txtArtist.Name = "txtArtist";
            txtArtist.PlaceholderText = "가수";
            txtArtist.Size = new Size(179, 23);
            txtArtist.TabIndex = 2;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(353, 367);
            txtRating.MaxLength = 1;
            txtRating.Name = "txtRating";
            txtRating.PlaceholderText = "평점";
            txtRating.Size = new Size(156, 23);
            txtRating.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(515, 367);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 426);
            Controls.Add(btnAdd);
            Controls.Add(txtRating);
            Controls.Add(txtArtist);
            Controls.Add(txtTitle);
            Controls.Add(listSong);
            Name = "Form1";
            Text = "애창곡";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listSong;
        private TextBox txtTitle;
        private TextBox txtArtist;
        private TextBox txtRating;
        private Button btnAdd;
    }
}
