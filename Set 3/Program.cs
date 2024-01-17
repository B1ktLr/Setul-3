using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Set_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt;
            bool e = true;
            Console.WriteLine("Lista exercitii:");
            Console.WriteLine("0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31");
            while (e)
            {
                Console.Write("Introduceti exercitiul:");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 0:

                        Console.WriteLine("Iesire");
                        e = false;
                        break;
                        case 1:
                        {
                            E1(); break;
                        }
                        case 2:
                        {
                            E2(); break;
                        }
                        case 3:
                        {
                            E3(); break;
                        }
                        case 4:
                        {
                            E4(); break;
                        }
                        case 5:
                        {
                            E5(); break;
                        }
                        case 6:
                        {
                            E6(); break;
                        }
                        case 7:
                        {
                            E7(); break;
                        }
                        case 8:
                        {
                            E8(); break;
                        }
                        case 9:
                        {
                            E9(); break;                        
                        }
                        case 10:
                        {
                            E10(); break;                        
                        }
                        case 11:
                        {
                            E11(); break;
                        }
                        case 12:
                        {
                            E12(); break;
                        }
                        case 13:
                        {
                            E13(); break;
                        }
                        case 14:
                        {
                            E14(); break;
                        }
                        case 15:
                        {
                            E15(); break;
                        }
                        case 16:
                        {
                            E16(); break;
                        }
                        case 17:
                        {
                            E17(); break;
                        }
                        case 18:
                        {
                            E18(); break;
                        }
                        case 19:
                        {
                            E19(); break;
                        }
                        case 20:
                        {
                            E20(); break;
                        }
                        case 21:
                        {
                            E21(); break;
                        }
                        case 22:
                        {
                            E22(); break;
                        }
                        case 23:
                        {
                            E23(); break;
                        }
                        case 24:
                        {
                            E24(); break;
                        }
                        case 25:
                        {
                            E25(); break;
                        }
                        case 26:
                        {
                            E26(); break;
                        }
                        case 27:
                        {
                            E27(); break;
                        }
                        case 28:
                        {
                            E28(); break;
                        }
                        case 29:
                        {
                            E29(); break;
                        }
                        case 30:
                        {
                            E30(); break;
                        }
                        case 31:
                        {
                            E31(); break;
                        }


                }
            }
        }

        private static void E31()
        {
            int[] v = new int[100];
            int[] q = new int[10000000];
            int n, c;
            Console.WriteLine("Dati numarul de elemente din vector:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului");
            for (c = 0; c < n; c++)
            {
                v[c] = int.Parse(Console.ReadLine());
            }
            for (c = 0; c < q.Length; c++)
            {
                q[c] = 0;
            }
            for (c = 0; c < n; c++)
            {
                q[v[c]]++;
            }
            bool gasit=false;
            for(c=0; c < q.Length; c++)
            {
                if (q[c] > n / 2)
                {
                    Console.WriteLine("Elementul majoritate este " + q[c]);
                    gasit = true;
                    break;
                }
                if (gasit==false)
                    Console.WriteLine("<nu exista>");
            }
            Console.ReadKey();

        }

        private static void E30()
        {
            int[] e = new int[100];
            int[] w = new int[100];
            int n, c, aux1, aux2;
            Console.WriteLine("Dati numarul de elemente din vector:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < n; c++)
            {
                e[c] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dati ponderea elementelor din vector:");
            for(c = 0; c < n; c++)
            {
                w[c] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i < n-1; i++)
            {
                for(int j=0; j < n-1-i; j++)
                {
                    if (e[j] > e[j+1])
                    {
                        aux1 = e[j];
                        e[j] = e[j+1];
                        e[j+1] = aux1;

                        aux2 = w[j];
                        w[j] = w[j+1];
                        w[j+1] = aux2;
                    }
                }
            }

            for(int j=0; j<n ;j++)
            {
                if (e[j] == e[j+1])
                {
                    if (w[j] > w[j+1])
                    { 
                        aux1 = w[j];
                        w[j] = w[j+1];
                        w[j+1] = aux1;
                    }
                }
            }
            Console.WriteLine("Vectorul ordonat crescator, cu ponderile aferente este:");
            for(c=0; c < n; c++)
            {
                Console.Write(e[c] + ",");
                Console.WriteLine(w[c]);
            }
            Console.ReadKey();
        }

        private static void E29()
        {
            int[] v = new int[100];
            int n, c;
            Console.WriteLine("Dati numarul de elemente din vector:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului");
            for (c = 0; c < n; c++)
            {
                v[c] = int.Parse(Console.ReadLine());
            }

            MergeSort(v, 0, n - 1);

            Console.WriteLine("Vectorul sortat este:");
            for (c = 0; c < n; c++)
            {
                v[c] = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }

        private static void MergeSort(int[] v, int st, int dr)
        {
            int[] tmp = new int[100];
            if (st < dr)
            {
                int m = (st + dr) / 2;
                MergeSort(v, st, m);
                MergeSort(v, m + 1, dr);
                int i = st, j = m + 1, k = 0;
                while (i <= m && j <= dr)
                    if (v[i] < v[j])
                        tmp[++k] = v[i++];
                    else
                        tmp[++k] = v[j++];
                while (i <= m)
                    tmp[++k] = v[i++];
                while (j <= dr)
                    tmp[++k] = v[j++];
                for (i = st, j = 1; i <= dr; i++, j++)
                    v[i] = tmp[j];
            }
        }

        private static void E28()
        {
            int[] v = new int[100];
            int n, c;
            Console.WriteLine("Dati numarul de elemente din vector:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului");
            for (c = 0; c < n; c++)
            {
                v[c] = int.Parse(Console.ReadLine());
            }

            QuickSort(v, 0, n - 1);

            Console.WriteLine("Vectorul sortat este:");
            for (c = 0; c < n; c++)
            {
                v[c] = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }

        private static void QuickSort(int[] v, int st, int dr)
        {
            if (st < dr)
            {
                int m = (st + dr) / 2;
                int aux = v[st];
                v[st] = v[m];
                v[m] = aux;
                int i = st, j = dr, d = 0;
                while (i < j)
                {
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                        d = 1 - d;
                    }
                    i += d;
                    j -= 1 - d;
                }
                QuickSort(v, st, i - 1);
                QuickSort(v, i + 1, dr);
            }
        }

        private static void E27()
        {
            int p, c, aux, n;
            int[] v=new int[100];
            int[] copie=new int[100];
            Console.WriteLine("Dati numarul de elemente din vector:");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Dati un indice din vector:");
            p=int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului");
            for(c=0; c<n; c++)
            {
                v[c]=int.Parse(Console.ReadLine());
                copie[c] = v[c];
            }
            for(int i=0;i < n-1 ;i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (copie[j] > copie[j + 1])
                    {
                        aux = copie[j];
                        copie[j] = copie[j + 1];
                        copie[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("Valoarea de pe pozitia " + p + " dupa sortare este" + v[p]);
            Console.ReadKey();
        }

        private static void E26()
        {
            long n, m;
            int[] v1 = new int[100];
            int[] v2 = new int[100];
            int[] v3 = new int[100];
            int c=0, i=0, a=0, b, p;
            Console.WriteLine("Dati 2 numere:");
            Console.Write("Nr 1:");
            n = long.Parse(Console.ReadLine());
            Console.Write("Nr 2:");
            m = long.Parse(Console.ReadLine());
            while(n != 0)
            {
                v1[c] = (int)(n % 10); 
                c++;
                n = n / 10;
            }
            while(m != 0)
            {
                v2[c]=(int)(m % 10); 
                i++;
                n = n / 10;
            }
            if (i > c)
                p = i;
            else
                p = c;
            Console.WriteLine("Suma numerelor este:");
            while(a < p)
            {
                v3[a] = v1[a] + v2[a];

                if (v3[a] > 9)
                {
                    v3[a + 1] = v3[a] / 10;
                    v3[a] = v3[a] % 10;
                }
                a++;
            }
            for(a = p; a >= 0; a--)
            {
                Console.WriteLine(v3[a]);
            }
            Console.WriteLine();

            Console.WriteLine("Diferenta numerelor este:");
            a = p;
            while(a > 0)
            {
                v3[a] = v1[a-1] - v2[a-1];
                if (v3[a] < 0)
                {
                    v3[a - 1]--;
                    v3[a] += 10;
                }
                a--;
            }
            for (a = p; a >= 0; a--)
            {
                Console.WriteLine(v3[a]);
            }
            Console.WriteLine();

            int s = 0,nr=0,multi;
            Console.WriteLine("Produsul numerelor este:");
            for (a = 0; a < p; a++)
            {
                multi = 1;
                for (b = 0; b < p; b++)
                {
                    nr = nr + (v1[a] * v2[b])*multi;
                    multi *= 10;
                }
                s += nr;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }

        private static void E25()
        {
            int[] v1 = new int[100];
            int[] v2 = new int[100];
            int[] v3 = new int[100];
            int n, c, m, a=0, b=0;
            Console.WriteLine("Cate nr are primul vector:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele din primul vector:");
            for (c = 0; c < n; c++)
            {
                v1[c] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cate nr are cel de al doilea vector vector:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele celui de al doilea vector:");
            for (c = 0; c < m; c++)
            {
                v2[c] = int.Parse(Console.ReadLine());
            }
            c = 0;
            while (a < n && b < m)
            {
                if (v1[a] < v2[b])
                {
                    v3[c] = v1[a];
                    a++;
                    c++;
                }
                else
                {
                    v3[c] = v2[b];
                    b++;
                    c++;
                }
            }
            while (a < n)
            {
                v3[c] = v1[a];
                a++;
                c++;
            }
            while (b < m)
            {
                v3[c] = v2[b];
                b++;
                c++;
            }

            Console.WriteLine("Cei doi vectori ordonati crescator interclasat sunt:");
            for (c = 0; c < (m+n); c++)
            {
                Console.Write(v3[c] + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void E24()
        {
            int[] v1 = new int[100];
            int[] v2 = new int[100];
            int n, c, m, q, i;
            Console.WriteLine("Cate nr are primul vector:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele din primul vector sub forma binara:");
            for (c = 0; c < n; c++)
            {
                v1[c] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cate nr are cel de al doilea vector vector:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele celui de al doilea vector sub forma binara:");
            for (c = 0; c < m; c++)
            {
                v2[c] = int.Parse(Console.ReadLine());
            }


            for (c = 0; c < n; c++)
            {
                if (v1[c] == v1[c + 1])
                    for (i = c; i < n; i++)
                    {
                        v1[i] = v1[i + 1];
                    }
                n--;
                c--;
            }
            for (c = 0; c < m; c++)
            {
                if (v2[c] == v2[c + 1])
                    for (i = c; i < m; i++)
                    {
                        v2[i] = v2[i + 1];
                    }
                m--;
                c--;
            }

            if (n < m)
                q = m;
            else
                q = n;


            Console.WriteLine("Intersectia celor 2 vector este:");
            for (c = 0; c < q; c++)
            {
                if (v1[c] == v2[c])
                    Console.Write(v1[c] + ",");
                else
                    Console.Write(v1[c] + "," + v2[c] + ",");
            }
            Console.WriteLine("Reuniunea celor 2 vectori este:");
            for (c = 0; c < q; c++)
            {
                if (v1[c] == v2[c])
                    Console.Write(v1[c] + ",");
            }
            Console.WriteLine("Diferenta dintre v1-v2 este");
            for (c = 0; c < q; c++)
            {
                if ((v1[c] != v2[c]))
                    Console.Write(v1[c] + ",");
            }
            Console.WriteLine("Diferenta dintre v2-v1 este");
            for (c = 0; c < q; c++)
            {
                if ((v1[c] != v2[c]))
                    Console.Write(v2[c] + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void E23()
        {
            int[] v1 = new int[100];
            int[] v2 = new int[100];
            int n, c, m, q, i;
            Console.WriteLine("Cate nr are primul vector:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele din primul vector in ordine crescatoare:");
            for (c = 0; c < n; c++)
            {
                v1[c] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cate nr are cel de al doilea vector vector:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele celui de al doilea vector in ordine crescatoare:");
            for (c = 0; c < m; c++)
            {
                v2[c] = int.Parse(Console.ReadLine());
            }


            for (c = 0; c < n; c++)
            {
                if (v1[c] == v1[c + 1])
                    for (i = c; i < n; i++)
                    {
                        v1[i] = v1[i + 1];
                    }
                n--;
                c--;
            }
            for (c = 0; c < m; c++)
            {
                if (v2[c] == v2[c + 1])
                    for (i = c; i < m; i++)
                    {
                        v2[i] = v2[i + 1];
                    }
                m--;
                c--;
            }

            if (n < m)
                q = m;
            else
                q = n;


            Console.WriteLine("Intersectia celor 2 vector este:");
            for (c = 0; c < q; c++)
            {
                if (v1[c] == v2[c])
                    Console.Write(v1[c] + ",");
                else
                    Console.Write(v1[c] + "," + v2[c] + ",");
            }
            Console.WriteLine("Reuniunea celor 2 vectori este:");
            for (c = 0; c < q; c++)
            {
                if (v1[c] == v2[c])
                    Console.Write(v1[c] + ",");
            }
            Console.WriteLine("Diferenta dintre v1-v2 este");
            for (c = 0; c < q; c++)
            {
                if ((v1[c] != v2[c]))
                    Console.Write(v1[c] + ",");
            }
            Console.WriteLine("Diferenta dintre v2-v1 este");
            for (c = 0; c < q; c++)
            {
                if ((v1[c] != v2[c]))
                    Console.Write(v2[c] + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void E22()
        {
            int[] v1 = new int[100];
            int[] v2 = new int[100];
            int n, c, m, q, i;
            Console.WriteLine("Cate nr are primul vector:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele din primul vector:");
            for (c = 0; c < n; c++)
            {
                v1[c] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cate nr are cel de al doilea vector vector:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele celui de al doilea vector:");
            for (c = 0; c < m; c++)
            {
                v2[c] = int.Parse(Console.ReadLine());
            }

            
            for(c = 0; c < n; c++)
            {
                if (v1[c] == v1[c + 1])
                    for(i=c; i<n; i++)
                    {
                        v1[i] = v1[i + 1];
                    }
                n--;
                c--;
            }
            for (c = 0; c < m; c++)
            {
                if (v2[c] == v2[c + 1])
                    for (i = c; i < m; i++)
                    {
                        v2[i] = v2[i + 1];
                    }
                m--;
                c--;
            }

            if (n < m)
                q = m;
            else
                q = n;


            Console.WriteLine("Intersectia celor 2 vector este:");
            for(c = 0; c < q; c++)
            {
                if(v1[c] == v2[c])
                Console.Write(v1[c] + ",");
                else
                Console.Write(v1[c] + "," + v2[c] + ",");
            }
            Console.WriteLine("Reuniunea celor 2 vectori este:");
            for(c=0; c < q; c++)
            {
                if (v1[c] == v2[c])
                    Console.Write(v1[c] + ",");
            }
            Console.WriteLine("Diferenta dintre v1-v2 este");
            for(c=0; c < q; c++)
            {
                if ((v1[c] != v2[c]))
                    Console.Write(v1[c] + ",");
            }    
            Console.WriteLine("Diferenta dintre v2-v1 este");
            for(c=0; c < q; c++)
            {
                if ((v1[c] != v2[c]))
                    Console.Write(v2[c] + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void E21()
        {
            char[] v1 = new char[100];
            char[] v2 = new char[100];
            int n, c, ord = 0;
            Console.WriteLine("Cate nr au cei 2 vectori:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele din primul vector:");
            for(c = 0; c < n; c++)
            {
                v1[c]=char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dati elementele celui de al doilea vector:");
            for(c=0; c < n; c++)
            {
                v2[c]=char.Parse(Console.ReadLine());
            }
            for(c=0; c < n; c++)
            {
                if (v1[c] > v2[c])
                    ord++;
                else if (v1[c] < v2[c])
                    ord--;
            }
            if (ord > 0)
                Console.WriteLine("Primul vector este mai mare lexicografic");
            else if (ord < 0)
                Console.WriteLine("Primul vector este mai mic lexicografic");
            else
                Console.WriteLine("Dacă cele n elemente sunt egale");

            Console.ReadKey();

        }

        private static void E20()
        {
            char[] s1 = new char[100];
            char[] s2 = new char[100];
            int n, c, supra=0;
            Console.WriteLine("Cate nr au cele 2 siraguri principal:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Mergelele sunt de 2 culori: a = Alb ; n = Negru");
            Console.WriteLine("Dati culorile primului sirag de margele:");
            for (c = 0; c < n; c++)
            {
                s1[c] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dati culorile celui de al doilea sirag de margele:");
            for (c = 0; c < n; c++)
            {
                s2[c] = char.Parse(Console.ReadLine());
            }
            for(c = 0; c < n; c++)
            {
                if (s1[c] == s2[c])
                supra++;
            }
            Console.WriteLine("Sunt" + supra + "margele suprapuse");
            Console.ReadKey();
        }

        private static void E19()
        {
            int[] s = new int[100];
            int[] p = new int[100];
            int n, m, c;
            Console.WriteLine("Cate nr are vectorul principal:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < n; c++)
            {
                s[c] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cate nr are vectorul care se cauta in cel principal:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < m; c++)
            {
                p[c] = int.Parse(Console.ReadLine());
            }
            bool gasit;
            int repetari = 0;
            for (c = 0; c <= n - m; c++)
            {
                gasit = true;
                for (int i = 0; i < m; i++)
                {
                    if (s[c + i] != p[i])
                    {
                        gasit = false;
                        break;
                    }
                }
                if (gasit)
                    repetari++;
            }
            Console.WriteLine("Vectorul cautat se gaseste de " + repetari + " ori in vectorul principal");
            Console.ReadKey();
        }

        private static void E18()
        {
            int[] v = new int[100];
            int c, x, n, s=0;
            Console.WriteLine("Cati coeficienti are polinomul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati coeficienti polinomului:");
            for (c = 0; c < n; c++)
            {
                v[c] = int.Parse(Console.ReadLine());
            }
            for (int i = -100; i <= 100; i++)
            {
                x = i;
                s = 0;
                for (c = 0; c < n; c++)
                {
                    s = s + v[c] * (int)Math.Pow(x, c);
                }
                if (s == 0)
                {
                    Console.WriteLine("O solutie a polinomului este:" + x);
                    break;
                }

            }
            if (s != 0)
                Console.WriteLine("Solutiile polinomului nu sunt intregi sau nu se afla in intervalul [-100,100]");

            Console.ReadKey();
        }

        private static void E17()
        {
            int n, b, x=0, nou=0;
            Console.Write("Dati un nr natural n:");
            n=int.Parse(Console.ReadLine());
            Console.Write("Dati o baza in care n sa fie convertit:");
            b=int.Parse(Console.ReadLine());
            if (b<10)
            {
                while (n != 0)
                {
                    x = n % b;
                    x=x*10;
                    n = n / b;
                }
                while (x != 0)
                {
                    nou = x % 10;
                    nou = nou * 10;
                    x = x / 10;
                }
                Console.WriteLine("Numarul n scris in baza " + b + "este" + nou);
            }
            if (b == 10)
                Console.WriteLine("Numarul n scris in baza " + b + "este" + n);
            if (b>10)
            {
                char[] hex = new char[100];
                int i = 0;

                while (n != 0)
                {
                    int remainder = n % b;
                    switch (remainder)
                    {
                        case 10:
                            hex[i] = 'A';
                            break;
                        case 11:
                            hex[i] = 'B';
                            break;
                        case 12:
                            hex[i] = 'C';
                            break;
                        case 13:
                            hex[i] = 'D';
                            break;
                        case 14:
                            hex[i] = 'E';
                            break;
                        case 15:
                            hex[i] = 'F';
                            break;
                        default:
                            hex[i] = (char)(remainder + '0');
                            break;
                    }
                    n = n / b;
                    i++;
                }

                Console.Write($"Valoarea in baza {b} este: ");
                for (int j = i - 1; j >= 0; j--)
                {
                    Console.Write(hex[j]);
                }
            }

        }

        private static void E16()
        {
            int[] v = new int[100];
            int n, c, div;
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < n; c++)
            {
                v[c] = int.Parse(Console.ReadLine());
            }
            while (v[0] != v[1])
            {
                if (v[0] > v[1])
                    v[0] = v[0] - v[1];
                else
                    v[1] = v[1] - v[0];
            }
            div = v[0];
            for(c = 2; c < n; c++)
            {
                while (div != v[c])
                {
                    if (div > v[c])
                        div = div - v[c];
                    else
                        v[c] = v[c] - div;
                }
            }
            Console.WriteLine("Cmmdc al elementelor vectorului este:" + div);
            Console.ReadKey();
        }

        private static void E15()
        {
            int[] v = new int[100];
            int n, i, j, c;
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < n; c++)
            {
                v[c] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n ; i++)
            {
                for(j = i+1; j < n; j++)
                {
                    if (v[i] == v[j])
                    {
                        for (c = j; c < n - 1; c++)
                        {
                            v[c] = v[c + 1];
                        }
                        n--;
                    }
                }
            }
            Console.WriteLine("Vectorul cu elementele repetitive sterse este:");
            for(c = 0; c < n; c++)
            {
                Console.Write(v[c] + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void E14()
        {
            int[] V = new int[100];
            int n, c, a;
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < n; c++)
            {
                V[c] = int.Parse(Console.ReadLine());
            }
            a = n;
            for(c = 0; c < a; c++)
            {
                while (V[a] == 0)
                {
                    a--;
                }
                if (V[c] == 0)
                {
                    V[c] = V[a];
                    V[a] = 0;
                    a--;
                }
                while (V[a] == 0)
                {
                    a--;
                }
            }
            Console.WriteLine("Vectorul sortat cu elementele 0 la final este:");
            for (c = 0; c < n; c++)
            {
                Console.WriteLine(V[c]);
            }
            Console.ReadKey();
        }

        private static void E13()
        {
            int[] V = new int[100];
            int n, c, aux, p;
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < n; c++)
            {
                V[c] = int.Parse(Console.ReadLine());
            }
            for(c = 0; c < n; c++)
            {
                p = c;
                while(p > 0 && V[p] > V[p-1])
                {
                    aux = V[p];
                    V[p] = V[p-1];
                    V[p-1] = aux;
                    p--;
                }
            }
            Console.WriteLine("Vectorul sortat prin insertie este:");
            for (c = 0; c < n; c++)
            {
                Console.WriteLine(V[c]);
            }

            Console.ReadKey();
        }

        private static void E12()
        {
            int[] V = new int[100];
            int n, c, k, aux, poz;
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < n; c++)
            {
                V[c] = int.Parse(Console.ReadLine());
            }
            for (c = 0; c < n; c++)
            {
                poz = c;
                for(k = c+1; k < n; k++)
                {
                    if (V[poz] < V[k])
                        poz = k;
                }
                aux = V[poz];
                V[poz] = V[c];
                V[c] = aux;
            }
            Console.WriteLine("Vectorul sortat prin selectie este:");
                for(c = 0; c < n; c++)
                {
                Console.WriteLine(V[c]);
                }

                Console.ReadKey();
        }

        private static void E11()
        {
            int[] V = new int[100];
            int n, c, k;
            Console.WriteLine("Dati un nr n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cate nr are vectorul:");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 1; c <= k; c++)
            {
                V[c] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nr prime mai mici decat n sunt:");
            for(c = 1; c <= k; c++)
            {
                if (V[c] <= n && prim(V[c]) == 1)
                    Console.WriteLine(V[c]);
            }

            Console.ReadKey();
        }

        private static void E10()
        {
            int[] V = new int[100];
            int n, c, poz=0, s, d, k, m;
            Console.WriteLine("Dati un nr k:");
            k=int.Parse(Console.ReadLine());
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            s = 1;d = n;
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 1; c <= n; c++)
            {
                V[c] = int.Parse(Console.ReadLine());
            }
            while (poz != 1 && s <= d)
            {
                m = (s + d) / 2;
                if (V[m] == k)
                {
                    poz = m;
                }
                else
                {
                    if (V[m] < k)
                        s=m+1;
                    else
                        d=m+1;
                }
            }
            if (poz != 0)
                Console.WriteLine("Numarul k apare pe pozitia " + poz);
            else
                Console.WriteLine("-1");

            Console.ReadKey();
        }

        private static void E9()
        {
            int[] V = new int[100];
            int n, c, aux, k;
            Console.WriteLine("De cate ori sa fie vectorul rotit la stanga");
            k=int.Parse(Console.ReadLine());
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 1; c <= n; c++)
            {
                V[c] = int.Parse(Console.ReadLine());
            }
            while(k!=0)
            {
                for (c = 1; c < n; c++)
                {
                    aux = V[c];
                    V[c] = V[c + 1];
                    V[c + 1] = aux;
                }
                k--;
            }
            Console.WriteLine("Vectorul rotit la stanga de " + k + " ori este");
            for (c = 1; c <= n; c++)
            {
                Console.WriteLine(V[c]);
            }
            Console.ReadKey();
        }

        private static void E8()
        {
            int[] V = new int[100];
            int n, c, aux;
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 1; c <= n; c++)
            {
                V[c] = int.Parse(Console.ReadLine());
            }
            for(c = 1; c < n; c++)
            {
                aux = V[c];
                V[c] = V[c+1];
                V[c+1] = aux;
            }
            Console.WriteLine("Vectorul rotit la stanga odata");
            for (c = 1; c <= n; c++)
            {
                Console.WriteLine(V[c]);
            }
            Console.ReadKey();
        }

        private static void E7()
        {
            int[] V = new int[100];
            int n, c, i, j, aux;
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 1; c <= n; c++)
            {
                V[c] = int.Parse(Console.ReadLine());
            }
            i = 1;j = n;
            while(i<=j)
            {
                aux = V[i];
                V[i] = V[j];
                V[j] = aux;
                i++;j--;
            }
            Console.WriteLine("Vectorul interschimbat este:");
                for(c = 1; c <= n; c++)
                {
                Console.WriteLine(V[c]);
                }

                Console.ReadKey();
        }

        private static void E6()
        {
            int[] V = new int[100];
            int n, c, k;
            Console.WriteLine("Dati o pozitie k:");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < n; c++)
            {
                V[c] = int.Parse(Console.ReadLine());
            }
            for(c = k; c < n; c++)
            {
                V[c] = V[c+1];
            }
            Console.WriteLine("Vectorul fara pozitia k este:");
            for(c=0; c < n-1; c++)
            {
                Console.WriteLine(V[c]);
            }
            Console.ReadKey();
        }

        private static void E5()
        {
            int[] V = new int[100];
            int n, c, k, e;
            Console.WriteLine("Dati un nr e:");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati o pozitie in vector:");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < n; c++)
            {
                V[c] = int.Parse(Console.ReadLine());
            }
            V[k-1] = e;
            Console.WriteLine("Noul vector este:");
            for(c = 0; c < n; c++)
            {
                Console.WriteLine(V[c]);
            }
            Console.ReadKey();
        }

        private static void E4()
        {
            int[] v = new int[300];
            int min, max, n, c, m = 1, p = 1;
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < n; c++)
            {
                v[c] = int.Parse(Console.ReadLine());
            }
            min = v[0];
            max = v[0];
            for (c = 1; c < n; c++)
            {
                if (v[c] < min)
                {
                    min = v[c];
                    m = 1;
                }
                if (v[c] == min)
                {
                    m++;
                }
                if (v[c] > max)
                {
                    max = v[c];
                    p = 1;
                }
                if (v[c] == max)
                {
                    p++;
                }
            }
            Console.Write("Valoarea maxima din vector este " + max + " si apare de " + p + "ori");
            Console.Write("Valoarea minima din vector este " + min + " si apare de " + m + "ori");
            Console.ReadKey();
        }

        private static void E3()
        {
            int[]v=new int[300];
            int min, max, n, c, m=0, p=0;
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < n; c++)
            {
                v[c] = int.Parse(Console.ReadLine());
            }
            min = v[0];
            max = v[0];
            for(c = 1; c < n; c++)
            {
                if (v[c] < min)
                {
                    min = v[c];
                    m = c;
                    continue;
                }
                if (v[c] > max)
                {
                    max = v[c];
                    p = c;
                    continue;
                }
            }
            Console.WriteLine("Valoarea minima din vector se afla pe pozitia " + m + " si valoarea maxima se afla pe pozitia " + p);
            Console.ReadKey();
        }

        private static void E2()
        {
            int[]V=new int[100];
            int n, c, k;
            bool e=false;
            Console.WriteLine("Dati un nr k:");
            k=int.Parse(Console.ReadLine());
            Console.WriteLine("Cate nr are vectorul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for (c = 0; c < n; c++)
            {
                V[c] = int.Parse(Console.ReadLine());
            }
            for (c = 0; c < n; c++)
            {
                if (k == V[c])
                    e = true;
                Console.WriteLine("k se afla pe pozitia " + c);
            }
            if (!e)
                Console.WriteLine("-1");

            Console.ReadKey();
        }

        private static void E1()
        {
            int n, c, s = 0;
            int[] V = new int[100];
            Console.WriteLine("Cate nr are vectorul:");
                n=int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele vectorului:");
            for(c = 0; c < n; c++)
            {
                V[c] = int.Parse(Console.ReadLine());
            }
            for(c=0; c < n; c++)
            {
                s = s + V[c];
            }
            Console.WriteLine("Suma elementelor din vector este " + s);
            Console.ReadKey();
        }
        private static int prim(int n)
        {
            int div = 0;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    div++;
            }
            if (div == 0)
                return 1;
            else 
                return 0;
        }
    }
}
