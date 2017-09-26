using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;

namespace Test_vacantion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var xmldata = new XmlDataDocument();
                xmldata.DataSet.ReadXml(Application.StartupPath + @"\ExperimentResults.xml");
                dataGridView1.DataSource = xmldata.DataSet;
                dataGridView1.DataMember = "session";
                dataGridView2.DataSource = xmldata.DataSet;
                dataGridView2.DataMember = "datum";

                var xml = XDocument.Load("ExperimentResults.xml");

                var averageResults = xml.Root
                    .Descendants("datum")
                    .Select(element => new
                    {
                        Day = int.Parse(element.Element("studyday").Value),
                        Value = double.Parse(element.Element("value").Value, CultureInfo.InvariantCulture)
                    })
                    .GroupBy(pair => pair.Day)
                    .Select(grouping => new
                    {
                        Day = grouping.Key,
                        Average = grouping.Select(pair => pair.Value).Average()
                    })
                    .ToList();

                foreach (var dayResult in averageResults)
                {
                    chart1.Series[0].Points.AddXY(dayResult.Day, dayResult.Average);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }        
    }
}