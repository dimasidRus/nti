using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class SceneGenerator: MonoBehaviour
{
    // Use this for initialization
    public void Read(int fileNum)
    {


        string strNum;
        if (fileNum < 10)
            strNum = "0" + fileNum.ToString();
        else
            strNum = fileNum.ToString();

        string fileName = "input" + strNum + ".txt";
        using (StreamReader reader = new StreamReader(fileName))
        {

        }
    }

    void GenerateFromFile(StreamReader reader)
    {
            string line = reader.ReadLine();
            int spawn_n = int.Parse(line); // Get number of spavners
            for (int i = 0; i < spawn_n; ++i)
            {
                line = reader.ReadLine();
                float[] info = line.Split(' ').Select(x => float.Parse(x)).ToArray();
                /* x = info[0];
                 * y = info[1];
                 * type = info[2];
                 */
            }
            line = reader.ReadLine();
            int oven_n = int.Parse(line); // Get number of converters
            for (int i = 0; i < oven_n; ++i)
            {
                line = reader.ReadLine();
                float[] info = line.Split(' ').Select(x => float.Parse(x)).ToArray();
                /* x = info[0];
                 * y = info[1];
                 * type1 = info[2];
                 * type2 = info[3];
                 * type3 = info[4];
                 * f = info[5];
                 */
            }
            line = reader.ReadLine();
            int conv_n = int.Parse(line); // Get number of conveyers
            for (int i = 0; i < conv_n; ++i)
            {
                line = reader.ReadLine();
                float[] info = line.Split(' ').Select(x => float.Parse(x)).ToArray();
                /* x = info[0];
                 * y = info[1];
                 * n_x = info[2];
                 * n_y = info[3];
                 */
            }
            line = reader.ReadLine();
            int stor_n = int.Parse(line); // Get number of stores
            for (int i = 0; i < stor_n; ++i)
            {
                line = reader.ReadLine();
                float[] info = line.Split(' ').Select(x => float.Parse(x)).ToArray();
                /* x = info[0];
                 * y = info[1];
                 */
            }
            line = reader.ReadLine();
            int time = int.Parse(line);

        
    }
}



