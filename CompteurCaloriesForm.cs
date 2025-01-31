/*
    Programmeur:    Fabrice Kouonang
    Date:           30 janvier 2025
  
    Solution:       CompteurCalories.sln
    Projet:         CompteurCalories.csproj
    Classe:         CompteurCaloriesForm (CompteurCaloriesForm.cs)
  
    But:            Calculer le nombre de calories d'un aliment. Tenir compte du nombre total
                    d'aliments saisis et du nombre total de calories de ces aliments.
               
    Entrées:        Nombre de grammes de lipides, glucides et/ou protéines d'un aliment. 
                    (Nombres réels positifs - au moins un de saisi)
               
    Traitement et sortie:
                    Lipides  9 calories par gramme
                    Glucides  4 calories par gramme
                    Protéines 4 calories par gramme

                    Calculer et afficher le nombre de calories de l'aliment.
                    Cumuler le nombre d'aliments saisis et le nombre total de calories de tous les aliments et les afficher.
                    Effacer et débuter la saisie de nouveaux aliments.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CompteurCalories
{
    public partial class CompteurCaloriesForm : Form
    {


        #region Initialisation

        public CompteurCaloriesForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Champs privées et vonstants
        //constantes
        private const Single LIPIDES_CAL_G = 9;
        private const Single GLUCIDES_CAL_G = 4;
        private const Single PROTEINES_CAL_G = 4;

        //variables
        private Single totalCalories = 0.0F;
        private int nombreAliments = 0;
        private Single caloriesAliment = 0.0F;

        //liste d'aliments
        List<ClassAliment.Aliment> listeAliments = new List<ClassAliment.Aliment>();

        #endregion

        #region Calculer les calories, le sommaire de tous les aliments et afficher les résultats (incluant Traitement exception),reinitialiser les champs

        //Addjouter un aliment dans la liste d'aliments depuis la classe Aliment
        private void addAliment(ClassAliment.Aliment aliment)
        {
            listeAliments.Add(aliment);
        }

        // calculer les calories des aliments depuis la liste d'aliments
        private Single calculerCaloriesAlimentsFromList()
        {
            totalCalories = 0.0F;
            foreach (ClassAliment.Aliment aliment in listeAliments)
            {
                totalCalories += calculerCalories(aliment.QteLipide, aliment.QteGlucide, aliment.QteProteine);
            }
            return totalCalories;
        }

        //methode pour reinitialiser les champs
        private void reinitialiserChamps()
        {
            //reinitialiser les champs
            lipidesTextBox.Clear();
            glucidesTextBox.Clear();
            proteinesTextBox.Clear();
            nomAlimentTextBox.Clear();

            //nombreAlimentsLabel.Text = string.Empty;
            nombreCaloriesAlimentLabel.Text = string.Empty;
            // nombreTotalCaloriesLabel.Text = string.Empty;


            nomAlimentTextBox.Focus();
        }

        //Message d'erreur
        private void afficherMessageErreur(string message)
        {
            string titre = "Erreur dans l'application";
            MessageBoxButtons boutons = MessageBoxButtons.AbortRetryIgnore;
            MessageBoxIcon icone = MessageBoxIcon.Error;
            MessageBox.Show(message, titre, boutons, icone);
        }

        //methode pour calculer les calories
        Single calculerCalories(Single lipides, Single glucides, Single proteines)
        {
            Single calories = 0;
            calories = lipides * LIPIDES_CAL_G + glucides * GLUCIDES_CAL_G + proteines * PROTEINES_CAL_G;
            return calories;
        }

        #endregion

        #region Quitter l'application avec validation
        private void quitterButton_Click(object sender, EventArgs e)
        {
            string msg = "Voulez-vous vraiment quitter?";
            string titre = "Quitter l'application";
            MessageBoxButtons boutons = MessageBoxButtons.YesNo;
            MessageBoxIcon icone = MessageBoxIcon.Question;
            DialogResult reponse = MessageBox.Show(msg, titre, boutons, icone);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        #endregion

        #region Reinitialiser les champs controls  et les variables
        private void effacerButton_Click(object sender, EventArgs e)
        {
            reinitialiserChamps();
        }
        #endregion

        #region calculer les calories par aliment et globales
        private void calculerButton_Click(object sender, EventArgs e)
        {
            try
            {
                Single lipides = 0;
                Single glucides = 0;
                Single proteines = 0;
                //validation des champs
                //TODO: valider les champs et donner le focus en fonction de l'erreur au champs
                //TODO: Gerer les exceptions dans un dossier à part
                //TODO: Utiliser la classe aliment pour gérer les aliments sur chaque aliment et les stocker dans une liste
                if (Single.Parse(lipidesTextBox.Text) < 0.0F)
                {
                    MessageBox.Show(Single.Parse(lipidesTextBox.Text).ToString("F"));
                    lipidesTextBox.Focus();
                    return;
                }


                if (nomAlimentTextBox.Text == string.Empty)
                {
                    nomAlimentTextBox.Focus();
                    throw new Exception("Le nom de l'aliment est obligatoire");
                }
                if (lipidesTextBox.Text == string.Empty && glucidesTextBox.Text == string.Empty && proteinesTextBox.Text == string.Empty)
                {
                    lipidesTextBox.Focus();

                    throw new Exception("Au moins un des champs de lipides, glucides ou protéines doit être saisi");
                }
                if (Single.Parse(lipidesTextBox.Text) < 0.0F && Single.Parse(glucidesTextBox.Text) < 0.0F && Single.Parse(proteinesTextBox.Text) < 0.0F)
                {
                    lipidesTextBox.Focus();
                    throw new Exception("Les valeurs saisies doivent être des nombres réels positifs");
                }
                if (lipidesTextBox.Text != string.Empty)
                {
                    lipides = Convert.ToSingle(lipidesTextBox.Text);
                }
                if (glucidesTextBox.Text != string.Empty)
                {
                    glucides = Convert.ToSingle(glucidesTextBox.Text);
                }
                if (proteinesTextBox.Text != string.Empty)
                {
                    proteines = Convert.ToSingle(proteinesTextBox.Text);
                }
                //calcul des calories
                caloriesAliment = calculerCalories(lipides, glucides, proteines);
                //affichage des résultats
                nombreAliments++;
                totalCalories += caloriesAliment;
                nombreAlimentsLabel.Text = nombreAliments.ToString("F4"); // pour affficher 4 chiffres après la virgule
                nombreCaloriesAlimentLabel.Text = caloriesAliment.ToString("F4");
                nombreTotalCaloriesLabel.Text = totalCalories.ToString("F4");
                reinitialiserChamps();

            }
            catch (Exception ex)
            {
                afficherMessageErreur(ex.Message);
            }
            //catch (FormatException ex)
            //{
            //    afficherMessageErreur("Les valeurs saisies doivent être des nombres réels positifs");
            //}
            //catch (OverflowException)
            //{
            //    afficherMessageErreur("Les valeurs saisies sont trop grandes");
            //}

        }

        //ajouter un aliment depuis la classe Aliment
        private void addAlimentFromClassButton_Click(object sender, EventArgs e)
        {
            try
            {
                Single lipides = 0;
                Single glucides = 0;
                Single proteines = 0;
                //validation des champs
                if (nomAlimentTextBox.Text == string.Empty)
                {
                    nomAlimentTextBox.Focus();
                    throw new Exception("Le nom de l'aliment est obligatoire");
                }
                if (lipidesTextBox.Text == string.Empty && glucidesTextBox.Text == string.Empty && proteinesTextBox.Text == string.Empty)
                {
                    lipidesTextBox.Focus();

                    throw new Exception("Au moins un des champs de lipides, glucides ou protéines doit être saisi");
                }
                if (Single.Parse(lipidesTextBox.Text) < 0.0F && Single.Parse(glucidesTextBox.Text) < 0.0F && Single.Parse(proteinesTextBox.Text) < 0.0F)
                {
                    lipidesTextBox.Focus();
                    throw new Exception("Les valeurs saisies doivent être des nombres réels positifs");
                }
                if (lipidesTextBox.Text != string.Empty)
                {
                    lipides = Convert.ToSingle(lipidesTextBox.Text);
                }
                if (glucidesTextBox.Text != string.Empty)
                {
                    glucides = Convert.ToSingle(glucidesTextBox.Text);
                }
                if (proteinesTextBox.Text != string.Empty)
                {
                    proteines = Convert.ToSingle(proteinesTextBox.Text);
                }
                // creer la classe aliment et ajouter aliment dans la liste
                ClassAliment.Aliment aliment = new ClassAliment.Aliment(nomAlimentTextBox.Text, lipides, glucides, proteines);
                addAliment(aliment);
                //calcul des calories
                caloriesAliment = calculerCalories(lipides, glucides, proteines);
                totalCalories = calculerCaloriesAlimentsFromList();
                //affichage des résultats
                nombreAlimentsLabel.Text = listeAliments.Count.ToString("F4"); // pour affficher 4 chiffres après la virgule
                nombreCaloriesAlimentLabel.Text = caloriesAliment.ToString("F4");
                nombreTotalCaloriesLabel.Text = totalCalories.ToString("F4");
                reinitialiserChamps();

            }
            catch (Exception ex)
            {
                afficherMessageErreur(ex.Message);
            }
            #endregion


        }
    }
}

namespace ClassAliment
{
    public class Aliment
    {
        #region propriete 
        private string name;
        private Single qteLipide;
        private Single qteGlucide;
        private Single qteProteine;
        #endregion
        #region constructeurs
        public Aliment() { }
        public Aliment(string name, float qteLipide, float qteGlucide, float qteProteine)
        {
            this.name = name;
            this.qteLipide = qteLipide;
            this.qteGlucide = qteGlucide;
            this.qteProteine = qteProteine;
        }
        #endregion
        #region getters et setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Single QteLipide
        {
            get { return qteLipide; }
            set { qteLipide = value; }
        }
        public Single QteGlucide
        {
            get { return qteGlucide; }
            set { qteGlucide = value; }
        }
        public Single QteProteine
        {
            get { return qteProteine; }
            set { qteProteine = value; }
        }
        #endregion
    }
}