using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //------------------------------------------------- Exercice 1 boucles FOR multiple de 2 jusqua 20-----------------------------------------------------
/*
     class Program
     {

         static void Main(string[] args) {
         Console.WriteLine("Exercice1.1:");
             Console.WriteLine("Multiple de 2 avec utilisation d'un for");
             int x = 0;
             for (int i = 1; x < 20; i++) {
                 x = i * 2;
                 Console.WriteLine(x);

             }
             Console.ReadLine();
         }

     }
     
*/

    //-------------------------------------------------------------Exercice 1 boucles WHILE multiple de 2 jusqua 20--------------------------------------------------111

/*  
     class Program{
      static void Main(string[] args){
      Console.WriteLine("Exercice1.2:");
             Console.WriteLine("Multiple de 2 avec utilisation d'un while");
          int i = 0;                                                              
          int x = 0;
          while (  x < 20){
             x = i * 2;
             i++;
             Console.WriteLine(x);
          }
          Console.ReadLine(); 
      }
     }
*/

    //---------------------------------------------------------EXERCICE 2 boucles somme totale additionnée-------------------------------------------------
/*
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercice2:");
             Console.WriteLine("Calcul de la somme des entiers de 1 à un nombre saisie");
            Console.WriteLine("veuillez  donc saisir un nombre"); // saisie du nombre
            double saisie = Convert.ToDouble(Console.ReadLine()); // lis la valeur saisie et la stocke dans saisie
            double somme=0;
            for (int i = 1; i <= saisie; i++)                                               //Boucle pour  i<= somme
            {
                somme = i + somme;
            }
                Console.WriteLine("La somme des nombres de 1 a " + saisie + " est donc " + somme);
            Console.ReadLine();
        }

    }
*/
    //-------------------------------------------------------- Exo Boucles 3 calcul de moyenne avec les 5 nbre saisie--------------------------------
/*  
       class Program
       {
           static void Main(string[] args)
           {
           Console.WriteLine("Exercice3:");
             Console.WriteLine("Calcul de la moyenne avec les 5 nombres que vous allez saisir");
               Console.WriteLine("veuillez donc saisir 5 nombres");  //Affiche a l'ecran le messaage ecrit        
               double saisie1;
               List<double> ListMoy = new List<double>();                                  //creation de la liste ListMoy
                for (int i = 1; i <= 5; i++)                                               //Boucle pour  i<= 5
                {
                       double.TryParse(Console.ReadLine(),out saisie1);                    // lis la valeur saisie 
                       ListMoy.Add(saisie1);                                               //stocke la valeurs saisie
                }
               ListMoy.ForEach(Console.WriteLine);                                         //recupere chaque element stocker dans la liste
               double somme = 0;
               foreach (double moy in ListMoy)                                             //parcour les elements du tableaux de ListMoy et stocke la valeur dans moy  
               {
                   somme = somme + moy;                                                    // fais la somme des valeurs du tableau

               }
               double calcMoy = somme / 5;                                                 //calcul de la moyenne
               Console.WriteLine("la moyenne est  " + calcMoy);                            // affiche a lecran la moyenne des valeurs saisie  
               Console.ReadLine();
           }
       }
*/

    //--------------------------------------------------------Exo 4 calcul somme des entiers entre X et Y -----------------------------------
/*  
        class Program
       {
          static void Main(string[] args)
          {
            Console.WriteLine("Exercice4:");
             Console.WriteLine("Calcul de la somme des entiers entre deux nombres saisies");
              Console.WriteLine("veuillez saisir un nombre minimum"); // saisie du nombre
              double saisie2 = Convert.ToDouble(Console.ReadLine()); //
              int Y = Convert.ToInt32(saisie2); // on convertit saisie2 qui est en double en int qu'on stocke dans Y
              Console.WriteLine("veuillez saisir un nombre Maximum"); // saisie du nombre
               double saisie = Convert.ToDouble(Console.ReadLine()); // lis la valeur saisie et la stocke dans saisie
              double Summ = SommeVal(Y, saisie); // stock dans Summ la valeur retour de somme de la methode Sommeval

              Console.WriteLine("La somme des nombres de " + Y + " a " + saisie + " est donc " + Summ);
              Console.ReadLine();
          }

          private static double SommeVal(int val1, double val2) // methode somme
          {
              double somme = 0;
              for (int i = val1; i <= val2; i++)                                               //Boucle pour  i<= somme
              {
                  somme = i + somme;
              }
              return somme;
          }

       }
*/

    //--------------------------------------------------------Exo 5 calcul moyenne d'une liste ---------------------------------------------
/*  
        class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine("Exercice5:");
             Console.WriteLine("Calcul de la moyenne avec methode suite a la saisie de 5 valeurs");
              Console.WriteLine("veuillez donc saisir 5 valeurs");  //Affiche a l'ecran le messaage ecrit        
              double saisie1;
               List<double> ListMoy = new List<double>(); //creation de la liste ListMoy
                   for (int i = 1; i <= 5; i++)                                               //Boucle pour  i<= 5
                   {
                          double.TryParse(Console.ReadLine(),out saisie1);                    // lis la valeur saisie 
                          ListMoy.Add(saisie1);                                               //stocke la valeurs saisie
                   }
               ListMoy.ForEach(Console.WriteLine);
               double moy = CalcMoy(ListMoy);
               Console.WriteLine("la moyenne est  " + moy.ToString());                            // affiche a lecran la moyenne des valeurs saisie  
               Console.ReadLine();
           }
    private static double CalcMoy(List<double>List) { 
                  double somme = 0;
                  foreach (double moy in List)                                             //parcour les elements du tableaux de ListMoy et stocke la valeur dans moy  
                  {
                      somme = somme + moy;                                                    // fais la somme des valeurs du tableau

                  }
               return somme / List.Count ;                                                 //calcul de la moyenne

           } 

        } 

*/

    //--------------------------------------------------------Exo 6 final boucle ----------------------------------------------------------
/* 
      class Program
     {
         static void Main(string[] args)
         {
             Console.WriteLine("Exercice6:");
             Console.WriteLine("Calcul de la somme des entiers commun jusqu'a 100 entre les multiples de 3 et les multiples de 5");
             int retourSommeListe = Exercice6();
             Console.WriteLine("La somme des entiers commun aux liste de multiple de 3 et de 5 est :  " + retourSommeListe);
             Console.ReadLine();
         }

         static int Exercice6()
         {
             List<int> multiplesDe3 = new List<int>();
             List<int> multiplesDe5 = new List<int>();
             int x = 0;
             for (int i = 1; x < 100; i++) // multiple de 3
             {
                 x = i * 3;
                 multiplesDe3.Add(x);
             }
             int y = 0;
             for (int i = 1; y < 100; i++) // multiple de 5
             {
                 y = i * 5;
                 multiplesDe5.Add(y);
             }

             int somme2liste = 0;
             foreach (int valeursDe5 in multiplesDe5) // on parcours la liste multiple de 5
             {
                 foreach (int valeursDe3 in multiplesDe3) //on parcours la liste multiple de 3
                 {
                     if (valeursDe5 == valeursDe3) // si une valeurs de la liste mulitple de 5 est = a une valeur de multiple de 3 alors
                     {
                         somme2liste = somme2liste + valeursDe5 + valeursDe3; // on ajoute la valeur  de chacune des listes en question  qui sera = a somme2liste
                     }                                               //a chaque fois q'une nvelle valeur est trouvee on l'additionne a somme2liste
                 }
             }
             return somme2liste; //quand il ny a plus de valeurs on sort du foreach et on retourne somme2liste.
         }
           }
*/


}

