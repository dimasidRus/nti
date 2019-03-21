using UnityEngine;

public class RegisterResourse : MonoBehaviour {
    
    private void OnTriggerEnter(Collider other)
    {
        if (transform.parent.tag == "Warehouse" && other.gameObject.tag == "Movable")
            GetComponentInParent<Warehouse>().RegisterTrigger(other);
        else if (transform.parent.tag == "Converter" && other.gameObject.tag == "Movable")
            GetComponentInParent<Converter>().RegisterTrigger(other);

    }
}
