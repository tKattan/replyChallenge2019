using System;
using System.IO;

public class InputReader{

    string[] map;
    string[] customOffice;

    /*N: the width of the map
      M: the height of the map
      C: the number of Customer Headquarters
      R: representing the maximum number of Reply Offices that can be built*/

    string mapInfo;
    int currentLine = 0;

    public InputReader(string path){
        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;

            while ((line = sr.ReadLine()) != null) //map init loop
                {
                    if(currentLine = 0){
                        mapInfo = line; 
                    }
                    


                    currentLine++;
                }    
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}