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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Klassenliste
{
    public partial class Form1 : Form
    {
        bool searched = false;
        Model model = new Model();
        Model temp = new Model();
        ProgramControl control = new ProgramControl();
        public Form1()
        {
            InitializeComponent();
            
        }
        public void Update_listbox(int count)
        {
            check_Checked();
            
            for (int i = 0; i < count; i++)
            {
                listBox_Albuen.Items.RemoveAt(0);
            }
            foreach (Album mediaObject in model.medialist)          //Füllt die List box mit Elementen
            {
                listBox_Albuen.Items.Add(mediaObject.title + " , Künstler = " + mediaObject.artist + ", Veröffentlichungsdatum = " + mediaObject.release);
            }
        }

        public void Update_combobox(int count)
        {
            List<string> Doppelt = new List<string>();      //Für die combobox
            
            check_Checked();
            if (check_Artist.Checked)
            {
                for (int i = 0; i < count; i++)
                {
                    search_comboBox.Items.RemoveAt(0);
                }
                foreach (Album alb in model.medialist)         //füllt die combobox
                {
                    bool stop = false;
                    foreach (string artist in Doppelt)
                    {
                        if (artist == alb.artist)
                        {
                            stop = true;
                        }

                    }
                    if (stop == false)
                    {
                        search_comboBox.Items.Add(alb.artist);
                        Doppelt.Add(alb.artist);
                    }

                }
            }
            if (check_Year.Checked)
            {
                for (int i = 0; i < count; i++)
                {
                    search_comboBox.Items.RemoveAt(0);
                }
                foreach (Album alb in model.medialist)         //füllt die combobox
                {
                    bool stop = false;
                    foreach (string artist in Doppelt)
                    {
                        if (artist == Convert.ToString(alb.release))
                        {
                            stop = true;
                        }

                    }
                    if (stop == false)
                    {
                        search_comboBox.Items.Add(Convert.ToString(alb.release));
                        Doppelt.Add(Convert.ToString(alb.release));
                    }

                }
            }
            if (check_Title.Checked)
            {
                for (int i = 0; i < count; i++)
                {
                    search_comboBox.Items.RemoveAt(0);
                }
                foreach (Album alb in model.medialist)         //füllt die combobox
                {
                    bool stop = false;
                    foreach (string artist in Doppelt)
                    {
                        if (artist == alb.title)
                        {
                            stop = true;
                        }

                    }
                    if (stop == false)
                    {
                        search_comboBox.Items.Add(alb.title);
                        Doppelt.Add(alb.title);
                    }

                }
            }
            if (chec_CatalogNr.Checked)
            {
                for (int i = 0; i < count; i++)
                {
                    search_comboBox.Items.RemoveAt(0);
                }
                foreach (Album alb in model.medialist)         //füllt die combobox
                {
                    bool stop = false;
                    foreach (string artist in Doppelt)
                    {
                        if (artist == alb.catalogNo)
                        {
                            stop = true;
                        }

                    }
                    if (stop == false)
                    {
                        search_comboBox.Items.Add(alb.catalogNo);
                        Doppelt.Add(alb.catalogNo);
                    }

                }
            }
            
            
        }

        public void check_Checked()
        {
            if(check_Artist.Checked == true && check_Year.Checked == true && check_Title.Checked == true && chec_CatalogNr.Checked == true)
            {
                check_Title.Checked = true;
            }
        }

        private void listBox_Schueler_namen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album a;
            int selected_album = listBox_Albuen.SelectedIndex;
            if (selected_album != -1)
            {
                int count = search_listBox.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    search_listBox.Items.RemoveAt(0);
                }
                if (searched)
                {
                    a = (Album)temp.medialist[selected_album];
                }
                else
                {
                    a = (Album)model.medialist[selected_album];
                }
                if (a is Album)
                {
                    search_listBox.Items.Add(control.checkIfNULL(a.artist));
                    search_listBox.Items.Add(control.checkIfNULL(a.title));
                    search_listBox.Items.Add(control.checkIfNULL(Convert.ToString(a.release)));
                    search_listBox.Items.Add(control.checkIfNULL(a.primaryGenre));
                    search_listBox.Items.Add(control.checkIfNULL(a.secondaryGenres));
                    search_listBox.Items.Add(control.checkIfNULL(a.primaryStyle));
                    search_listBox.Items.Add(control.checkIfNULL(a.secondaryStyles));
                    search_listBox.Items.Add(control.checkIfNULL(a.format));
                    search_listBox.Items.Add(control.checkIfNULL(a.catalogNo));

                }
            }
            
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            control.save(model);
            
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string testType = "Album";      //für die mögliche implementierung von anderen Medien
            DataImport dataImport = new DataImport();
            
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();      //holt den Dateipfad
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                model.medialist = dataImport.readFile(openFileDialog1, testType);
                
            }
            
            model.medialist.Sort((p, q) => p.artist.CompareTo(q.artist));
            control.updateID(model.medialist);
            
            Update_listbox(listBox_Albuen.Items.Count);
            Update_combobox(search_comboBox.Items.Count);


        }

        private void search_button_Click(object sender, EventArgs e)
        {
            searched = true;
            int count = listBox_Albuen.Items.Count;
            temp.medialist.Clear();         //zum leeren der temp

            for (int i = 0; i < count; i++)
            {
                listBox_Albuen.Items.RemoveAt(0);
            }
            
            foreach (Album alb in model.medialist)         //Füllt die List box mit Alben
            {
                if (alb.artist == search_comboBox.Text)
                {
                    listBox_Albuen.Items.Add(alb.title + " , Künstler = " + alb.artist + ", Veröffentlichungsdatum = " + alb.release);
                    temp.medialist.Add(alb);
                }
                
            }
            model.medialist.Sort((p, q) => p.title.CompareTo(q.title));
            temp.medialist.Sort((p, q) => p.title.CompareTo(q.title));
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void search_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            searched = false;
            Update_listbox(listBox_Albuen.Items.Count);
            Update_combobox(search_comboBox.Items.Count);
        }

        private void check_Artist_CheckedChanged(object sender, EventArgs e)
        {
            check_Title.Checked = false;
            check_Year.Checked = false;
            chec_CatalogNr.Checked = false;
            if (searched == false)
            {
                if (check_Artist.Checked == true)
                {
                    
                    model.medialist.Sort((p, q) => p.artist.CompareTo(q.artist));
                    Update_listbox(listBox_Albuen.Items.Count);
                    Update_combobox(search_comboBox.Items.Count);
                }
                else
                {
                    
                }
            }
            else
            {
                temp.medialist.Sort((p, q) => p.artist.CompareTo(q.artist));
            }
            
        }

        private void check_Year_CheckedChanged(object sender, EventArgs e)
        {
            check_Title.Checked = false;
            check_Artist.Checked = false;
            chec_CatalogNr.Checked = false;
            if (searched == false)
            {
                if (check_Year.Checked == true)
                {
                    
                    model.medialist.Sort((p, q) => p.release.CompareTo(q.release));
                    Update_listbox(listBox_Albuen.Items.Count);
                    Update_combobox(search_comboBox.Items.Count);
                }
                else
                {
                    
                }
            }
            else
            {
                temp.medialist.Sort((p, q) => p.release.CompareTo(q.release));
            }
            
        }

        private void check_Title_CheckedChanged(object sender, EventArgs e)
        {
            check_Artist.Checked = false;
            check_Year.Checked = false;
            chec_CatalogNr.Checked = false;
            if (searched == false)
            {
                if (check_Title.Checked == true)
                {
                    
                    model.medialist.Sort((p, q) => p.title.CompareTo(q.title));
                    Update_listbox(listBox_Albuen.Items.Count);
                    Update_combobox(search_comboBox.Items.Count);
                }
                else
                {
                    
                }
            }
            else
            {
                temp.medialist.Sort((p, q) => p.title.CompareTo(q.title));
            }
            
        }

        private void chec_CatalogNr_CheckedChanged(object sender, EventArgs e)
        {
            check_Title.Checked = false;
            check_Year.Checked = false;
            check_Artist.Checked = false;
            if (searched == false)
            {
                if (chec_CatalogNr.Checked == true)
                {
                    
                    model.medialist.Sort((p, q) => p.catalogNo.CompareTo(q.catalogNo));
                    Update_listbox(listBox_Albuen.Items.Count);
                    Update_combobox(search_comboBox.Items.Count);
                }
                else
                {
                    
                }
            }
            else
            {
                temp.medialist.Sort((p, q) => p.catalogNo.CompareTo(q.catalogNo));
            }
            
        }
    }
}
