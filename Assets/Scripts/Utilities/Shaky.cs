using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaky : MonoBehaviour
{


    private bool pos;
    private float timer;
    // Update is called once per frame
    void Start()
    {
        timer = 0;
    }
    void Update()
    {


        if (pos)
        {
            this.transform.position += new Vector3(.02f, 0, .02f);
            pos = false;
        }
        else
        {
            this.transform.position += new Vector3(-.02f,0,-.02f);
            pos = true;
        }
        timer += Time.deltaTime;
        if (timer > 2)
            this.transform.position += new Vector3(0, -.1f, 0);
    }
}
