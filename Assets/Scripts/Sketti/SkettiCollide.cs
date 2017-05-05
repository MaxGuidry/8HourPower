using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkettiCollide : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerController>().skettiCount++;
            this.gameObject.AddComponent<DestroyAfterTime>().time = 0;
        }
    }
}
