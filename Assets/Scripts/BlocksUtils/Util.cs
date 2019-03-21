using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour {
    public List<Vector3> GetAdjacentConveyors(Vector3 pos)
    {
        List<Vector3> result = new List<Vector3>(4);
        GameObject[] conveyors = GameObject.FindGameObjectsWithTag("Conveyor");
        foreach (GameObject conveyor in conveyors)
            if ((conveyor.transform.position - pos).magnitude <= 1f)
                result.Add(conveyor.transform.position);

        return result;
    }

    public bool IsFree(Vector3 pos, float dist)
    {
        bool free = true;
        foreach (GameObject res in GameObject.FindGameObjectsWithTag("Resourse"))
        {
            free &= (res.transform.position - pos).magnitude <= dist;
        }
        return free;
    }
}
