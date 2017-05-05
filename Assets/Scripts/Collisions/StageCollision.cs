using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCollision : MonoBehaviour
{
    private GameObject question;
    void Awake()
    {
        question = GameObject.FindGameObjectWithTag("Question");
       
    }
    void Start()
    {
        question.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            string stageTag = this.transform.root.gameObject.tag;
            stageTag = stageTag.ToLower();
            int i = (int)stageTag[6];
            PlayerController p = other.GetComponent<PlayerController>();
            p.stage = i - 49;
            if (p.stage == 1)
                question.gameObject.SetActive(true);
            else
                question.gameObject.SetActive(false);
        }
    }
}
