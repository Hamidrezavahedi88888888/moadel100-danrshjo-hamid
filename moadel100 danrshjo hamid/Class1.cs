namespace hamid
{
    public class Student
    {


        public string Name { get; set; }

        public string LName { get; set; }

        public double pishrafte1 { get; set; }

        public double pishraftre2 { get; set; }

        public double sheygerayi { get; set; }

        public double algoritm { get; set; }

        public double system { get; set; }

        public double riazi { get; set; }

        public double kargah { get; set; }

        public double tafsir { get; set; }

        public double zaban { get; set; }
        public double tarbiat { get; set; }
        public string names()
        {
            return $"\n=>Name:{Name}";
        }
        public double Miangin()
        {
            return Math.Round(((pishrafte1 * 3) + (pishraftre2 * 3) + (sheygerayi * 3) + (algoritm * 2) + (system * 2) + (riazi) + (kargah) + (tafsir) + (zaban) + (tarbiat)) / 18, 2);
        }

        public string Moadelzarib3()
        {
            return $" Moadelzarib3:{Math.Round(((pishrafte1 * 3) + (pishraftre2 * 3) + (sheygerayi * 3)) / 9, 2)}";
        }
        public string Moadelzarib2()
        {
            return $" Moadelzarib2: {Math.Round(((algoritm * 2) + (system * 2)) / 4, 2)}";
        }

        public string Moadelzarib1()
        {
            return $"Moadelzarib1: {Math.Round(((riazi) + (kargah) + (tafsir) + (zaban) + (tarbiat)) / 5, 2)}";
        }

    }
}
