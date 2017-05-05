using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCubeCollision : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.transform.parent.gameObject.AddComponent<Shaky>();
            this.transform.parent.gameObject.AddComponent<DestroyAfterTime>().time = 4;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Vector3 op = other.transform.position;
            other.transform.position = new Vector3(9999, -5000, 9999);
            other.transform.position = op;
        }
    }
}
