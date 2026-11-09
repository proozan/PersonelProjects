using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ozan_Kılıç
{
    public partial class Form1 : Form
    {
        List<Game> gameLibrary = new List<Game>();
        string selectedImagePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Game Image";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog1.FileName;
                pbGameImage.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGameName.Text) || string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Please enter a game name and select an image!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Game newGame = new Game
            {
                Name = txtGameName.Text,
                Score = (int)numScore.Value,
                ImagePath = selectedImagePath
            };

            gameLibrary.Add(newGame);
            UpdateList();

            txtGameName.Clear();
            numScore.Value = 1;
            pbGameImage.Image = null;
            selectedImagePath = "";
        }

        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGames.SelectedIndex != -1)
            {
                Game selectedGame = gameLibrary[lstGames.SelectedIndex];

                txtGameName.Text = selectedGame.Name;
                numScore.Value = selectedGame.Score;
                pbGameImage.Image = Image.FromFile(selectedGame.ImagePath);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstGames.SelectedIndex != -1)
            {
                gameLibrary.RemoveAt(lstGames.SelectedIndex);
                UpdateList();
                pbGameImage.Image = null;
                txtGameName.Clear();
            }
        }

        private void UpdateList()
        {
            lstGames.Items.Clear();
            foreach (var game in gameLibrary)
            {
                lstGames.Items.Add(game);
            }
        }
    }
}