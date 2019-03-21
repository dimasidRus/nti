using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFallen : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Movable")
            Destroy(other.gameObject);
    }
}
