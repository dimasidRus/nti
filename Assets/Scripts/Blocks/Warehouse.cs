using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warehouse : MonoBehaviour
{

    public int resourseId = -1;
    public int resourseAmount = 0;

    public void RegisterTrigger(Collider other)
    {
        int otherId = other.gameObject.GetComponent<Resourse>().id;
        if (resourseId == -1)
        {
            resourseId = otherId;
        }
        else if (otherId == resourseId)
        {
            resourseAmount++;
        }

        Destroy(other.gameObject);
    }
}
