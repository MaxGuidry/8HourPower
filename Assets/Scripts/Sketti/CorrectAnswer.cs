using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{

    public UnityEngine.UI.Text question;
    public GameObject bridge;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            question.text = "Correct!  Cats love to eat dogs.";
            bridge.SetActive(true);
            other.gameObject.GetComponent<PlayerController>().skettiCount++;

        }
    }
}
