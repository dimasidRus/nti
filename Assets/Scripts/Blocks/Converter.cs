using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Converter : MonoBehaviour
{

    private BoxCollider trigger;
    private SpawnCollider spawn;

    public int resourseId1;
    public int neededAmount1;
    public int currentAmount1;

    public int resourseId2;
    public int neededAmount2;
    public int currentAmount2;

    public int outputId;
    public int outputBuffer;

    public GameObject resourePrefab;


    void Start()
    {
        spawn = gameObject.GetComponentInChildren<SpawnCollider>();
    }

    private void FixedUpdate()
    {
        if (currentAmount1 >= neededAmount1 && currentAmount2 >= neededAmount2)
        {
            currentAmount1 -= neededAmount1;
            currentAmount2 -= neededAmount2;
            outputBuffer++;
        }
        if (spawn.isFree)
        {
            Instantiate(resourePrefab, position:spawn.transform.position, rotation:spawn.transform.rotation);
        }
    }

    public void RegisterTrigger(Collider other)
    {
        GameObject otherGO = other.gameObject;
        int otherId = otherGO.GetComponent<Resourse>().id;

        if (otherId == resourseId1)
            currentAmount1++;
        else if (otherId == resourseId2)
            currentAmount2++;

        Destroy(otherGO);
    }
}
