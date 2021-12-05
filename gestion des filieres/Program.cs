using System;
using System.Collections.Generic;

namespace gestion_des_filieres
{
    class Program
    {

        // d'abord on va creer une sturcture qui contient chaque etudiant et leurs choix 

        struct choix
        {
           public Etudiant et;
           public string op1;
           public string op2;
           public string op3;

        }

        static void Main(string[] args)
        {
            // le nombre des etudiants
            Console.WriteLine("entrer le nombre des etudiants ");
            int nbr = int.Parse(Console.ReadLine());

            // declaration du tableau d'affichage
            string[] tab = new string[nbr];


            //declarations des trois options : gl , abd, asr
            option gl = new option("gl", 20);
            option abd = new option("abd", 20);
            option asr = new option("asr", 20);

            //declaration de la liste des etudiants 
            var liste = new List<choix>();


            // la liste d'etudiants 
            for (int i = 0; i < nbr; i++)
            {

                choix cho;
                //les informations sur l'etudiant 
                Console.WriteLine("entrer le nom d'etudiant N" + (i+1));
                string nom = Convert.ToString(Console.ReadLine());
                Console.WriteLine("entrer le prenom d'etudiant N" + (i + 1));
                string prenom = Convert.ToString(Console.ReadLine());
                Console.WriteLine("entrer le CNE d'etudiant N" + (i + 1));
                string cne = Convert.ToString(Console.ReadLine());
                Console.WriteLine("entrer la note d'etudiant N" + (i + 1));
                double note = double.Parse(Console.ReadLine());
                //les choix de l'etudiant 
                Console.WriteLine("entrer le premier choix d'etudiant N" + (i + 1));
                cho.op1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("entrer le 2eme choix d'etudiant N" + (i + 1));
                cho.op2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("entrer le 3eme choix d'etudiant N" + (i + 1));
                cho.op3 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("----------------------------------");
                Etudiant etudiant = new Etudiant(nom, prenom, cne, note);  
                cho.et = etudiant;
                liste.Add(cho);
            }
           
            // Tri de la liste des etudiants selon les notes  

            liste.Sort(delegate (choix x, choix y) {
                return y.et.Enote.CompareTo(x.et.Enote);
            });

            
            // Affectation des options 

            for (int i = 0; i < nbr; i++) { 
                   
                    switch (liste[i].op1)
                    {
                        case "gl":
                            if (gl.placedispo > 0)
                            {
                                tab[i] = liste[i].et.Enom +"  "+ liste[i].et.Eprenom + "  " + liste[i].et.Ecne + "  " + "  -->  " + gl.onom ;
                                --gl.placedispo;
                            }
                            break;
                        case "abd":
                            if (abd.placedispo > 0)
                            {
                                tab[i] = liste[i].et.Enom + "  " + liste[i].et.Eprenom + "  " + liste[i].et.Ecne + "  " + "  -->  " + abd.onom;
                                --abd.placedispo;
                            }
                            break;
                        case "asr":
                            if (asr.placedispo > 0)
                            {
                                tab[i] = liste[i].et.Enom + "  " + liste[i].et.Eprenom + "  " + liste[i].et.Ecne + "  " + "  -->  " + asr.onom;
                                --asr.placedispo;
                            }
                            break;
                    }
                    if (tab[i] == null)
                    {
                        switch (liste[i].op2)
                        {

                        case "gl":
                            if (gl.placedispo > 0)
                            {
                                tab[i] = liste[i].et.Enom + "  " + liste[i].et.Eprenom + "  " + liste[i].et.Ecne + "  " + "  -->  " + gl.onom;
                                --gl.placedispo;
                            }
                            break;
                        case "abd":
                            if (abd.placedispo > 0)
                            {
                                tab[i] = liste[i].et.Enom + "  " + liste[i].et.Eprenom + "  " + liste[i].et.Ecne + "  " + "  -->  " + abd.onom;
                                --abd.placedispo;
                            }
                            break;
                        case "asr":
                            if (asr.placedispo > 0)
                            {
                                tab[i] = liste[i].et.Enom + "  " + liste[i].et.Eprenom + "  " + liste[i].et.Ecne + "  " + "  -->  " + asr.onom;
                                --asr.placedispo;
                            }
                            break;
                    }

                    }
                    if (tab[i] == null)
                    {
                        switch (liste[i].op3)
                        {

                        case "gl":
                            if (gl.placedispo > 0)
                            {
                                tab[i] = liste[i].et.Enom + "  " + liste[i].et.Eprenom + "  " + liste[i].et.Ecne + "  " + "  -->  " + gl.onom;
                                --gl.placedispo;
                            }
                            break;
                        case "abd":
                            if (abd.placedispo > 0)
                            {
                                tab[i] = liste[i].et.Enom + "  " + liste[i].et.Eprenom + "  " + liste[i].et.Ecne + "  " + "  -->  " + abd.onom;
                                --abd.placedispo;
                            }
                            break;
                        case "asr":
                            if (asr.placedispo > 0)
                            {
                                tab[i] = liste[i].et.Enom + "  " + liste[i].et.Eprenom + "  " + liste[i].et.Ecne + "  " + "  -->  " + asr.onom;
                                --asr.placedispo;
                            }
                            break;
                    }

                }
            
            }
             
            // affichage de la liste finale

            Console.WriteLine("La liste des etudiants  : ");
            Console.WriteLine(" Nom   |  Prenom  |  CNE  |   Filiere ");
            Console.Write("\n");

            for (int i = 0; i < nbr ; i++)
            {

                Console.Write(tab[i] + "\t" );
                Console.Write("\n");
                Console.Write("----------------------------------");
                Console.Write("\n");
            }   
        }
    }
}
   
