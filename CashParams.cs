using System;
using ePlus.MetaData.ExternReport;
using ePlus.MetaData.Core;
using ePlus.CommonEx.Reporting;
using System.Xml;
using System.IO;
using System.Reflection;

namespace RCXYZMarginBonus
{
	public partial class CashParams : ExternalReportForm, IExternalReportFormMethods
    {
        public CashParams()
        {
            InitializeComponent();
        }
        private string SettingsFilePath
        {
            get
            {
                System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
                return Path.Combine(Utils.TempDir(), asm.GetName().Name.ToString() + ".xml");
            }
        }
		private void ClearValues()
		{
            setDefaultPeriod();
			contractorsMulti.Items.Clear();
		}

        public void Print(string[] reportFiles)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root = Utils.AddNode(doc, "XML", null);
            Utils.AddNode(root, "DATE_FR", ucPeriod.DateFrom.Date);
            Utils.AddNode(root, "DATE_TO", ucPeriod.DateTo.Date.AddDays(1).AddSeconds(-1));
            Utils.AddNode(root, "USE_ACTS", Convert.ToInt16(checkBoxUseActs.Checked));

            contractorsMulti.AddItems(root, "CONTRACTOR");
			
            ReportFormNew rep = new ReportFormNew();

            rep.LoadData("MARGIN_BONUS_OPTIMA", doc.InnerXml);

            rep.BindDataSource("Cash_DS_Table0", 0);

            rep.ReportPath = Path.Combine(Path.GetDirectoryName(reportFiles[0]), "Bonus.rdlc");

            rep.AddParameter("date_fr", ucPeriod.DateFrText);
            rep.AddParameter("date_to", ucPeriod.DateToText);
            rep.AddParameter("VER_DLL", Assembly.GetExecutingAssembly().ManifestModule.ScopeName);
            rep.ExecuteReport(this);
        }        


        public string ReportName
        {
            //Название отчёта взять из информации о сборке
            get { return ((AssemblyDescriptionAttribute)AssemblyDescriptionAttribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyDescriptionAttribute))).Description; }
        }

        public override string GroupName
        {
            get { return new ReportGroupDescription(ReportGroup.CashReports).Description; }
        }

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			ClearValues();
		}

        private void CashParams_Load(object sender, EventArgs e)
        {
            setDefaultPeriod();
        }

        private void setDefaultPeriod()
        {
            ucPeriod.DateTo = DateTime.Now;
            ucPeriod.DateFrom = DateTime.Now.AddMonths(-1);
        }
    }
}