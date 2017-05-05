using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject toFollow;
    private Vector3 prevMouse;
    private Vector3 currentMouse;

    void Start () {
        currentMouse = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
        Quaternion originRot = this.transform.rotation;
        this.transform.rotation = new Quaternion(0, 0, 0, 1);
        prevMouse = currentMouse;
        currentMouse = Input.mousePosition;
        Vector3 dif = currentMouse - prevMouse;
        Quaternion combineRot = new Quaternion(0, Mathf.Sin(((dif.x / 150f) + ((originRot.eulerAngles.y * Mathf.PI) / 180f)) / 2), 0, Mathf.Cos(((dif.x / 150f) + ((originRot.eulerAngles.y * Mathf.PI) / 180f)) / 2))
            * new Quaternion(Mathf.Sin((-(dif.y / 150f) + ((originRot.eulerAngles.x * Mathf.PI) / 180f)) / 2),0,0, Mathf.Cos((-(dif.y / 150f) + ((originRot.eulerAngles.x * Mathf.PI) / 180f)) / 2));
        this.transform.rotation = this.transform.rotation * combineRot;
        
        this.transform.position = new Vector3(toFollow.transform.position.x,toFollow.transform.position.y ,toFollow.transform.position.z);
        
    }
}
