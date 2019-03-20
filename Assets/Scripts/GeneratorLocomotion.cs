using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorBehaviourScript : MonoBehaviour {

    public float locomotionWidth = 0.1f;
    public float locomotionHeight = 0.1f;

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
        bool valid = true;

        Transform conTransform = conveyor.transform;
        Vector3 conPos = conTransform.position;

        Vector3 leftBottom;
        Vector3 rightTop;
        leftBottom = conPos - conTransform.right * locomotionWidth - conTransform.up * locomotionHeight;
        rightTop = conPos + conTransform.forward * (1 - locomotionWidth) + conTransform.right * locomotionWidth + conTransform.up * locomotionHeight;

        valid &= transform.position.x >= Mathf.Min(leftBottom.x, rightTop.x);
        valid &= transform.position.x <= Mathf.Max(leftBottom.x, rightTop.x);
        valid &= transform.position.y >= Mathf.Min(leftBottom.y, rightTop.y);
        valid &= transform.position.y <= Mathf.Max(leftBottom.y, rightTop.y);
        valid &= transform.position.z >= Mathf.Min(leftBottom.z, rightTop.z);
        valid &= transform.position.z <= Mathf.Max(leftBottom.z, rightTop.z);

        return valid;
    }

    void LocomotionTick()
    {

    }
}
