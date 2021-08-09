using System;

namespace tab
{
    class Program
    {
        public static int[] LosowanieTablicy(int rozmiar , int minLiczba, int maxLiczba){
            int[] tab = new int[rozmiar];
            Random rand = new Random();
            for( int i = 0 ; i < tab.Length; i++){
                tab[i] = rand.Next(minLiczba, maxLiczba);
            }
            return tab;
        }
        public static void wypisywanie(int[] tab){
            foreach(int val in tab){
                Console.Write(val + "  ");
            }
        }
        public static int wymiarTab(){
            Console.WriteLine("Jaki rozmiar ma mieć tablica");
            int rozmiar = Convert.ToInt32(Console.ReadLine());
            if(rozmiar <= 0){
                Console.WriteLine("Podaj wartość większą od 0");
                rozmiar = Convert.ToInt32(Console.ReadLine());
            }
            return rozmiar;
        }
        public static int minRand(){
            Console.WriteLine("Podaj minimalną warotosc do losowania liczb: ");
            int min = Convert.ToInt32(Console.ReadLine());
            return min;
        }
        public static int maxRand(){
            Console.WriteLine("Podaj maksymalną wartość do losowania liczb: ");
            int max = Convert.ToInt32(Console.ReadLine());
            return max;
        }
        public static bool checkMinMax(int minLiczba, int maxLiczba){
            bool check = false;
            do{
                if(minLiczba >= maxLiczba){
                    Console.WriteLine("Zły dobór liczb, liczba minimalna musi być mniejsza od maksymalnej");
                    Console.WriteLine("Podaj wartorść minimalną");
                    minLiczba = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj wartorść maksymalną");
                    maxLiczba = Convert.ToInt32(Console.ReadLine());
                }
                else{
                    check = true;
                }
            }while(check == false);
            return check;
        }
        public static void sumaTab(int[] tab){
            int suma = 0;
            for(int i = 0; i < tab.Length; i++){
                suma += tab[i];
            }
            Console.WriteLine("Suma elementów wynosi " + suma);
        }
        public static void roznicaTab(int[] tab)
        {
            int roznica = 0;
            for(int i = 0; i < tab.Length; i++){
                roznica -= tab[i];
            }
            Console.WriteLine("Roznica wynosi: " + roznica);
        }
        public static void iloczynTab(int[] tab)
        {
            int iloczyn = 1;
            for(int i = 0; i < tab.Length; i++){
                iloczyn *= tab[i];
            }
            Console.WriteLine("Iloczyn wynosi : "+  iloczyn);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Oto kilka zastosowanie tablic:");
            int[] tablica, tablica2;
            int rozmiarTab = wymiarTab();
            int min = minRand();
            int max = maxRand();
            bool minMax = checkMinMax(min, max);
            tablica = LosowanieTablicy(rozmiarTab, min, max);
            wypisywanie(tablica);
            Console.WriteLine("Wybierz odpowiednia liczbe a ja to zrobie:");
            Console.WriteLine("1. Oblicz sume tablicy");
            Console.WriteLine("2. Oblicz różnice tablicy");
            Console.WriteLine("3. Oblicz iloczyn tablicy");
            int wybor = Convert.ToInt16(Console.ReadLine());
            switch(wybor){
                case 1:
                    sumaTab(tablica);
                    break;
                case 2: 
                    roznicaTab(tablica);
                    break;
                case 3: 
                    iloczynTab(tablica);
                    break;
            }
        }
    }
}
