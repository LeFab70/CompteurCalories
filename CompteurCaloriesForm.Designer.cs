namespace CompteurCalories
{
    partial class CompteurCaloriesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nomAlimentTextBox = new System.Windows.Forms.TextBox();
            this.nomAlimentLabel = new System.Windows.Forms.Label();
            this.quitterButton = new System.Windows.Forms.Button();
            this.compositionAlimentGroupBox = new System.Windows.Forms.GroupBox();
            this.g3Label = new System.Windows.Forms.Label();
            this.g2Label = new System.Windows.Forms.Label();
            this.g1Label = new System.Windows.Forms.Label();
            this.proteinesTextBox = new System.Windows.Forms.TextBox();
            this.glucidesTextBox = new System.Windows.Forms.TextBox();
            this.lipidesTextBox = new System.Windows.Forms.TextBox();
            this.proteineLabel = new System.Windows.Forms.Label();
            this.glucidesLabel = new System.Windows.Forms.Label();
            this.lipidesLabel = new System.Windows.Forms.Label();
            this.effacerButton = new System.Windows.Forms.Button();
            this.calculerButton = new System.Windows.Forms.Button();
            this.sommaireAlimentsGroupBox = new System.Windows.Forms.GroupBox();
            this.nombreTotalCaloriesLabel = new System.Windows.Forms.Label();
            this.nombreAlimentsLabel = new System.Windows.Forms.Label();
            this.totalCaloriesLLabel = new System.Windows.Forms.Label();
            this.nombreAlimentsLLabel = new System.Windows.Forms.Label();
            this.caloriesAlimentsGroupBox = new System.Windows.Forms.GroupBox();
            this.nombreCaloriesAlimentLabel = new System.Windows.Forms.Label();
            this.caloriesAlimentsLLabel = new System.Windows.Forms.Label();
            this.compteurCaloriesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addAlimentFromClassButton = new System.Windows.Forms.Button();
            this.listAlimentDataGridView = new System.Windows.Forms.DataGridView();
            this.compositionAlimentGroupBox.SuspendLayout();
            this.sommaireAlimentsGroupBox.SuspendLayout();
            this.caloriesAlimentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compteurCaloriesErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAlimentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomAlimentTextBox
            // 
            this.nomAlimentTextBox.HideSelection = false;
            this.nomAlimentTextBox.Location = new System.Drawing.Point(223, 12);
            this.nomAlimentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomAlimentTextBox.Name = "nomAlimentTextBox";
            this.nomAlimentTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomAlimentTextBox.TabIndex = 1;
            // 
            // nomAlimentLabel
            // 
            this.nomAlimentLabel.Location = new System.Drawing.Point(9, 15);
            this.nomAlimentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomAlimentLabel.Name = "nomAlimentLabel";
            this.nomAlimentLabel.Size = new System.Drawing.Size(164, 20);
            this.nomAlimentLabel.TabIndex = 0;
            this.nomAlimentLabel.Text = "&Nom de l\'aliment :";
            // 
            // quitterButton
            // 
            this.quitterButton.CausesValidation = false;
            this.quitterButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitterButton.Location = new System.Drawing.Point(338, 343);
            this.quitterButton.Margin = new System.Windows.Forms.Padding(2);
            this.quitterButton.Name = "quitterButton";
            this.quitterButton.Size = new System.Drawing.Size(85, 34);
            this.quitterButton.TabIndex = 7;
            this.quitterButton.Text = "&Quitter";
            this.quitterButton.Click += new System.EventHandler(this.quitterButton_Click);
            // 
            // compositionAlimentGroupBox
            // 
            this.compositionAlimentGroupBox.Controls.Add(this.g3Label);
            this.compositionAlimentGroupBox.Controls.Add(this.g2Label);
            this.compositionAlimentGroupBox.Controls.Add(this.g1Label);
            this.compositionAlimentGroupBox.Controls.Add(this.proteinesTextBox);
            this.compositionAlimentGroupBox.Controls.Add(this.glucidesTextBox);
            this.compositionAlimentGroupBox.Controls.Add(this.lipidesTextBox);
            this.compositionAlimentGroupBox.Controls.Add(this.proteineLabel);
            this.compositionAlimentGroupBox.Controls.Add(this.glucidesLabel);
            this.compositionAlimentGroupBox.Controls.Add(this.lipidesLabel);
            this.compositionAlimentGroupBox.Location = new System.Drawing.Point(8, 45);
            this.compositionAlimentGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.compositionAlimentGroupBox.Name = "compositionAlimentGroupBox";
            this.compositionAlimentGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.compositionAlimentGroupBox.Size = new System.Drawing.Size(419, 135);
            this.compositionAlimentGroupBox.TabIndex = 2;
            this.compositionAlimentGroupBox.TabStop = false;
            this.compositionAlimentGroupBox.Text = "Composition de l\'aliment";
            // 
            // g3Label
            // 
            this.g3Label.Location = new System.Drawing.Point(220, 95);
            this.g3Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.g3Label.Name = "g3Label";
            this.g3Label.Size = new System.Drawing.Size(27, 26);
            this.g3Label.TabIndex = 8;
            this.g3Label.Text = "g.";
            this.g3Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // g2Label
            // 
            this.g2Label.Location = new System.Drawing.Point(220, 63);
            this.g2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.g2Label.Name = "g2Label";
            this.g2Label.Size = new System.Drawing.Size(27, 27);
            this.g2Label.TabIndex = 7;
            this.g2Label.Text = "g.";
            this.g2Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // g1Label
            // 
            this.g1Label.Location = new System.Drawing.Point(220, 35);
            this.g1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.g1Label.Name = "g1Label";
            this.g1Label.Size = new System.Drawing.Size(27, 24);
            this.g1Label.TabIndex = 6;
            this.g1Label.Text = "g.";
            this.g1Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // proteinesTextBox
            // 
            this.proteinesTextBox.Location = new System.Drawing.Point(111, 95);
            this.proteinesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.proteinesTextBox.Name = "proteinesTextBox";
            this.proteinesTextBox.Size = new System.Drawing.Size(103, 20);
            this.proteinesTextBox.TabIndex = 5;
            // 
            // glucidesTextBox
            // 
            this.glucidesTextBox.Location = new System.Drawing.Point(111, 63);
            this.glucidesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.glucidesTextBox.Name = "glucidesTextBox";
            this.glucidesTextBox.Size = new System.Drawing.Size(103, 20);
            this.glucidesTextBox.TabIndex = 3;
            // 
            // lipidesTextBox
            // 
            this.lipidesTextBox.Location = new System.Drawing.Point(111, 32);
            this.lipidesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lipidesTextBox.Name = "lipidesTextBox";
            this.lipidesTextBox.Size = new System.Drawing.Size(103, 20);
            this.lipidesTextBox.TabIndex = 1;
            // 
            // proteineLabel
            // 
            this.proteineLabel.Location = new System.Drawing.Point(10, 95);
            this.proteineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.proteineLabel.Name = "proteineLabel";
            this.proteineLabel.Size = new System.Drawing.Size(97, 26);
            this.proteineLabel.TabIndex = 4;
            this.proteineLabel.Text = "&Protéines:";
            // 
            // glucidesLabel
            // 
            this.glucidesLabel.Location = new System.Drawing.Point(10, 63);
            this.glucidesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.glucidesLabel.Name = "glucidesLabel";
            this.glucidesLabel.Size = new System.Drawing.Size(97, 20);
            this.glucidesLabel.TabIndex = 2;
            this.glucidesLabel.Text = "&Glucides:";
            // 
            // lipidesLabel
            // 
            this.lipidesLabel.Location = new System.Drawing.Point(10, 32);
            this.lipidesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lipidesLabel.Name = "lipidesLabel";
            this.lipidesLabel.Size = new System.Drawing.Size(97, 20);
            this.lipidesLabel.TabIndex = 0;
            this.lipidesLabel.Text = "&Lipides:";
            // 
            // effacerButton
            // 
            this.effacerButton.CausesValidation = false;
            this.effacerButton.Location = new System.Drawing.Point(248, 343);
            this.effacerButton.Margin = new System.Windows.Forms.Padding(2);
            this.effacerButton.Name = "effacerButton";
            this.effacerButton.Size = new System.Drawing.Size(85, 34);
            this.effacerButton.TabIndex = 6;
            this.effacerButton.Text = "&Effacer";
            this.effacerButton.Click += new System.EventHandler(this.effacerButton_Click);
            // 
            // calculerButton
            // 
            this.calculerButton.Location = new System.Drawing.Point(12, 343);
            this.calculerButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculerButton.Name = "calculerButton";
            this.calculerButton.Size = new System.Drawing.Size(94, 26);
            this.calculerButton.TabIndex = 5;
            this.calculerButton.Text = "&Calculer";
            this.calculerButton.Visible = false;
            // 
            // sommaireAlimentsGroupBox
            // 
            this.sommaireAlimentsGroupBox.Controls.Add(this.nombreTotalCaloriesLabel);
            this.sommaireAlimentsGroupBox.Controls.Add(this.nombreAlimentsLabel);
            this.sommaireAlimentsGroupBox.Controls.Add(this.totalCaloriesLLabel);
            this.sommaireAlimentsGroupBox.Controls.Add(this.nombreAlimentsLLabel);
            this.sommaireAlimentsGroupBox.Location = new System.Drawing.Point(3, 244);
            this.sommaireAlimentsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.sommaireAlimentsGroupBox.Name = "sommaireAlimentsGroupBox";
            this.sommaireAlimentsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.sommaireAlimentsGroupBox.Size = new System.Drawing.Size(419, 95);
            this.sommaireAlimentsGroupBox.TabIndex = 4;
            this.sommaireAlimentsGroupBox.TabStop = false;
            this.sommaireAlimentsGroupBox.Text = "Sommaire";
            // 
            // nombreTotalCaloriesLabel
            // 
            this.nombreTotalCaloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nombreTotalCaloriesLabel.Location = new System.Drawing.Point(280, 55);
            this.nombreTotalCaloriesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreTotalCaloriesLabel.Name = "nombreTotalCaloriesLabel";
            this.nombreTotalCaloriesLabel.Size = new System.Drawing.Size(121, 22);
            this.nombreTotalCaloriesLabel.TabIndex = 3;
            this.nombreTotalCaloriesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nombreAlimentsLabel
            // 
            this.nombreAlimentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nombreAlimentsLabel.Location = new System.Drawing.Point(280, 27);
            this.nombreAlimentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreAlimentsLabel.Name = "nombreAlimentsLabel";
            this.nombreAlimentsLabel.Size = new System.Drawing.Size(121, 22);
            this.nombreAlimentsLabel.TabIndex = 1;
            this.nombreAlimentsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalCaloriesLLabel
            // 
            this.totalCaloriesLLabel.Location = new System.Drawing.Point(14, 56);
            this.totalCaloriesLLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCaloriesLLabel.Name = "totalCaloriesLLabel";
            this.totalCaloriesLLabel.Size = new System.Drawing.Size(218, 21);
            this.totalCaloriesLLabel.TabIndex = 2;
            this.totalCaloriesLLabel.Text = "Nombre total de calories:";
            // 
            // nombreAlimentsLLabel
            // 
            this.nombreAlimentsLLabel.Location = new System.Drawing.Point(14, 28);
            this.nombreAlimentsLLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreAlimentsLLabel.Name = "nombreAlimentsLLabel";
            this.nombreAlimentsLLabel.Size = new System.Drawing.Size(174, 21);
            this.nombreAlimentsLLabel.TabIndex = 0;
            this.nombreAlimentsLLabel.Text = "Nombre d\'aliments:";
            // 
            // caloriesAlimentsGroupBox
            // 
            this.caloriesAlimentsGroupBox.Controls.Add(this.nombreCaloriesAlimentLabel);
            this.caloriesAlimentsGroupBox.Controls.Add(this.caloriesAlimentsLLabel);
            this.caloriesAlimentsGroupBox.Location = new System.Drawing.Point(3, 177);
            this.caloriesAlimentsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.caloriesAlimentsGroupBox.Name = "caloriesAlimentsGroupBox";
            this.caloriesAlimentsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.caloriesAlimentsGroupBox.Size = new System.Drawing.Size(419, 53);
            this.caloriesAlimentsGroupBox.TabIndex = 3;
            this.caloriesAlimentsGroupBox.TabStop = false;
            // 
            // nombreCaloriesAlimentLabel
            // 
            this.nombreCaloriesAlimentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nombreCaloriesAlimentLabel.Location = new System.Drawing.Point(280, 20);
            this.nombreCaloriesAlimentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreCaloriesAlimentLabel.Name = "nombreCaloriesAlimentLabel";
            this.nombreCaloriesAlimentLabel.Size = new System.Drawing.Size(121, 22);
            this.nombreCaloriesAlimentLabel.TabIndex = 1;
            this.nombreCaloriesAlimentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // caloriesAlimentsLLabel
            // 
            this.caloriesAlimentsLLabel.Location = new System.Drawing.Point(6, 20);
            this.caloriesAlimentsLLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.caloriesAlimentsLLabel.Name = "caloriesAlimentsLLabel";
            this.caloriesAlimentsLLabel.Size = new System.Drawing.Size(286, 24);
            this.caloriesAlimentsLLabel.TabIndex = 0;
            this.caloriesAlimentsLLabel.Text = "Nombre de calories de l\'aliment:";
            // 
            // compteurCaloriesErrorProvider
            // 
            this.compteurCaloriesErrorProvider.ContainerControl = this;
            // 
            // addAlimentFromClassButton
            // 
            this.addAlimentFromClassButton.BackColor = System.Drawing.Color.Chocolate;
            this.addAlimentFromClassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlimentFromClassButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAlimentFromClassButton.Location = new System.Drawing.Point(8, 343);
            this.addAlimentFromClassButton.Margin = new System.Windows.Forms.Padding(2);
            this.addAlimentFromClassButton.Name = "addAlimentFromClassButton";
            this.addAlimentFromClassButton.Size = new System.Drawing.Size(236, 34);
            this.addAlimentFromClassButton.TabIndex = 8;
            this.addAlimentFromClassButton.Text = "+&Calculer et ajouter";
            this.addAlimentFromClassButton.UseVisualStyleBackColor = false;
            this.addAlimentFromClassButton.Click += new System.EventHandler(this.addAlimentFromClassButton_Click);
            // 
            // listAlimentDataGridView
            // 
            this.listAlimentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.listAlimentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listAlimentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listAlimentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listAlimentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.listAlimentDataGridView.Location = new System.Drawing.Point(8, 381);
            this.listAlimentDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.listAlimentDataGridView.Name = "listAlimentDataGridView";
            this.listAlimentDataGridView.ReadOnly = true;
            this.listAlimentDataGridView.RowTemplate.Height = 24;
            this.listAlimentDataGridView.Size = new System.Drawing.Size(415, 215);
            this.listAlimentDataGridView.TabIndex = 9;
            // 
            // CompteurCaloriesForm
            // 
            this.AcceptButton = this.addAlimentFromClassButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.quitterButton;
            this.ClientSize = new System.Drawing.Size(433, 599);
            this.Controls.Add(this.listAlimentDataGridView);
            this.Controls.Add(this.addAlimentFromClassButton);
            this.Controls.Add(this.nomAlimentTextBox);
            this.Controls.Add(this.nomAlimentLabel);
            this.Controls.Add(this.quitterButton);
            this.Controls.Add(this.compositionAlimentGroupBox);
            this.Controls.Add(this.effacerButton);
            this.Controls.Add(this.calculerButton);
            this.Controls.Add(this.sommaireAlimentsGroupBox);
            this.Controls.Add(this.caloriesAlimentsGroupBox);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CompteurCaloriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compteur Calories";
            //this.Load += new System.EventHandler(this.CompteurCaloriesForm_Load);
            this.compositionAlimentGroupBox.ResumeLayout(false);
            this.compositionAlimentGroupBox.PerformLayout();
            this.sommaireAlimentsGroupBox.ResumeLayout(false);
            this.caloriesAlimentsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compteurCaloriesErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAlimentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox nomAlimentTextBox;
        internal System.Windows.Forms.Label nomAlimentLabel;
        internal System.Windows.Forms.Button quitterButton;
        internal System.Windows.Forms.GroupBox compositionAlimentGroupBox;
        internal System.Windows.Forms.Label g3Label;
        internal System.Windows.Forms.Label g2Label;
        internal System.Windows.Forms.Label g1Label;
        internal System.Windows.Forms.TextBox proteinesTextBox;
        internal System.Windows.Forms.TextBox glucidesTextBox;
        internal System.Windows.Forms.TextBox lipidesTextBox;
        internal System.Windows.Forms.Label proteineLabel;
        internal System.Windows.Forms.Label glucidesLabel;
        internal System.Windows.Forms.Label lipidesLabel;
        internal System.Windows.Forms.Button effacerButton;
        internal System.Windows.Forms.Button calculerButton;
        internal System.Windows.Forms.GroupBox sommaireAlimentsGroupBox;
        internal System.Windows.Forms.Label nombreTotalCaloriesLabel;
        internal System.Windows.Forms.Label nombreAlimentsLabel;
        internal System.Windows.Forms.Label totalCaloriesLLabel;
        internal System.Windows.Forms.Label nombreAlimentsLLabel;
        internal System.Windows.Forms.GroupBox caloriesAlimentsGroupBox;
        internal System.Windows.Forms.Label nombreCaloriesAlimentLabel;
        internal System.Windows.Forms.Label caloriesAlimentsLLabel;
        private System.Windows.Forms.ErrorProvider compteurCaloriesErrorProvider;
        internal System.Windows.Forms.Button addAlimentFromClassButton;
        private System.Windows.Forms.DataGridView listAlimentDataGridView;
    }
}

