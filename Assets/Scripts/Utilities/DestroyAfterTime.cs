using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {

    public float time;
    private float timeElapsed;
	void Start () {
        timeElapsed = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= time)
            GameObject.Destroy(this.gameObject);

	}
}
