using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    public int outputId;

    public float spawnDelay = 1f;
    private float timePassed = 0f;

    public GameObject resoursePrefab;

    private SpawnCollider[] spawns;
    private Util util;

    private void Start()
    {
        util = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<Util>();
    }

    private void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= spawnDelay)
        {
            foreach (Vector3 convpos in util.GetAdjacentConveyors(transform.position))
                SpawnResourse(convpos + transform.up * .6f);
            timePassed = 0f;
        }
    }

    private void SpawnResourse(Vector3 pos)
    {
        GameObject res = Instantiate(resoursePrefab, pos, transform.rotation);
        res.GetComponent<Resourse>().id = outputId;
    }
}
