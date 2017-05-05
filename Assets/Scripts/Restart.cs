using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour {
    public float timer;
    private float elapsed;
    // Use this for initialization
    void Start () {
        elapsed = 0;
	}
    
	// Update is called once per frame
	void Update () {
        elapsed += Time.deltaTime;
        if (elapsed > timer)
            SceneManager.LoadScene("1.catastrophic");

    }
}
