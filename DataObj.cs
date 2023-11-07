using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CS314App
{
    public class DataObj
    {
        //character used to separate data values in the text file
        private const char DELIMITER = '\t';

        //used to store the file name
        private string fileDir = "../../Data/";
        private string filePath = "";

        public DataObj()
        {
            //create the 'Data' folder to store the text files
            //if it doesn't exist
            Directory.CreateDirectory(fileDir);

            //read the name of the class and use it for the file name
            //put all files in the 'Data' folder
            filePath = fileDir + this.GetType().Name + ".txt";
        }

        public void writeDataStream()
        {
            try
            {
                //create variable to store data string
                string dataString = "";

                //use reflection to read the data members of the class
                foreach (var field in this.GetType().GetFields())
                {
                    dataString += field.GetValue(this) + DELIMITER.ToString();
                }

                //write the string to the file
                File.WriteAllText(filePath, dataString);

                //Display message
                MessageBox.Show("Data saved to file successfully.");
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.StackTrace + " - " + ex.Message);
            }

        }


        public void readDataStream()
        {
            try
            {
                //read the data from to the file
                string dataString = File.ReadAllText(filePath);

                //create variable to store data string
                string[] values = dataString.Split(DELIMITER);
                int index = 0;

                //use reflection to write the data members of the class
                foreach (var field in this.GetType().GetFields())
                {
                    field.SetValue(this, values[index]);
                    index++;
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.StackTrace + " - " + ex.Message);
            }
        }


    }
}

