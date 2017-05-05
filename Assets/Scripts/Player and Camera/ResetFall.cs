using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResetFall : MonoBehaviour
{
    public List<GameObject> stages;
    public void Start()
    {
        deathCounter.gameObject.SetActive(false);
    }
    public Text deathCounter;
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = new Vector3(0, 1.2f, 0);
        PlayerFallCount pfc = other.GetComponent<PlayerFallCount>();
        pfc.numberOfFalls++;
        deathCounter.gameObject.SetActive(true);
        deathCounter.text = "You have fallen: " + pfc.numberOfFalls + " times.";
        var test = GameObject.FindGameObjectWithTag(stages[other.gameObject.GetComponent<PlayerController>().stage].tag);
        Debug.Log(test.name);
        GameObject.Destroy(test);
        GameObject.Instantiate(stages[other.gameObject.GetComponent<PlayerController>().stage]);
    }
}
