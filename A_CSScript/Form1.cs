using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;


namespace A_CSScript
{
    public partial class Form1 : Form
    {
        CompilerResults results = null;
        dynamic c;

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "using System.Windows.Forms;\r\n" +
                "class Program {\r\n"
                + "  int m=12; public static void Main() {\r\n"
                + "    MessageBox.Show(\"Hallo !\");\r\n"
                + "  }\r\n"
                + "}\r\n"
                + "public class C { \r\n"
                + "  public int x = 23; \r\n"
                + "  public int dbl(int n) {return n*2;} \r\n"
                + "  public int X { get { return x;} set { x=value; } } \r\n"
                + "}\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v4.0" } });
            var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll", "System.Windows.Forms.dll" });

            parameters.GenerateExecutable = true;
            parameters.GenerateInMemory = true;

            results = csc.CompileAssemblyFromSource(parameters, textBox1.Text);
            listBox1.Items.Clear();
            if (results.Errors.HasErrors)
            {
                foreach (CompilerError err in results.Errors)
                    listBox1.Items.Add(err.ErrorText);
            }
            else
            {
                listBox1.Items.Add("ok");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (results != null && !results.Errors.HasErrors)
            {
                try
                {
                    var type = results.CompiledAssembly.GetType("Program");
                    var obj = Activator.CreateInstance(type);
                    var output = type.GetMethod("Main").Invoke(obj, null);
                }
                catch (Exception exc)
                {
                    listBox1.Items.Add("error: "+exc.ToString());
                }
            }
            else
            {
                listBox1.Items.Add("compile first");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (results != null && !results.Errors.HasErrors && c!=null)
            {
                try
                {
                    int n1 = int.Parse(textBox2.Text);
                    int n2 = c.dbl1(n1);                     // dbl unbekannt!
                    listBox1.Items.Add("result = " + n2);
                }
                catch (Exception exc)
                {
                    listBox1.Items.Add("error: " + exc.ToString());
                }
            }
            else
            {
                listBox1.Items.Add("compile first");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (results != null && !results.Errors.HasErrors)
            {
                try
                {
                    var ct = results.CompiledAssembly.GetType("C");
                    c = Activator.CreateInstance(ct);
                    propertyGrid1.SelectedObject = c;
                }
                catch (Exception exc)
                {
                    listBox1.Items.Add("error: " + exc.ToString());
                }
            }
            else
            {
                listBox1.Items.Add("compile first");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (results != null && !results.Errors.HasErrors && c!=null)
            {
                try
                {
                    int n1 = c.x;
                    listBox1.Items.Add("result = " + n1);
                }
                catch (Exception exc)
                {
                    listBox1.Items.Add("error: " + exc.ToString());
                }
            }
            else
            {
                listBox1.Items.Add("compile first");
            }


        }
    }
}
