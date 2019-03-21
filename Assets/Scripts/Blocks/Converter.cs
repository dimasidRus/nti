using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Converter : MonoBehaviour
{
    private Util util;
    private BoxCollider trigger;

    public int resourseId1;
    public int neededAmount1;
    public int currentAmount1;

    public int resourseId2;
    public int neededAmount2;
    public int currentAmount2;

    public int outputId;
    public int outputBuffer;

    public float spawnDelay = 1f;
    private float timePassed = 0f;

    public GameObject resoursePrefab;

    private void Start()
    {
        util = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<Util>();
    }

    private void Update()
    {
        timePassed += Time.deltaTime;

        if (currentAmount1 >= neededAmount1 && currentAmount2 >= neededAmount2)
        {
            currentAmount1 -= neededAmount1;
            currentAmount2 -= neededAmount2;
            outputBuffer++;
        }
        if (outputBuffer > 0 && timePassed >= spawnDelay)
        {
            timePassed = 0f;
            SpawnResourse();
            outputBuffer--;
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

    private void SpawnResourse()
    {
        GameObject res = Instantiate(resoursePrefab, transform.position + transform.forward + transform.up * 0.6f, transform.rotation);
        res.GetComponent<Resourse>().id = outputId;
    }
}
