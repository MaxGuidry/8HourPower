using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeSketti : MonoBehaviour {
    public UnityEngine.UI.Text question;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            question.text = "WRONG.";
            gameObject.AddComponent<Restart>();
        }
    }
}
