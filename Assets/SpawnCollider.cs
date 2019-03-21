using UnityEngine;

public class SpawnCollider : MonoBehaviour {
    public bool isFree;
    public int minTicks = 3;

    public int tickCounter;

    private void FixedUpdate()
    {
        tickCounter++;
        if (tickCounter > minTicks)
        {
            isFree = true;
        }
        else
        {
            isFree = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Movable")
        {
            tickCounter = 0;
            Transform otherTransform = other.gameObject.transform;
            otherTransform.position += transform.forward * Master.spawnMoveSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerStay (Collider other)
    {
        if (other.gameObject.tag == "Movable")
        {
            tickCounter = 0;
            Transform otherTransform = other.gameObject.transform;
            otherTransform.position += transform.forward * Master.spawnMoveSpeed * Time.deltaTime;
        }
    }
}
