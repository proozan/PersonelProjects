namespace Ozan_Kılıç
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
            lstGames = new ListBox();
            txtGameName = new TextBox();
            numScore = new NumericUpDown();
            pbGameImage = new PictureBox();
            btnSelectImage = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGameImage).BeginInit();
            SuspendLayout();
            // 
            // lstGames
            // 
            lstGames.FormattingEnabled = true;
            lstGames.ItemHeight = 15;
            lstGames.Location = new Point(50, 83);
            lstGames.Name = "lstGames";
            lstGames.Size = new Size(183, 214);
            lstGames.TabIndex = 0;
            lstGames.SelectedIndexChanged += lstGames_SelectedIndexChanged;
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(548, 74);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(120, 23);
            txtGameName.TabIndex = 1;
            // 
            // numScore
            // 
            numScore.Location = new Point(548, 125);
            numScore.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numScore.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numScore.Name = "numScore";
            numScore.Size = new Size(120, 23);
            numScore.TabIndex = 2;
            numScore.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pbGameImage
            // 
            pbGameImage.Location = new Point(436, 164);
            pbGameImage.Name = "pbGameImage";
            pbGameImage.Size = new Size(100, 86);
            pbGameImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbGameImage.TabIndex = 3;
            pbGameImage.TabStop = false;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSelectImage.Location = new Point(432, 274);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(104, 23);
            btnSelectImage.TabIndex = 4;
            btnSelectImage.Text = "Select Picture";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(436, 332);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(104, 332);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(455, 80);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 7;
            label1.Text = "Game Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(466, 125);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 8;
            label2.Text = "Rating:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSelectImage);
            Controls.Add(pbGameImage);
            Controls.Add(numScore);
            Controls.Add(txtGameName);
            Controls.Add(lstGames);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGameImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGames;
        private TextBox txtGameName;
        private NumericUpDown numScore;
        private PictureBox pbGameImage;
        private Button btnSelectImage;
        private Button btnAdd;
        private Button btnDelete;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label2;
    }
}
