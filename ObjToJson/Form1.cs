using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjToJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertToObject_Click(object sender, EventArgs e)
        {
            var code = txtCode.Text;
            var sb = new StringBuilder();

            using (StringReader reader = new StringReader(code))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    //split the string on : (assumes one property per line)
                    var parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        var prop = parts[0].Trim().Replace("\"", string.Empty);
                        var newProp = prop + ": " + parts[1];
                        sb.Append(newProp);
                    } else
                    {
                        //just stick it back in (TWSS)
                        sb.Append(line);
                    }
                }

            }

            txtCode.Text = sb.ToString();
        }
    }
}
