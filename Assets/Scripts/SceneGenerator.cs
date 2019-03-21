using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class SceneGenerator : MonoBehaviour
{
    public GameObject generatorPrefab;
    public GameObject coveyorPrefab;
    public GameObject warehousePrefab;
    public GameObject converterPrefab;

    int time;

    public void Start()
    {
        StreamReader reader = Read(0);
        Generate(reader);
    }

    public StreamReader Read(int fileNum)
    {
        string strNum;
        if (fileNum < 10)
            strNum = "0" + fileNum.ToString();
        else
            strNum = fileNum.ToString();

        string fileName = "input" + strNum + ".txt";
        StreamReader reader = new StreamReader(fileName);
        return reader;
    }

    void Generate(StreamReader reader)
    {
        string line = reader.ReadLine();
        int spawn_n = int.Parse(line); // Get number of spavners
        for (int i = 0; i < spawn_n; ++i)
        {
            line = reader.ReadLine();
            float[] info = line.Split(' ').Select(x => float.Parse(x)).ToArray();

            GameObject generator = Instantiate(generatorPrefab, new Vector3(info[0], 0.5f, info[1]), Quaternion.identity);
            generator.GetComponent<Generator>().outputId = (int)info[2];
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

            GameObject converter = Instantiate(converterPrefab, new Vector3(info[0], 0.5f, info[1]), Quaternion.LookRotation(new Vector3(-info[5], 0, -info[6])));
            converter.GetComponent<Converter>().resourseId1 = (int)info[2];
            converter.GetComponent<Converter>().resourseId2 = (int)info[3];
            converter.GetComponent<Converter>().outputId = (int)info[4];

            /* x = info[0];
             * y = info[1];
             * type1 = info[2];
             * type2 = info[3];
             * f = info[5];
             */
        }
        line = reader.ReadLine();
        int conv_n = int.Parse(line); // Get number of conveyors
        for (int i = 0; i < conv_n; ++i)
        {
            line = reader.ReadLine();
            float[] info = line.Split(' ').Select(x => float.Parse(x)).ToArray();

            GameObject conveyor = Instantiate(coveyorPrefab, new Vector3(info[0], 0.5f, info[1]), Quaternion.LookRotation(new Vector3(-info[2], 0, -info[3])));

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

            GameObject warehouse = Instantiate(warehousePrefab, new Vector3(info[0], 0.5f, info[1]), Quaternion.identity);

            /* x = info[0];
             * y = info[1];
             */
        }
        line = reader.ReadLine();
        time = int.Parse(line);
    }
}



