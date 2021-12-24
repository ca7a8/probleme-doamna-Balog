using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace probleme_doamna_Balog
{
    class Program
    {
        static void Main(string[] args)
        {
            // PROBLEME CU NUMERE SI SECVENTE

            // Aici am creat un programel care faciliteaza rularea rezolvarilor mele
            int program;
            while (true)
            {
                try
                {
                    Console.WriteLine("\n Probleme rezolvate: 1  2  3  9  10  15  16  18  22  25  26  31");
                    Console.Write(" Introduceti numarul problemei a carui program doriti sa il rulati: ");
                    program = int.Parse(Console.ReadLine());
                    if (program == 1 || program == 2 || program == 3 || program == 9 || program == 10 || program == 15 || program == 16 || program == 18 || program == 22 || program == 25 || program == 26 || program == 31)
                    {
                        switch (program)
                        {
                            case 1:
                                P1();
                                break;
                            case 2:
                                P2();
                                break;
                            case 3:
                                P3();
                                break;
                            case 9:
                                P9();
                                break;
                            case 10:
                                P10();
                                break;
                            case 15:
                                P15();
                                break;
                            case 16:
                                P16();
                                break;
                            case 18:
                                P18();
                                break;
                            case 22:
                                P22();
                                break;
                            case 25:
                                P25();
                                break;
                            case 26:
                                P26();
                                break;
                            case 31:
                                P31();
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n Pentru aceasta problema nu exista program.\n Incercati din nou!");
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }
            

            Console.ReadLine();
        }


        // AICI SUNT LISTATE CODURILE REZOLVARILOR


        //###################################################################    1    ################################################################## 




        /// <summary>
        /// 1. Sa se scrie un program care converteste temperatura din grade celsius in grade fahrenheit si invers utilizand instructiunea switch.
        /// </summary>
        private static void P1()
        {
            // declararea variabilelor
            double grade = 0, grade2 = 0;
            char unitate = 'C';
            bool retry = true;
            string rezumat;

            // Afisarea descrierii programului
            rezumat = " Programul converteste temperatura din grade celsius in grade fahrenheit si invers utilizand instructiunea switch.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|\n");

            // solicitarea valorilor de la utilizator, inregistrarea lor si Gestionarea erorilor
            while (retry)
            {
                try
                {
                    Console.Write("\n Introduceti valoarea gradelor: ");
                    grade = double.Parse(Console.ReadLine());

                    Console.Write(" Introduceti unitatea de masura (c / f): ");
                    unitate = char.Parse(Console.ReadLine());

                    if (unitate != 'c' && unitate != 'f')
                    {
                        Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n Incercati din nou!");
                        retry = true;
                    }
                    else
                    {
                        retry = false;
                    }

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            // efectuarea calculelor
            switch (unitate)
            {
                case 'c':
                    grade2 = (grade * 9) / 5 + 32;
                    break;
                case 'f':
                    grade2 = (grade - 32) * 5 / 9;
                    break;
                default:
                    break;
            }

            // afisarea rezultatelor
            if (unitate == 'c')
            {
                Console.WriteLine($"  {grade}°C = {grade2}°F");
            }
            else if (unitate == 'f')
            {
                Console.WriteLine($"  {grade}°F = {grade2}°C");
            }
        }




        //###################################################################    2    ################################################################## 




        /// <summary>
        /// Să se scrie un program care efectuează mai multe operații la cererea utilizatorului, adică: 
        /// adunare, scădere, înmulțire, împărțire, radical, modulul. (Ulilizați operatorul switch pentru
        /// selectarea funcției calculatorului.). După selectarea opțiunii dorite, programul trebuie să
        /// ceară utilizatorului introducerea datelor necesare, respectiv, în cazul adunării, scăderii, 
        /// înmulțirii și împărțirii, două numere, iar în cazul radicalului și modulului, un singur număr.
        /// </summary>
        private static void P2()
        {
            // Declararea si Initializarea variabilelor
            double a = 0, b = 0;
            int operatie = 0;
            bool retry = true;
            string rezumat;

            // Afisarea descrierii programului
            rezumat = " Programul efectuează mai multe operații la cererea utilizatorului.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|\n");

            // Solicitarea operatiei de la utilizator si inregistrarea acesteia in variabila "operatie" si gestionarea erorilor
            while (retry)
            {
                try
                {
                    Console.Write("\n Introduceti cifra operatiei dorite. Adunare(1), Scadere(2), Inmultire(3), Impartire(4), Radical(5), Modul(6): ");
                    operatie = int.Parse(Console.ReadLine());
                    if (operatie > 6 || operatie < 1)
                    {
                        Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                        retry = true;
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            retry = true;

            // efectuarea calculelor, gestionarea erorilor si afisarea rezultatelor
            switch (operatie)
            {
                case 1:
                    while (retry)
                    {
                        try
                        {
                            Console.Write("\n  ADUNARE\n  Introduceti primul numar: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("  Introduceti al doilea numar: ");
                            b = double.Parse(Console.ReadLine());
                            retry = false;
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                        }
                    }
                    Console.WriteLine($"\n  {a} + {b} = {a + b}");
                    break;
                case 2:
                    while (retry)
                    {
                        try
                        {
                            Console.Write("\n  SCADERE\n  Introduceti primul numar: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("  Introduceti al doilea numar: ");
                            b = double.Parse(Console.ReadLine());
                            retry = false;
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                        }
                    }
                    Console.WriteLine($"\n  {a} - {b} = {a - b}");
                    break;
                case 3:
                    while (retry)
                    {
                        try
                        {
                            Console.Write("\n  INMULTIRE\n  Introduceti primul numar: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("  Introduceti al doilea numar: ");
                            b = double.Parse(Console.ReadLine());
                            retry = false;
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                        }
                    }
                    Console.WriteLine($"\n  {a} × {b} = {a * b}");
                    break;
                case 4:
                    while (retry)
                    {
                        try
                        {
                            Console.Write("\n  IMPARTIRE\n  Introduceti primul numar: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("  Introduceti al doilea numar: ");
                            b = double.Parse(Console.ReadLine());
                            if (b == 0)
                            {
                                Console.WriteLine("\n EROARE!!! Impartirea la 0 nu are solutii.\n\n Incercati din nou!");
                                retry = true;
                            }
                            else
                            {
                                retry = false;
                            }
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                        }
                    }
                    Console.WriteLine($"\n  {a} : {b} = {a / b}");
                    break;
                case 5:
                    while (retry)
                    {
                        try
                        {
                            Console.Write("\n  RADICAL\n  Introduceti un numar: ");
                            a = double.Parse(Console.ReadLine());
                            retry = false;
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                        }
                    }
                    Console.WriteLine($"\n  √{a} = {Math.Sqrt(a)}");
                    break;
                case 6:
                    while (retry)
                    {
                        try
                        {
                            Console.Write("\n  MODULO\n  Introduceti primul numar: ");
                            a = double.Parse(Console.ReadLine());
                            Console.Write("  Introduceti al doilea numar: ");
                            b = double.Parse(Console.ReadLine());
                            retry = false;
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                        }
                    }
                    Console.WriteLine($"\n  {a} mod {b} = {a % b}");
                    break;
                default:
                    break;
            }
        }




        //###################################################################    3    ################################################################## 




        /// <summary>
        /// Fie i,j,k. Să se determine restul împărţirii numărului natural i^j la k.
        /// </summary>
        private static void P3()
        {
            // Declararea si Initializarea variabilelor
            int i = 0, j = 0, k = 0;
            bool retry = true;
            string rezumat;

            // Afisarea descrierii programului
            rezumat = " Programul determina restul împărţirii numărului natural i^j la k.";

            for (int a = 0; a < rezumat.Length + 1; a++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int a = 0; a < rezumat.Length + 1; a++)
            {
                Console.Write("_");
            }
            Console.Write("|\n");

            // Gestionarea erorilor
            while (retry)
            {
                try
                {
                    // Solicitarea valorilor de la utilizator si schimbarea variabilelor i, j si k
                    Console.Write("\n Introduceti un numar natural pentru i: ");
                    i = int.Parse(Console.ReadLine());
                    Console.Write(" Introduceti un numar natural pentru j: ");
                    j = int.Parse(Console.ReadLine());
                    Console.Write(" Introduceti un numar natural pentru k: ");
                    k = int.Parse(Console.ReadLine());
                    if (k == 0)
                    {
                        Console.WriteLine("\n EROARE!!! Impartirea la 0 nu are solutii.\n\n Incercati din nou!");
                        retry = true;
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            // Efectuarea calculelor si afisarea rezultatelor
            Console.WriteLine($"\n Restul impartirii {i}^{j} : {k} este {Math.Pow(i, j) % k}");
        }




        //###################################################################    9    ################################################################## 




        /// <summary>
        /// Să se determine cel mai mare divizor comun şi cel mai mic multiplu comun pentru două numere întregi aşi b.
        /// </summary>
        private static void P9()
        {
            // Afisarea descrierii programului
            string rezumat = "Programul determina cel mai mare divizor comun si cel mai mic multiplu comun a doua numere naturale diferite de zero,";
            string rezumat2 = "folosind metoda lui Euclid.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            Console.Write(rezumat2);
            for (int i = 0; i < rezumat.Length - rezumat2.Length + 1; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|\n");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            // Declararea si Initializarea variabilelor
            int a = 0, b = 0, cmmdc, cmmmc, ab;
            bool retry = true;

            // Gestionarea erorilor
            while (retry)
            {
                try
                {
                    // Solicitarea valorilor de la utilizator si schimbarea variabilelor
                    Console.Write("\n\n Introduceti primul numar: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("\n Introduceti al doilea numar: ");
                    b = int.Parse(Console.ReadLine());
                    if (a < 1 || b < 1)
                    {
                        Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mica." +
                        $"\n Va rugam introduceti un numar de la 1 pana la {int.MaxValue}.\n\n Incercati din nou!");
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare." +
                        $"\n Va rugam introduceti un numar de la 1 pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }

            ab = a * b;

            // Efectuarea calculelor
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            cmmdc = a;

            cmmmc = ab / cmmdc;

            // Afisarea rezultatelor
            Console.WriteLine($"\n Cel mai mare divizor comun: {cmmdc}\n Cel mai mic multiplu comun: {cmmmc}");
        }




        //###################################################################    10    ################################################################## 




        /// <summary>
        ///  Să se afişeze primele n numere prime.
        /// </summary>
        private static void P10()
        {
            // Afisarea descrierii programului
            string rezumat = (" Programul afiseaza primele n numere prime.");

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|\n");

            // Declararea si initializarea variabilelor
            int n = 0, y = 3, x;
            bool retry = true;

            // Gestionarea erorilor
            while (retry)
            {
                try
                {
                    // Solicitarea lui n de la utilizator
                    Console.Write("\n Introduceti un numar pentru n: ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 1)
                    {
                        Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            // Afisarea rezultatelor
            if (n == 1)
            {
                Console.WriteLine("\n Primul numar prim este 2.");
            }
            else if (n >= 1)
            {
                Console.Write($"\n Primele {n} numere prime sunt: 2");
            }

            // Efectuarea calculelor
            for (int j = 2; j <= n;)
            {
                for (x = 2; x <= y - 1; x++)
                {
                    if (y % x == 0)
                        break;
                }
                if (x == y)
                {
                    Console.Write($",  {y}");
                    j++;
                }
                y++;
            }
        }




        //###################################################################    15    ################################################################## 




        /// <summary>
        /// Scrieţi un program care să calculeze factorialul unui număr întreg n.
        /// </summary>
        private static void P15()
        {
            // Afisarea descrierii programului
            string rezumat = (" Programul calculeaza factorialul unui număr întreg n.");

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|\n");

            // Declararea si initializarea variabilelor
            int n = 0, fct = 1;
            bool retry = true;

            // Gestionarea erorilor
            while (retry)
            {
                try
                {
                    // Solicitarea lui n de la utilizator
                    Console.Write("\n Introduceti un numar pentru n: ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                        retry = true;
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            // Efectuarea calculului factorialului
            for (int i = 1; i <= n; i++)
            {
                fct = fct * i;
            }

            // Afisarea rezultatelor
            Console.WriteLine($"\n Factorialul numarului {n} este {fct}.");
        }




        //###################################################################    16    ################################################################## 




        /// <summary>
        /// O carte are n foi şi r rânduri pe fiecare pagină. Câte rânduri are cartea?
        /// </summary>
        private static void P16()
        {
            // Afisarea descrierii programului
            string rezumat = (" O carte are n foi şi r rânduri pe fiecare pagină. Câte rânduri are cartea?");

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|\n");

            // Declararea si initializarea variabilelor
            int n = 0, r = 1, rezultat = 0;
            bool retry = true;

            // Gestionarea erorilor
            while (retry)
            {
                try
                {
                    // Solicitarea lui n de la utilizator
                    Console.Write("\n Introduceti un numar pentru n: ");
                    n = int.Parse(Console.ReadLine());
                    // Solicitarea lui r de la utilizator
                    Console.Write(" Introduceti un numar pentru r: ");
                    r = int.Parse(Console.ReadLine());
                    if (n < 0 || r < 0)
                    {
                        Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                        retry = true;
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            // Efectuarea calculelor
            rezultat = 2 * n * r;

            // Afisarea rezultatelor
            if (true)
            {
                Console.WriteLine($"\n O carte cu {n} foi si {r} randuri pe fiecare pagina are {rezultat} de randuri in total.");
            }
        }




        //###################################################################    18    ################################################################## 




        /// <summary>
        ///  Să se scrie un program care să citească două numere reale a şi b. Apoi să pună utilizatorului o 
        ///  întrebare: Ce doriţi să calculăm ? Media aritmetică(1) sau geometrică(2)?. Dacă se va
        ///  răspunde prin 1, se va calcula şi afişa media aritmetică, iar pentru 2 media geometrică(numai
        ///  dacă numerele sunt pozitive !, iar de nu, se va afişa ‘eroare !’). Dacă nu se răspunde prin 1 
        ///  sau 2 se va produce un sunet în difuzor.
        /// </summary>
        private static void P18()
        {
            // Afisarea descrierii programului
            string rezumat = (" Programul calculeaza media aritmetica sau geometrica a doua numere reale a si b.");

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|\n");

            // Declararea si initializarea variabilelor
            double a = 0, b = 0, ma = 0, mg = 0;
            int operatie = 0;
            bool retry = true;

            // Gestionarea erorilor
            while (retry)
            {
                try
                {
                    while (retry)
                    {
                        // Solicitarea lui a de la utilizator
                        Console.Write("\n Introduceti un numar pentru a: ");
                        a = double.Parse(Console.ReadLine());
                        if (a < 0)
                        {
                            Console.WriteLine("\n eroare !");
                        }
                        else
                        {
                            retry = false;
                        }
                    }

                    retry = true;

                    while (retry)
                    {
                        // Solicitarea lui r de la utilizator
                        Console.Write(" Introduceti un numar pentru b: ");
                        b = double.Parse(Console.ReadLine());
                        if (b < 0)
                        {
                            Console.WriteLine("\n eroare !");
                            retry = true;
                        }
                        else
                        {
                            retry = false;
                        }
                    }

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            retry = true;

            while (retry)
            {
                try
                {
                    // Solicitarea operatiei de la utilizator
                    Console.Write("\n Pentru media aritmetica introduceti 1 sau 2 pentru media geometrica: ");
                    operatie = int.Parse(Console.ReadLine());
                    if (operatie != 1 & operatie != 2)
                    {
                        // SUNET
                        SystemSounds.Beep.Play();
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (Exception)
                {
                    // SUNET
                    SystemSounds.Beep.Play();
                }
            }

            // Efectuarea calculelor
            if (operatie == 1)
            {
                ma = (a + b) / 2;

                // Afisarea rezultatului mediei aritmetice
                Console.WriteLine($"\n Media aritmetica a numerelor {a} si {b} este {ma}.");
            }
            else
            {
                mg = Math.Sqrt(a * b);

                // Afisarea rezultatului mediei geometrice
                Console.WriteLine($"\n Media geometrica a numerelor {a} si {b} este {mg}.");
            }
        }




        //###################################################################    19    ################################################################## 




        /// <summary>
        ///  Să se scrie un program care să citească trei numere reale a, b şi c, apoi să pună o întrebare de 
        ///  genul: Ce doriţi să calculăm? Aria sau perimetrul?. Dacă se va răspunde prin ‘aria’ atunci se
        ///  va calcula şi afişa aria, altfel perimetrul
        /// 
        ///     NU AM INTELES ACEASTA CERINTA
        /// 
        /// </summary>




        //###################################################################    22    ################################################################## 




        /// <summary>
        /// Să se calculeze produsul a două numere naturale prin adunări repetate. 
        /// </summary>
        private static void P22()
        {
            // Afisarea descrierii programului
            string rezumat = (" Programul calculeaza produsul a două numere naturale prin adunări repetate.");

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|\n");

            // Declararea si initializarea variabilelor
            int a = 0, b = 1, rezultat = 0;
            bool retry = true;

            // Gestionarea erorilor
            while (retry)
            {
                try
                {
                    // Solicitarea lui a de la utilizator
                    Console.Write("\n Introduceti un numar pentru a: ");
                    a = int.Parse(Console.ReadLine());
                    // Solicitarea lui b de la utilizator
                    Console.Write(" Introduceti un numar pentru b: ");
                    b = int.Parse(Console.ReadLine());
                    retry = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            // Efectuarea calculelor
            for (int i = 0; i < a; i++)
            {
                rezultat = rezultat + b;
            }

            // Afisarea rezultatelor
            if (true)
            {
                Console.Write($" = {rezultat}");
            }
        }




        //###################################################################    25    ################################################################## 




        /// <summary>
        /// Să se verifice dacă un număr este sau nu palindrom.
        /// </summary>
        private static void P25()
        {
            // Afisarea descrierii programului
            string rezumat = "Programul determina daca un numar natural n este palindrom.";

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|");

            int n = 0;
            bool retry = true;

            // Gestionarea erorilor
            while (retry)
            {
                try
                {
                    // Solicitarea unei valori de la utilizator
                    Console.Write("\n\n Introduceti un numar natural: ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("\n Valoarea introdusa nu poate fi mai mica decat zero.\n\n Incercati din nou!");
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine($"\n EROARE!!! Valoarea introdusa este prea mare/mica." +
                        $"\n Va rugam introduceti un numar de la 0 pana la {int.MaxValue}.\n\n Incercati din nou!");
                }
            }

            // CALCULELE AU FOST FACUTE IN CLASA "IntExtension.cs"

            // Afisarea rezultatelor
            if (n.IsPalindrome())
            {
                Console.WriteLine($"\n Numarul {n} este palindrom.");
            }
            else
            {
                Console.WriteLine($"\n Numarul {n} nu este palindrom.");
            }
        }




        //###################################################################    26    ################################################################## 




        /// <summary>
        ///  Să se afişeze toate numerele prime mai mici sau egale cu un numar m dat.
        /// </summary>
        private static void P26()
        {
            // Afisarea descrierii programului
            string rezumat = (" Programul afiseaza toate numerele prime mai mici sau egale cu un numar m dat.");

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|\n");

            // Declararea si initializarea variabilelor
            int m = 0;
            bool retry = true;

            // Gestionarea erorilor
            while (retry)
            {
                try
                {
                    // Solicitarea lui m de la utilizator
                    Console.Write("\n Introduceti un numar pentru m: ");
                    m = int.Parse(Console.ReadLine());
                    if (m < 2)
                    {
                        Console.WriteLine("\n Nu exista numere prime mai mici decat 2. \n Incercati din nou.");
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            // Afisarea rezultatelor
            if (m == 3)
            {
                Console.WriteLine("\n Singurul numar prim mai mic decat 3 este 2.");
            }
            else if (m > 3)
            {
                Console.Write($"\n Toate numerele prime mai mici sau egale cu {m}:\n\n");
                for (int i = 1; i <= m; i++)
                {
                    // Apelarea functiei de primalitate
                    if (EstePrim(i))
                    {
                        Console.Write($"  {i}");
                    }
                }
            }
        }

        // Functia care verifica daca un numar este prim sau nu
        private static bool EstePrim(int n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i * i <= n; i = i + 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }




        //###################################################################    31    ################################################################## 




        /// <summary>
        ///   Să se genereze toate numerele prime mai mici decât numărul natural n dat.
        /// </summary>
        private static void P31()
        {
            // Afisarea descrierii programului
            string rezumat = (" Programul genereaza toate numerele prime mai mici decat numarul natural n dat.");

            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine($"\n{rezumat} |");
            for (int i = 0; i < rezumat.Length + 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("|\n");

            // Declararea si initializarea variabilelor
            int n = 0;
            bool retry = true;

            // Gestionarea erorilor
            while (retry)
            {
                try
                {
                    // Solicitarea lui n de la utilizator
                    Console.Write("\n Introduceti un numar pentru n: ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 2)
                    {
                        Console.WriteLine("\n Nu exista numere prime mai mici decat 2. \n Incercati din nou.");
                    }
                    else
                    {
                        retry = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\n EROARE!!! Valoarea introdusa nu poate fi convertita.\n\n Incercati din nou!");
                }
            }

            // Afisarea rezultatelor
            if (n == 3)
            {
                Console.WriteLine("\n Singurul numar prim mai mic decat 3 este 2.");
            }
            else if (n > 3)
            {
                Console.Write($"\n Toate numerele prime mai mici decat {n}:\n\n");
                for (int i = 1; i < n; i++)
                {
                    // Apelarea functiei de primalitate
                    if (EstePrim(i))
                    {
                        Console.Write($"  {i}");
                    }
                }
            }
        }
    }
}



