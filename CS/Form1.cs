using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace DynamicStyleSheet {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        XtraReport1 report;
        string path = "";

        private void buttonPreview_Click(object sender, EventArgs e) {
            string sheetName = "";

            switch (comboBox1.Text) {
                case "Yellow":
                    sheetName = "myStyle_Yellow.repss";
                    break;
                case "Blue":
                    sheetName = "myStyle_Blue.repss";
                    break;

            }

            report.StyleSheetPath = path + sheetName;

            report.CreateDocument();
        }

        private void Form1_Load(object sender, EventArgs e) {
            report = new XtraReport1();
            printControl1.PrintingSystem = report.PrintingSystem;

            comboBox1.SelectedIndex = 0;
            path = Application.StartupPath + @"\..\..\Styles\";
        }

        private void button1_Click(object sender, EventArgs e) {
            report.StyleSheet.SaveToFile(path + "currentStyleSheet.repss");
        }
    }
}