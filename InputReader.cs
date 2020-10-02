using System;
using System.IO;
using System.Collections.Generic;
using replyChallenge2019;
public class InputReader{

    /* to get one position of the map
     * if we want the position x=3 and y=5
     * we do map[4].strAt(3)
     */
    List<string> map;

    /* mapInfo contains :
      1: the width of the map
      2: the height of the map
      3: the number of Customer Headquarters
      4: representing the maximum number of Reply Offices that can be built*/

    string mapInfo;
    List<Offices> officesList;
    int currentLine = 0;

    public InputReader(string path){
        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;

            while ((line = sr.ReadLine()) != null) //map init loop
                {
                    if(this.currentLine == 0){
                        this.mapInfo = line; 
                        this.currentLine++;
                        continue;
                    }
                    if(this.currentLine <= this.mapInfo.valAt(3)){
                        this.officesList.Add(new Offices(line.valAt(1), line.valAt(2), line.valAt(3)));
                    }
                    else{
                        this.map.Add(line);
                    }
                    this.currentLine++;
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