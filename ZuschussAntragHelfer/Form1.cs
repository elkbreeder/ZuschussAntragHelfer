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
            if (!checkBoxTutor.Checked)
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
            if (checkBoxNight.Checked)
            {
                sim.Keyboard.TextEntry(textBoxNight.Text);
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
            if (radioButtonSurename.Checked)
            {
                t = people.Select(p => p.Nachname + ", " + p.Vorname).ToArray();
            }
            else
            {
                t = people.Select(p => p.Vorname + ", " + p.Nachname).ToArray();
            }
            col = new AutoCompleteStringCollection();
            col.AddRange(t);
            textBoxName.AutoCompleteCustomSource = col;
            labelInformation.Text = people.Count + " Pfadfinder eingelesen";
        }
        private void init()
        {
            labelInformation.Text = "";
            selected = null;
            people = new List<Person>();
            textBoxName.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            col = new AutoCompleteStringCollection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!col.Contains(textBoxName.Text))
            {
                MessageBox.Show("Niemand Ausgwählt", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selected = null;
                return;
            }
            selected = people[col.IndexOf(textBoxName.Text)];
            labelInformation.Text = selected.Vorname + " " + selected.Nachname + " ausgewählt";
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

        private void radioButtonName_CheckedChanged(object sender, EventArgs e)
        {
            String[] t;
            if(radioButtonSurename.Checked)
            {
                t = people.Select(p => p.Nachname + ", " + p.Vorname).ToArray();
            }
            else
            {
                t = people.Select(p => p.Vorname + ", " + p.Nachname).ToArray();
            }
            col = new AutoCompleteStringCollection();
            col.AddRange(t);
            textBoxName.AutoCompleteCustomSource = col;
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sourcecode verfügbar auf https://github.com/elkbreeder/ZuschussAntragHelfer","Über" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxNight_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNight.Enabled = !textBoxNight.Enabled;
        }
    }
}
