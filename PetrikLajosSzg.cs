using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GepteremProj {
    public class PetrikLajosSzg {

        public List<Gepterem> geptermek { get; } = new List<Gepterem>();

        public PetrikLajosSzg(string filenev) {
            try {
                using (StreamReader reader = File.OpenText(filenev)) {
                    while (!reader.EndOfStream) {
                        string name = reader.ReadLine();
                        string[] split = reader.ReadLine().Split(';');
                        int sorDb = int.Parse(split[0]);
                        int helyDb = int.Parse(split[1]);
                        int[,] ertekeles = new int[sorDb, helyDb];

                        for (int i = 0; i < sorDb; i++) {
                            split = reader.ReadLine().Split(';');

                            for (int j = 0; j < helyDb; j++) {
                                ertekeles[i, j] = int.Parse(split[j]);
                            }
                        }

                        geptermek.Add(new Gepterem(name, sorDb, helyDb, ertekeles));
                        reader.ReadLine();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show($"Hiba lépett fel a fájl betöltésekor: {ex.Message}\n{ex.StackTrace}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}
