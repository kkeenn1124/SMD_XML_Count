using System.Text;
using System.Timers;
using System.Xml;

namespace Factory2_SMD_XML
{
    public partial class Form1 : Form
    {
        public static int pp = 0, ff = 0;
        public static int file_count = 0;

        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlDocument xml = new XmlDocument();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            settings.Encoding = Encoding.GetEncoding("big5"); //System.Text.Encoding.CodePages
            //DirectoryInfo file = new DirectoryInfo(@"D:\G947\my\temp");
        }

        public void Timer()
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        XmlDocument xml = new XmlDocument();
        //XmlWriterSettings settings = new XmlWriterSettings();
        //settings.Indent = true;
        //    settings.OmitXmlDeclaration = true;
        //    settings.Encoding = Encoding.GetEncoding("big5"); //System.Text.Encoding.CodePages


        DirectoryInfo file = new DirectoryInfo(@"D:\G947\my\temp");

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (FileInfo file_item in file.GetFiles())
            {
                if (file_item.ToString().Contains(".xml"))
                {
                    Console.WriteLine(file_item.Name);

                    xml.Load($@"{file_item.FullName}");

                    XmlNode rootNode = xml.DocumentElement;

                    foreach (XmlNode item in rootNode.SelectNodes("Panel/Board"))
                    {
                        string sta = item.Attributes["Status"].InnerText;

                        if (sta == "P")
                            pp++;
                        else
                            ff++;

                    }

                    File.Move(file_item.FullName, $@"D:\G947\my\done\{file_item.Name}", true);
                    file_count++;
                    label4.Text = "COUNT¡G" + file_count.ToString();
                    if (file_count == 20)
                    {
                        label1.Text = "PASS¡G" + pp.ToString();
                        label2.Text = "FAIL¡G" + ff.ToString();
                        label3.Text = "TOTAL¡G" + (pp + ff).ToString();
                        file_count = 0;
                        pp = 0;
                        ff = 0;
                    }
                    if (file_count == 1)
                    {
                        label1.Text = "PASS¡G0";
                        label2.Text = "FAIL¡G0";
                        label3.Text = "TOTAL¡G0";
                    }
                }
                else
                {
                    file_item.Delete();
                }
            }
            Timer();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "STOP")
            {
                button1.Text = "START";
                timer1.Stop();
                label1.Text = "PASS¡G" + pp.ToString();
                label2.Text = "FAIL¡G" + ff.ToString();
                label3.Text = "TOTAL¡G" + (pp + ff).ToString();
                label5.Text = "¤w°±¤î";
            }
            else
            {
                button1.Text = "STOP";
                file_count = 0;
                pp = 0;
                ff = 0;
                label1.Text = "PASS¡G0";
                label2.Text = "FAIL¡G0";
                label3.Text = "TOTAL¡G0";
                label4.Text = "COUNT¡G0";
                label5.Text = "¤w±Ò°Ê";
                Timer();
            }

        }
    }
}