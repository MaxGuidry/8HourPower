using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    private GameObject camera;
    [HideInInspector]
    public int skettiCount;
    public Text skettiCountText;
    private int prevSkettiCount;
    [HideInInspector]
    public int stage;
    private float jumpTimer;
    // Use this for initialization
    void Start()
    {
        jumpTimer = 1;
        skettiCount = 0;
        stage = 0;
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += (.1f * new Vector3(camera.transform.forward.x, 0, camera.transform.forward.z));
        }
        if (Input.GetKey(KeyCode.S))

            this.transform.position -= (.1f * new Vector3(camera.transform.forward.x, 0, camera.transform.forward.z));
        if (Input.GetKey(KeyCode.A))
            this.transform.position -= (.1f * new Vector3(camera.transform.right.x, 0, camera.transform.right.z));
        if (Input.GetKey(KeyCode.D))
            this.transform.position += (.1f * new Vector3(camera.transform.right.x, 0, camera.transform.right.z));
        if (Input.GetKeyDown(KeyCode.Space) && jumpTimer < .5f)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 300, 0));
            jumpTimer = 1f;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        jumpTimer -= Time.deltaTime;
    }
    void LateUpdate()
    {

        if (skettiCount != prevSkettiCount)
            skettiCountText.text = "Sketti Count: " + skettiCount;
        prevSkettiCount = skettiCount;
    }
}
