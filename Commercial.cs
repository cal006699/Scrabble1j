using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCommercial
{
    /// <summary>
    /// class secteur
    /// </summary>
    public class Secteur
    {
        private int code;
        private string libelle;
        private List<int> lesDepartements;
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="unCode">num code</param>
        /// <param name="unLibelle">num code</param>
        public Secteur(int unCode, string unLibelle)
        {
            this.code = unCode;
            this.libelle = unLibelle;
            this.lesDepartements = new List<int>();
        }
        public int getCode() { return code; }
        public string getLibelle() { return libelle; }
        public List<int> getLesDepartements() { return lesDepartements; }
        public bool AjouterDepartements(int unNumero)
        {
            if (this.lesDepartements.Contains(unNumero))
            {
                return false;
            }
            else
            {
                this.lesDepartements.Add(unNumero);
                return true;
            }
        }
    }
    /// <summary>
    /// Classe Commercial
    /// </summary>
    public class Commercial
    {
        // Attributs privés
        private string numero;
        private string nom;
        private string prenom;
        private int[] ca;
        private Secteur leSecteur;

        
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="unNumero">numéro du commercial</param>
        /// <param name="unNom">nom du commercial</param>
        /// <param name="unPrenom">prénom du commercial</param>
        public Commercial(string unNumero, string unNom, string unPrenom, Secteur unSecteur)
        {
            //TODO
            this.numero = unNumero;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.ca = new int[4];
            this.leSecteur = unSecteur;
        }
        /// <summary>
        /// Méthode qui permet d'obtenir le nom du commercial (accesseur - getter)
        /// </summary>
        /// <returns>nom du commercial</returns>
        public string GetNom()
        {
            //TODO
            return $"{this.nom}";
        }
        /// <summary>
        /// Méthode qui permet de définir le nom du commercial (modifieur - setter)
        /// </summary>
        /// <param name="unNom">nom du commercial</param>
        public void SetNom(string unNom)
        {
            //TODO
            this.nom=unNom;
        }
        /// <summary>
        /// Méthode qui affiche les informations détaillées du commercial
        /// </summary>
        public void Afficher()
        {
            //TODO
            int i = 1;
            Console.WriteLine($"Commercial N°{this.numero} : {this.nom.ToUpper()} {this.prenom}");
            Console.WriteLine($"Secteur : {this.leSecteur}");
            Console.WriteLine($"couvrant les départements : {this.leSecteur.getLesDepartements()}");
            foreach(int value in this.ca)
            {
                i++;
                Console.WriteLine($"CA trim {i} = {value}");
            }
        }

        /// <summary>
        /// Méthode qui attribue au commercial le chiffre d'affaires spécifié pour un trimestre donné
        /// </summary>
        /// <param name="unTrim">Numéro du trimestre (1, 2, 3 ou 4)</param>
        /// <param name="unCA">Montant du chiffre d'affaires trimestriel</param>
        /// <returns>true ou false (cas ou CA déjà attribué pour trimestre donné ou numéro trimestre non valide)</returns>
        public bool DefinirCATrim(int unTrim, int unCA)
        {
            //TODO
            if( unTrim >=1 && unTrim <=4 && this.ca[unTrim]==0)
            {
                this.ca[unTrim] = unCA;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Méthode qui calcule et retourne le chiffre d'affaires annuel du commercial
        /// </summary>
        /// <returns>CA annuel</returns>
        public int ObtenirCaAnnuel()
        {
            //TODO
            int total = 0;
            foreach(int value in this.ca)
            {
                total=total+value;
            }
            return total;
        }

        public Secteur GetSecteur()
        {
            return this.leSecteur;
        }

        public Secteur setSecteur(Secteur secteur)
        {
            this.leSecteur = secteur;
            return this.leSecteur ;
        }
    }
}
