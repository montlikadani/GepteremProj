namespace GepteremProj {
    public class Gepterem {

        public readonly int[,] ertekeles;
        public readonly int helyDb;
        public readonly string nev;
        public readonly int sorDb;

        public Gepterem(string nev, int sorDb, int helyDb, int[,] ertekeles) {
            this.nev = nev;
            this.sorDb = sorDb;
            this.helyDb = helyDb;
            this.ertekeles = ertekeles;
        }

        public double TotalAverage() {
            double total = 0;
            int count = 0;

            for (int i = 0; i < sorDb; i++) {
                for (int j = 0; j < helyDb; j++) {
                    int one = ertekeles[i, j];

                    if (one > 0) {
                        total += one;
                        count++;
                    }
                }
            }

            return total / count;
        }
    }
}
