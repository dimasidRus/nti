using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    GameObject[] conveyors;

	void Start () {
	}
	
	void Update () {
		
	}

    private void FixedUpdate()
    {
        
    }

    void GetConveyorTransforms()
    {
        conveyors = GameObject.FindGameObjectsWithTag("Conveyor");
        //conveyors = new Transform[conveyorObjects.Length];
        //for (int i = 0; i < conveyorObjects.Length; i++)
        //    conveyors[i] = conveyorObjects[i].transform;
    }

    //TODO add collision check
    bool CoveyorValid(Transform conveyor)
    {
        bool valid = true;
        if ()
        return valid;
    }

    void LocomotionTick()
    {

    }
}
