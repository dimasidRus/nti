﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resourse : MonoBehaviour {
    public int id;
    public Queue<Vector3> movement;
    public Color[] colors;
    private int movementCount;


    private void Start()
    {
        movementCount = (int)(1f / Time.fixedDeltaTime) + 1;
        movement = new Queue<Vector3>(movementCount);
        gameObject.GetComponent<Renderer>().material.color = colors[id];
    }

    private void FixedUpdate()
    {
        if (movement.Count > 0)
            transform.position += movement.Dequeue();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
            Destroy(gameObject);
    }
}
