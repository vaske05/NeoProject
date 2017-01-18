using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Neo4jClient;
using Neo4jClient.Cypher;
using NeoProject.Model;

namespace NeoProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Database Connection
            var client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "neo4j1");

            try
            {
                client.Connect();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

       

        // POLICE STATION BUTTON
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if(PoliceStationCanvas.IsVisible)
            {
                PoliceStationCanvas.Visibility = Visibility.Hidden;
            }
            else
            {
                PoliceStationCanvas.Visibility = Visibility.Visible;
            }
        }

        // PERSON BUTTON
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if(PersonCanvas.IsVisible)
            {
                PersonCanvas.Visibility = Visibility.Hidden;
            }
            else
            {
                PersonCanvas.Visibility = Visibility.Visible;
            }

        }

        // OBJECT BUTTON
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if(ObjectCanvas.IsVisible)
            {
                ObjectCanvas.Visibility = Visibility.Hidden;
            }
            else
            {
                ObjectCanvas.Visibility = Visibility.Visible;
            }
        }

        // ALARM SYSTEM BUTTON
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if(AlarmSystemCanvas.IsVisible)
            {
                AlarmSystemCanvas.Visibility = Visibility.Hidden;
            }
            else
            {
                AlarmSystemCanvas.Visibility = Visibility.Visible;
            }
        }


        // PATROL BUTTON
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if(PatrolCanvas.IsVisible)
            {
                PatrolCanvas.Visibility = Visibility.Hidden;
            }
            else
            {
                PatrolCanvas.Visibility = Visibility.Visible;
            }
        }


        // INTERVENTION BUTTON
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if(InterventionCanvas.IsVisible)
            {
                InterventionCanvas.Visibility = Visibility.Hidden;
            }
            else
            {
                InterventionCanvas.Visibility = Visibility.Visible;
            }
        }


        // POLICE DEPARTMENT BUTTON
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if(PoliceDepartmentCanvas.IsVisible)
            {
                PoliceDepartmentCanvas.Visibility = Visibility.Hidden;
            }
            else
            {
                PoliceDepartmentCanvas.Visibility = Visibility.Visible;
            }
        }


        // VEHICLE BUTTON
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if(VehicleCanvas.IsVisible)
            {
                VehicleCanvas.Visibility = Visibility.Hidden;
            }
            else
            {
                VehicleCanvas.Visibility = Visibility.Visible;
            }
        }


        // Create new Police Station Button
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
