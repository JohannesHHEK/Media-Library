using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassenliste
{
    class ProgramControl
    {
        public void save(Model model)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine("format,primaryGenre,primaryStyle,secondaryGenres,secondaryStyles,catalogNumber,artists,title,year");
                    foreach (Album media in model.medialist)
                    {
                        sw.Write(media.format + ",");
                        sw.Write(media.primaryGenre + ",");
                        sw.Write(media.primaryStyle + ",");
                        sw.Write(media.secondaryGenres + ",");
                        sw.Write(media.secondaryStyles + ",");
                        sw.Write(media.catalogNo + ",");
                        sw.Write(media.artist + ",");
                        sw.Write(media.title + ",");
                        sw.WriteLine(media.release);
                    }
                    
                }

            }
        }

        public void updateID(List<MediaObject> medialist)
        {
            int index = 0;
            foreach (MediaObject media in medialist)
            {
                media.id = index;
                index++;
            }

        }

        public string checkIfNULL(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return("Der Wert ist leer.");
            }
            else
            {
                return value;
            }
            
        }
    }
}
