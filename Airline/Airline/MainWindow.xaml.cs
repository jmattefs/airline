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

namespace Airline
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_f1001_Click(object sender, RoutedEventArgs e)
        {
            SmallPlaneSW spSW = new SmallPlaneSW(0, 0, 0, 0, "", "", "", "");
            textBoxf1000.Text = spSW.ToString();
        }

        private void button_f1001_sell_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            Sales sales = new Sales();
            Passengers p = new Passengers("", 0);
            Write write = new Write();
            Read read = new Read();
            string msg = "Flight-1001 Total Revenue : $";
            string generate = p.genPerson().ToString();
            soldf1001.Text = sales.SmallSales().ToString();
            textBoxf1000.Text = msg + sales.SmallRevenue(Int32.Parse(soldf1001.Text));
            write.clearManifest1001();
            write.manifestHeader1001();
            while (i < Int32.Parse(soldf1001.Text))
            {
                write.writeInfoToManifest1001(p.genPerson().ToString());
                read.readInfoFromManifest1001();
                i++;
            }
        }

        private void button_f1002_Click(object sender, RoutedEventArgs e)
        {
            SmallPlaneNE spNE = new SmallPlaneNE(0, 0, 0, 0, "", "", "", "");
            textBoxf1000.Text = spNE.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            Sales sales = new Sales();
            Passengers p = new Passengers("", 0);
            Write write = new Write();
            Read read = new Read();
            string msg = "Flight-1002 Total Revenue : $";
            string generate = p.genPerson().ToString();
            soldf1002.Text = sales.SmallSales().ToString();
            textBoxf1000.Text = msg + sales.SmallRevenue(Int32.Parse(soldf1002.Text));
            write.clearManifest1002();
            write.manifestHeader1002();
            while (i < Int32.Parse(soldf1002.Text))
            {
                write.writeInfoToManifest1002(p.genPerson().ToString());
                read.readInfoFromManifest1002();
                i++;
            }
        }

        private void button_f101_Click(object sender, RoutedEventArgs e)
        {
            MediumPlaneSW mpSW = new MediumPlaneSW(0, 0, 0, 0, "", "", "", 0, "");
            textBoxf100.Text = mpSW.ToString();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            Sales sales = new Sales();
            Passengers p = new Passengers("", 0);
            Write write = new Write();
            Read read = new Read();
            int amount;
            int amountFirst;
            int amountCoach;
            string msg = "Flight-101 Total Revenue : $";
            string generate = p.genPerson().ToString();
            amountFirst = sales.MediumRev1st(sales.MediumSales1st());
            amountCoach = sales.MediumRevCoach(sales.MediumSalesCoach());
            amount = sales.MediumSalesCoach() + sales.MediumSales1st();
            soldf101.Text = amount.ToString();
            textBoxf100.Text = msg + sales.TotalMediumRevenue(amountFirst,amountCoach);
            write.clearManifest101();
            write.manifestHeader101();
            while (i < Int32.Parse(soldf101.Text))
            {
                write.writeInfoToManifest101(p.genPerson().ToString());
                read.readInfoFromManifest101();
                i++;
            }
        }

        private void button_f102_Click(object sender, RoutedEventArgs e)
        {
            MediumPlaneNE mpNE = new MediumPlaneNE(0, 0, 0, 0, "", "", "", 0, "");
            textBoxf100.Text = mpNE.ToString();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            Sales sales = new Sales();
            Passengers p = new Passengers("", 0);
            Write write = new Write();
            Read read = new Read();
            int amount;
            int amountFirst;
            int amountCoach;
            string msg = "Flight-102 Total Revenue : $";
            string generate = p.genPerson().ToString();
            amountFirst = sales.MediumRev1st(sales.MediumSales1st());
            amountCoach = sales.MediumRevCoach(sales.MediumSalesCoach());
            amount = sales.MediumSalesCoach() + sales.MediumSales1st();
            soldf102.Text = amount.ToString();
            textBoxf100.Text = msg + sales.TotalMediumRevenue(amountFirst, amountCoach);
            write.clearManifest102();
            write.manifestHeader102();
            while (i < Int32.Parse(soldf102.Text))
            {
                write.writeInfoToManifest102(p.genPerson().ToString());
                read.readInfoFromManifest102();
                i++;
            }
        }

        private void button_f11_Click(object sender, RoutedEventArgs e)
        {
            BigPlaneSW bpSW = new BigPlaneSW(0, 0, 0, 0, "", "", "", 0, "");
            textBoxf10.Text = bpSW.ToString();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            Sales sales = new Sales();
            Passengers p = new Passengers("", 0);
            Write write = new Write();
            Read read = new Read();
            int amount;
            int amountFirst;
            int amountCoach;
            string msg = "Flight-11 Total Revenue : $";
            string generate = p.genPerson().ToString();
            amountFirst = sales.LargeRev1st(sales.LargeSales1st());
            amountCoach = sales.LargeRevCoach(sales.LargeSalesCoach());
            amount = sales.LargeSalesCoach() + sales.LargeSales1st();
            soldf11.Text = amount.ToString();
            textBoxf10.Text = msg + sales.TotalLargeRevenue(amountFirst, amountCoach);
            write.clearManifest11();
            write.manifestHeader11();
            while (i < Int32.Parse(soldf11.Text))
            {
                write.writeInfoToManifest11(p.genPerson().ToString());
                read.readInfoFromManifest11();
                i++;
            }
        }

        private void button_f12_Click(object sender, RoutedEventArgs e)
        {
            BigPlaneNE bpNE = new BigPlaneNE(0, 0, 0, 0, "", "", "", 0, "");
            textBoxf10.Text = bpNE.ToString();
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            Sales sales = new Sales();
            Passengers p = new Passengers("", 0);
            Write write = new Write();
            Read read = new Read();
            int amount;
            int amountFirst;
            int amountCoach;
            string msg = "Flight-12 Total Revenue : $";
            string generate = p.genPerson().ToString();
            amountFirst = sales.LargeRev1st(sales.LargeSales1st());
            amountCoach = sales.LargeRevCoach(sales.LargeSalesCoach());
            amount = sales.LargeSalesCoach() + sales.LargeSales1st();
            soldf12.Text = amount.ToString();
            textBoxf10.Text = msg + sales.TotalLargeRevenue(amountFirst, amountCoach);
            write.clearManifest12();
            write.manifestHeader12();
            while (i < Int32.Parse(soldf12.Text))
            {
                write.writeInfoToManifest12(p.genPerson().ToString());
                read.readInfoFromManifest12();
                i++;
            }
        }
    }
}
