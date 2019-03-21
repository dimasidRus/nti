using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resourse : MonoBehaviour {
    public int id;
    public Queue<Vector3> movement;
    private int movementCount;

    private void Start()
    {
        movementCount = (int)(1f / Time.fixedDeltaTime) + 1;
        movement = new Queue<Vector3>(movementCount);
    }

    private void FixedUpdate()
    {
        if (movement.Count > 0)
            transform.position += movement.Dequeue();
    }
}
