using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace ZuschussAntragHelfer
{
    public partial class Form1 : Form
    {
        private List<Person> people;
        private Person selected;
        AutoCompleteStringCollection col;
        private bool clickedOnElement;
        public Form1()
        {
            RegisterHotKey(this.Handle, HOTKEY_ID, 6, (int)Keys.K);
            InitializeComponent();
        }
        public void enterData()
        {
            if(selected == null)
            {
                MessageBox.Show("Niemand Ausgwählt","Information", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                return;
            }
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.TextEntry(selected.Vorname + " " + selected.Nachname);
            Thread.Sleep(200);
            if (!checkBox1.Checked)
            {
                sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);
                sim.Keyboard.TextEntry("" + selected.getAge());
                Thread.Sleep(200);
            }
            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);
            sim.Keyboard.TextEntry(selected.Ort);
            Thread.Sleep(200);
            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);
            sim.Keyboard.TextEntry(selected.Adresse);
            Thread.Sleep(200);
            sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.TAB);
            if (checkBox2.Checked)
            {
                sim.Keyboard.TextEntry(textBox2.Text);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Csv Dateien (*.csv)|*.csv|Alle Dateien (*.*)|*.*";
            if (DialogResult.OK != ofd.ShowDialog())
            {
                return;
            }
            using (var reader = new StreamReader(ofd.FileName, Encoding.Default))
            {
                var values = reader.ReadLine().Split(';');
                var indexDict = new Dictionary<string, int>();
                indexDict.Add("Vorname", Array.IndexOf(values, "Vorname"));
                indexDict.Add("Nachname", Array.IndexOf(values, "Nachname"));
                indexDict.Add("Geburtsdatum", Array.IndexOf(values, "Geburtsdatum"));
                indexDict.Add("Adresse", Array.IndexOf(values, "Straße, Nr."));
                indexDict.Add("PLZ", Array.IndexOf(values, "PLZ"));
                indexDict.Add("Ort", Array.IndexOf(values, "Ort"));

                while (!reader.EndOfStream)
                {
                    values = reader.ReadLine().Split(';');
                    Person p = new Person();
                    p.Vorname = values[indexDict["Vorname"]];
                    p.Nachname = values[indexDict["Nachname"]];
                    p.Geburtsdatum = Convert.ToDateTime(values[indexDict["Geburtsdatum"]]);
                    p.Adresse = values[indexDict["Adresse"]];
                    p.Ort = values[indexDict["PLZ"]] + " " + values[indexDict["Ort"]];
                    people.Add(p);
                }
            }
            String[] t;
            if (radioButton1.Checked)
            {
                t = people.Select(p => p.Nachname + ", " + p.Vorname).ToArray();
            }
            else
            {
                t = people.Select(p => p.Vorname + ", " + p.Nachname).ToArray();
            }
            col = new AutoCompleteStringCollection();
            col.AddRange(t);
            textBox1.AutoCompleteCustomSource = col;
            label1.Text = people.Count + " Pfadfinder eingelesen";
        }
        private void init()
        {
            clickedOnElement = false;
            selected = null;
            people = new List<Person>();
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            col = new AutoCompleteStringCollection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!col.Contains(textBox1.Text))
            {
                MessageBox.Show("Niemand Ausgwählt", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selected = null;
                return;
            }
            selected = people[col.IndexOf(textBox1.Text)];
            label1.Text = selected.Vorname + " " + selected.Nachname + " ausgewählt";
        }
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        const int HOTKEY_ID = 1;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEY_ID)
            {
                enterData();
            }
            base.WndProc(ref m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            enterData();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            String[] t;
            if(radioButton1.Checked)
            {
                t = people.Select(p => p.Nachname + ", " + p.Vorname).ToArray();
            }
            else
            {
                t = people.Select(p => p.Vorname + ", " + p.Nachname).ToArray();
            }
            col = new AutoCompleteStringCollection();
            col.AddRange(t);
            textBox1.AutoCompleteCustomSource = col;
        }
    }
}
