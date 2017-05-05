using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetToCat : MonoBehaviour {
    public GameObject bridge;
	void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            bridge.SetActive(true);
        }
    }
}
