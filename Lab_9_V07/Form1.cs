using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_9_V07
{
    public partial class Form1 : Form
    {
        private Button[] ButtonNames;

        public Form1()
        {
            InitializeComponent();




        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CreateElements(sender, e);
        }

        String[] nameBox = { "Координати", "Швидкість", "Прискорення" };
        String[] names = { "Закон руху", "X=sin(pit^2/2)" };
        String[] nameButton = { "Розрахунок", "Вихід", "Перевірити" };
        String[] timeLabels = { "t = ", "t = ", "t = " };
        TextBox[,] myMasTextBox;

        private void CreateElements(object sender, EventArgs e)
        {

            #region create time labels
            int startX = 210;
            int startY = 170;
            int xSp = 205;



            for (int i = 0; i < timeLabels.Length; i++)
            {
                Label timeLabel = new Label();
                timeLabel.Text = timeLabels[i];
                timeLabel.Size = new Size(50, 20);
                timeLabel.Location = new Point(startX + i * xSp, startY);
                timeLabel.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(timeLabel);
            }
            #endregion

            #region create buttons
            ButtonNames = new Button[2];
            for (int i = 0; i < 2; i++)
            {
                ButtonNames[i] = new Button();
                ButtonNames[i] = new Button();
                ButtonNames[i].Text = nameButton[i];  
                ButtonNames[i].Size = new Size(100, 30);
                ButtonNames[i].Location = new Point(590, 420 + i * 40);
                this.Controls.Add(ButtonNames[i]);
                ButtonNames[i].Click += ButtonClick;
                
            }
            #endregion

            #region name label form
            Label[] labelsname = new Label[names.Length];
            int lbX = 350;
            int lbY = 50;
            int spY = 30;
            for (int i = 0; i < labelsname.Length; i++)
            {
                labelsname[i] = new Label();
                labelsname[i].Text = names[i];
                labelsname[i].Size = new Size(150, 20);
                labelsname[i].Location = new Point(lbX, lbY + i * spY);
                this.Controls.Add(labelsname[i]);
            }
            #endregion

            #region create row headers
            int x = 125;
            int y = 200;
            int ySpacing = 30;

            Label[] labelnameBox = new Label[nameBox.Length];
            for (int i = 0; i < labelnameBox.Length; i++)
            {
                labelnameBox[i] = new Label();
                labelnameBox[i].Text = nameBox[i];
                labelnameBox[i].Size = new Size(100, 20);
                labelnameBox[i].Location = new Point(x - 110, y + i * ySpacing);
                this.Controls.Add(labelnameBox[i]);
            }
            #endregion

            #region create textbox
            int rows = 3;
            int cols = 3;
            int xSpacing = 205;

            myMasTextBox = new TextBox[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    myMasTextBox[i, j] = new TextBox();
                    myMasTextBox[i, j].Size = new Size(200, 20);
                    myMasTextBox[i, j].Location = new Point(x + j * xSpacing, y + i * ySpacing);
                    this.Controls.Add(myMasTextBox[i, j]);
                    myMasTextBox[i, j].Text = $"Box "+ " " + i + " " + j;
                }
            }
            #endregion
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            switch (clickedButton.Text)
            {
                case "Розрахунок":
                    MessageBox.Show("Виконується розрахунок...");
                    break;
                case "Вихід":
                    Application.Exit();
                    break;
                case "Перевірити":
                    MessageBox.Show("Перевірка виконана!");
                    break;
            }
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (ButtonNames != null && ButtonNames.Length > 0)
            {
                
                if (radioButton2.Checked)
                {
                    ButtonNames[0].Text = nameButton[2]; 
                }
                else if (radioButton1.Checked)
                {
                    ButtonNames[0].Text = nameButton[0]; 
                }
            }
        }
    }
}