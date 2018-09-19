using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AreaOfCirlceClassLib;


namespace AreaOfCircleGUI
{
    public partial class mainForm : Form
    {
        private List<Circle> listOfCircles;

        public mainForm()
        {
            InitializeComponent();
            listOfCircles = new List<Circle>(2);
        }

        private void PrintItems()
        {
            this.lbListOfCircles.Items.Clear();
            foreach (var circle in listOfCircles)
            {
                this.lbListOfCircles.Items.Add(string.Format("[{0};{1}], r:{2}",circle.GetPoint.X, circle.GetPoint.Y, circle.GetRadius));
            }
        }

        private void btnAddCircle_Click(object sender, EventArgs e)
        {
            this.tbResult.Clear();
            try
            {
                double radius = double.Parse(this.tbR.Text),
                       x = double.Parse(this.tbX.Text),
                       y = double.Parse(this.tbY.Text);
                Point centerPoint = new Point(x, y);
                listOfCircles.Add(new Circle(centerPoint, radius));
                PrintItems();
            }
            catch (Exception ex)
            {
                this.tbResult.Text = ex.Message.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.listOfCircles.Clear();
            this.lbListOfCircles.Items.Clear();
            this.tbResult.Clear();
        }

        private void btnAreaCount_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbResult.Text = string.Format("Площадь пересечения двух окружностей = {0}", listOfCircles[0].GetIntersectrionArea(listOfCircles[1]));
            }
            catch (NotIntersectException ex)
            {
                this.tbResult.Text = ex.Message.ToString();
            }
        }
    }
}
