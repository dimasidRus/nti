using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollider : MonoBehaviour {
    public bool isFree;
    private bool hasObject;

    private void FixedUpdate()
    {
        isFree = !hasObject;
    }

    private void OnTriggerStay (Collider other)
    {
        if (other.gameObject.tag == "Movable")
        {
            hasObject = true;
            Transform otherTransform = other.gameObject.transform;
            otherTransform.position += transform.forward * Master.spawnMoveSpeed * Time.deltaTime;
            Debug.Log(other.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Movable")
            hasObject = false;
    }
}
