using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorLocomotion : MonoBehaviour {

    public float locomotionWidth = 0.1f;
    public float locomotionHeight = 0.1f;
    public float locomotionSpeed = 0.1f;

    private int movementCount;

    GameObject[] conveyors;
    GameObject[] movables;

	void Start () {
        GetConveyors();
        GetMovables();
        movementCount = (int)(1f / Time.fixedDeltaTime) + 1;
    }
	
	void Update () {
		
	}

    private void FixedUpdate()
    {
        GetConveyors();
        GetMovables();
        LocomotionTick();
    }

    void GetConveyors()
    {
        conveyors = GameObject.FindGameObjectsWithTag("Conveyor");
    }

    void GetMovables()
    {
        movables = GameObject.FindGameObjectsWithTag("Movable");
    }

    //TODO add collision check

    void LocomotionTick()
    {
        foreach (GameObject movable in movables)
        {
            foreach (GameObject conveyor in conveyors)
            {
                Resourse resourse = movable.GetComponent<Resourse>();
                if (resourse.movement.Count == 0 && (conveyor.transform.position + conveyor.transform.up * 0.6f - movable.transform.position).magnitude < 0.01f)
                {
                    Vector3 move = conveyor.transform.forward / movementCount;
                    for (int i = 0; i < movementCount; i++)
                    {
                        resourse.movement.Enqueue(move);
                    }
                }
            }
        }
    }
}
