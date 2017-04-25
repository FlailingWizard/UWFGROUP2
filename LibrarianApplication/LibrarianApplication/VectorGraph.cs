using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using NLPInterfaces;

namespace LibrarianApplication
{
    /* This class displays a graphical representation of one or more featurevectors.
     * 
     * 
     */

    public partial class VectorGraph : Form
    {
        public VectorGraph(IFeatureVector vector)
        {
            InitializeComponent();

            // setup the data series
            Series scalars = seriesFromVector(vector);
            scalars.Name = "scalars";
            this.chart1.Series.Add(scalars);
        }

        public VectorGraph(List<IFeatureVector> vectorArray)
        {

            // show each vector as a seperate series
            InitializeComponent();

            // create a series from each vector and add to chart
            int vectorCount = 0;
            foreach (IFeatureVector vector in vectorArray)
            {
                Series series = new Series();
                series.Name = "Vector " + vectorCount++;
                series = seriesFromVector(vector);
                chart1.Series.Add(series);
            }

        }

        private Series seriesFromVector(IFeatureVector vector)
        {

            // create and populate data series
            Series scalars = new Series();
            for (int i = 0; i < vector.scalarCount(); i++)
            {
                scalars.Points.AddXY(i,vector.getValue(i));
            }

            return scalars;

        }



    }
}
