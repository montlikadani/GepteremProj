using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GepteremProj {
    public partial class Form1 : Form {

        private readonly PetrikLajosSzg petrikLajosSzg;
        private int current = 0;
        private readonly Image[] pontok = new Image[] { Properties.Resources.Pont0, Properties.Resources.Pont1, Properties.Resources.Pont2, Properties.Resources.Pont3 };

        public Form1() {
            InitializeComponent();

            petrikLajosSzg = new PetrikLajosSzg(GetResourceFileByName("petrikgepek.txt"));
            UpdatePanelItems();
        }

        private string GetResourceFileByName(string name) {
            return string.Format("{0}Resources\\{1}", Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")), name);
        }

        private void UpdatePanelItems() {
            Gepterem gepterem = petrikLajosSzg.geptermek[current];

            Text = $"{gepterem.nev} ({gepterem.TotalAverage():0.00})";

            panelPictureBox.BackgroundImage = Image.FromFile(GetResourceFileByName($"{gepterem.nev.Split()[0]}.jpg"));
            panelPictureBox.BackgroundImageLayout = ImageLayout.Stretch;

            Control.ControlCollection controlCollection = panelEvaluation.Controls;

            controlCollection.Clear();

            int size = 45;

            for (int i = 0; i < gepterem.sorDb; i++) {
                for (int j = 0; j < gepterem.helyDb; j++) {
                    PictureBox pictureBox = new PictureBox() {
                        BackgroundImage = pontok[gepterem.ertekeles[i, j]],
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = new KeyValuePair<int, int>(i, j),
                        Cursor = Cursors.Hand
                    };

                    pictureBox.SetBounds(j * size, i * size, size, size);

                    pictureBox.Click += (o, e) => {
                        if (o is PictureBox clicked && clicked.Tag is KeyValuePair<int, int> pair) {
                            switch (gepterem.ertekeles[pair.Key, pair.Value]) {
                                case 1:
                                    gepterem.ertekeles[pair.Key, pair.Value] = 2;
                                    clicked.BackgroundImage = pontok[2];
                                    break;
                                case 2:
                                    gepterem.ertekeles[pair.Key, pair.Value] = 3;
                                    clicked.BackgroundImage = pontok[3];
                                    break;
                                case 3:
                                    gepterem.ertekeles[pair.Key, pair.Value] = 3;
                                    clicked.BackgroundImage = pontok[1];
                                    break;
                                default:
                                    MessageBox.Show("Ezen a helyen nem ült senki!");
                                    break;
                            }

                            Text = $"{gepterem.nev} ({gepterem.TotalAverage():0.00})";
                        }
                    };

                    controlCollection.Add(pictureBox);
                }
            }
        }

        private void leftButton_Click(object sender, EventArgs e) {
            current--;

            if (current < 1) {
                current = petrikLajosSzg.geptermek.Count - 1;
            }

            UpdatePanelItems();
        }

        private void rightButton_Click(object sender, EventArgs e) {
            current++;

            if (current >= petrikLajosSzg.geptermek.Count) {
                current = 0;
            }

            UpdatePanelItems();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            try {
                using (StreamWriter writer = File.CreateText($"{Directory.GetCurrentDirectory()}\\petrikgepek.txt")) {
                    foreach (Gepterem gepterem in petrikLajosSzg.geptermek) {
                        writer.WriteLine($"{gepterem.nev}\n{gepterem.sorDb};{gepterem.helyDb}");

                        int last = gepterem.helyDb - 1;

                        for (int i = 0; i < gepterem.sorDb; i++) {
                            string[] row = new string[gepterem.helyDb];

                            for (int j = 0; j < last; j++) {
                                row[j] = gepterem.ertekeles[i, j].ToString();
                            }

                            writer.WriteLine(string.Join(";", row));
                        }

                        writer.WriteLine();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show($"Hiba lépett fel a fájl mentésekor: {ex.Message}\n{ex.StackTrace}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Fájl mentése sikeres", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
