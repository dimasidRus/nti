using UnityEngine;

public class RegisterResourse : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Movable")
            GetComponentInParent<Converter>().RegisterTrigger(other);
    }
}
