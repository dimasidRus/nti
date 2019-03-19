using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
    void ReadFileInfo() {
        string file_n = "00"; // TODO
        string name = "input" + file_n + ".txt";
        using (var reader = new StreamReader(name))
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

	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
