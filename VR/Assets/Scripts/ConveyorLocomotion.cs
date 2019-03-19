using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float locomotionWidth;
    public float locomotionHeight;

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
    bool CoveyorValid(GameObject conveyor)
    {
        Transform conTransform = conveyor.transform;
        Vector3 conPos = conTransform.position;

        Vector3 leftBottom;
        Vector3 rightTop;

        leftBottom = conPos - conTransform.right * locomotionWidth - conTransform.up * locomotionHeight;
        leftBottom = conPos + conTransform.forward * (1 - locomotionWidth) + conTransform.right * locomotionWidth + conTransform.up * locomotionHeight;

        return valid;
    }

    void LocomotionTick()
    {

    }
}
