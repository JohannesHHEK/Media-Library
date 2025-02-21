using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace Klassenliste
{
    class DataImport
    {
        public List<MediaObject> readFile(OpenFileDialog openFileDialog1, string type)
        {
            Model model = new Model();
            string[] input;
            int index = 0;
            using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
            {
                if(type == "Album")
                {
                    while (!sr.EndOfStream)
                    {
                        string row = sr.ReadLine();
                        if (index > 0)
                        {
                            Album album = new Album();
                            bool fix = false;
                            
                            if (row.Length > 0 && row[0] == '"')
                            {
                                input = row.Split('"');


                                for (int i = 1; i < input.Length; i += 2)  // Start at index 1 and increment by 2 (1, 3, 5, ...)
                                {
                                    input[i] = input[i].Replace(",", "*");  // Replace commas with asterisks
                                }
                            }
                            else
                            {
                                if (row.Contains('"'))
                                {
                                    input = row.Split('"');


                                    for (int i = 1; i < input.Length; i += 2)  // Start at index 1 and increment by 2 (1, 3, 5, ...)
                                    {
                                        input[i] = input[i].Replace(",", "*");  // Replace commas with asterisks
                                    }

                                }
                                else
                                {
                                    fix = true;
                                    input = null;
                                }

                            }
                            string rejoin;
                            if (fix == false)
                            {
                                rejoin = string.Join("\"", input);
                            }
                            else
                            {
                                rejoin = row;
                            }

                            string[] tokens = rejoin.Split(',');

                            // Überprüfe, ob genügend Tokens vorhanden sind
                            if (tokens.Length >= 9)
                            {
                                album.format = tokens[0].Replace("*", ",");
                                album.primaryGenre = tokens[1].Replace("*", ",");
                                album.primaryStyle = tokens[2].Replace("*", ",");
                                album.secondaryGenres = tokens[3].Replace("*", ",");
                                album.secondaryStyles = tokens[4].Replace("*", ",");
                                album.catalogNo = tokens[5].Replace("*", ",");
                                album.artist = tokens[6].Replace("*", ",");
                                album.title = tokens[7].Replace("*", ",");
                                album.id = index;

                                // Versuche, den Release-Wert sicher in einen Integer zu konvertieren
                                if (int.TryParse(tokens[8].Replace("*", ","), out int releaseYear))
                                {
                                    album.release = releaseYear;
                                }
                                else
                                {
                                    album.release = 0; // Falls die Konvertierung fehlschlägt, setze auf einen Standardwert
                                }

                                model.medialist.Add(album);
                            }
                            else
                            {
                                foreach (string token in tokens)
                                {
                                    MessageBox.Show(" + " + token);
                                }

                            }
                        }
                        else
                        {
                            index++;
                        }
                        
                        
                    }
                }
                
            }
            return model.medialist;
        }

        //public string DataCleaning(string temp)
        //{
            //string[] tokens = temp.Split('"');
        //}
    }
}
