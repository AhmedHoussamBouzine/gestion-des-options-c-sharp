using System;
using System.Collections.Generic;

namespace gestion_des_filieres
{
    class Program
    {
        static void Main(string[] args)
        {
            // le nombre des etudiants
            Console.WriteLine("entrer le nombre des etudiants ");
            int j = int.Parse(Console.ReadLine());

            // declaration du tableau d'affichage
            string[] tab = new string[j];


            //declarations des trois options : gl , abd, asr
            option gl = new option("gl", 20);
            option abd = new option("abd", 20);
            option asr = new option("asr", 20);

            //declaration de la liste des etudiants 
            var liste = new List<Tuple<Etudiant, string, string, string>>();


            // la liste d'etudiants 
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("entrer le nom d'etudiant N" + (i+1));
                string nom = Convert.ToString(Console.ReadLine());
                Console.WriteLine("entrer le prenom d'etudiant N" + (i + 1));
                string prenom = Convert.ToString(Console.ReadLine());
                Console.WriteLine("entrer le CNE d'etudiant N" + (i + 1));
                string cne = Convert.ToString(Console.ReadLine());
                Console.WriteLine("entrer la note d'etudiant N" + (i + 1));
                double note = double.Parse(Console.ReadLine());
                Console.WriteLine("entrer le premier choix d'etudiant N" + (i + 1));
                string op1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("entrer le 2eme choix d'etudiant N" + (i + 1));
                string op2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("entrer le 3eme choix d'etudiant N" + (i + 1));
                string op3 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("----------------------------------");

                Etudiant etudiant = new Etudiant(nom, prenom, cne, note);

                var tuple = Tuple.Create(etudiant, op1, op2, op3);
                liste.Add(tuple);
            }
           
            // Tri de la liste des etudiants selon les notes  

            liste.Sort(delegate (Tuple<Etudiant, string, string, string> x, Tuple<Etudiant, string, string, string> y) {
                return y.Item1.Enote.CompareTo(x.Item1.Enote);
            });
            
            // Affectation des options 

            for (int i =0; i < j; i++) { 
                   
                    switch (liste[i].Item2)
                    {
                        case "gl":
                            if (gl.placedispo > 0)
                            {
                                tab[i] = liste[i].Item1.Enom +"  "+ liste[i].Item1.Eprenom + "  " + liste[i].Item1.Ecne + "  " + "  -->  " + gl.onom ;
                                --gl.placedispo;
                            }
                            break;
                        case "abd":
                            if (abd.placedispo > 0)
                            {
                                tab[i] = liste[i].Item1.Enom + "  " + liste[i].Item1.Eprenom + "  " + liste[i].Item1.Ecne + "  " + "  -->  " + abd.onom;
                                --abd.placedispo;
                            }
                            break;
                        case "asr":
                            if (asr.placedispo > 0)
                            {
                                tab[i] = liste[i].Item1.Enom + "  " + liste[i].Item1.Eprenom + "  " + liste[i].Item1.Ecne + "  " + "  -->  " + asr.onom;
                                --asr.placedispo;
                            }
                            break;
                    }
                    if (tab[i] == null)
                    {
                        switch (liste[i].Item3)
                        {

                        case "gl":
                            if (gl.placedispo > 0)
                            {
                                tab[i] = liste[i].Item1.Enom + "  " + liste[i].Item1.Eprenom + "  " + liste[i].Item1.Ecne + "  " + "  -->  " + gl.onom;
                                --gl.placedispo;
                            }
                            break;
                        case "abd":
                            if (abd.placedispo > 0)
                            {
                                tab[i] = liste[i].Item1.Enom + "  " + liste[i].Item1.Eprenom + "  " + liste[i].Item1.Ecne + "  " + "  -->  " + abd.onom;
                                --abd.placedispo;
                            }
                            break;
                        case "asr":
                            if (asr.placedispo > 0)
                            {
                                tab[i] = liste[i].Item1.Enom + "  " + liste[i].Item1.Eprenom + "  " + liste[i].Item1.Ecne + "  " + "  -->  " + asr.onom;
                                --asr.placedispo;
                            }
                            break;
                    }

                    }
                    if (tab[i] == null)
                    {
                        switch (liste[i].Item4)
                        {

                        case "gl":
                            if (gl.placedispo > 0)
                            {
                                tab[i] = liste[i].Item1.Enom + "  " + liste[i].Item1.Eprenom + "  " + liste[i].Item1.Ecne + "  " + "  -->  " + gl.onom;
                                --gl.placedispo;
                            }
                            break;
                        case "abd":
                            if (abd.placedispo > 0)
                            {
                                tab[i] = liste[i].Item1.Enom + "  " + liste[i].Item1.Eprenom + "  " + liste[i].Item1.Ecne + "  " + "  -->  " + abd.onom;
                                --abd.placedispo;
                            }
                            break;
                        case "asr":
                            if (asr.placedispo > 0)
                            {
                                tab[i] = liste[i].Item1.Enom + "  " + liste[i].Item1.Eprenom + "  " + liste[i].Item1.Ecne + "  " + "  -->  " + asr.onom;
                                --asr.placedispo;
                            }
                            break;
                    }

                    
                }
            

            }
            
            // affichage de la liste finale

            Console.WriteLine("La liste des etudiants avec leurs filieres : ");
            Console.WriteLine("Nom   Prenom   CNE   Filiere");
            Console.Write("\n");
           

            for (int i = 0; i <j ; i++)
            {
                
                Console.Write(tab[i] + "\t" );
               
                Console.Write("\n");
                Console.Write("----------------------------------");
                Console.Write("\n");
            }
           
          
        }
    }
}
   
