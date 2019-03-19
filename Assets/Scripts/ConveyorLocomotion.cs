using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorLocomotion : MonoBehaviour {

    public float locomotionWidth = 0.1f;
    public float locomotionHeight = 0.1f;
    public float locomotionSpeed = 0.1f;

    GameObject[] conveyors;
    GameObject[] movables;

	void Start () {
        GetConveyors();
        GetMovables();
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
    bool ConveyorValid(GameObject conveyor, GameObject movable)
    {
        bool isValid = true;

        Transform conTransform = conveyor.transform;
        Vector3 conPos = conTransform.position;

        Vector3 leftBottom;
        Vector3 rightTop;

        leftBottom = conPos
                    - conTransform.right * locomotionWidth
                    - conTransform.up * locomotionHeight;

        rightTop = conPos + conTransform.forward 
                   + conTransform.right * locomotionWidth 
                   + conTransform.up * locomotionHeight;

        isValid &= movable.transform.position.x >= Mathf.Min(leftBottom.x, rightTop.x);
        isValid &= movable.transform.position.x <= Mathf.Max(leftBottom.x, rightTop.x);
        isValid &= movable.transform.position.y >= Mathf.Min(leftBottom.y, rightTop.y);
        isValid &= movable.transform.position.y <= Mathf.Max(leftBottom.y, rightTop.y) + 0.6f;
        isValid &= movable.transform.position.z >= Mathf.Min(leftBottom.z, rightTop.z);
        isValid &= movable.transform.position.z <= Mathf.Max(leftBottom.z, rightTop.z);

        if (isValid) { Debug.Log("ConveyorValid"); }
        return isValid;
    }

    void LocomotionTick()
    {
        foreach (GameObject movable in movables)
        {
            foreach (GameObject conveyor in conveyors)
            {
                if (ConveyorValid(conveyor, movable))
                {
                    movable.transform.position += conveyor.transform.forward * locomotionSpeed * Time.deltaTime;
                    break;
                }
            }
        }
    }
}
