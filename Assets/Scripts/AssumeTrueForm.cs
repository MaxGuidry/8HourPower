using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssumeTrueForm : MonoBehaviour
{
    public GameObject trueForm;
    private float timer;
    void Start()
    {
        timer = 0;
        trueForm = Resources.Load("True Form") as GameObject;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            GameObject.Instantiate(trueForm);
            trueForm.SetActive(true);
            gameObject.AddComponent<DestroyAfterTime>().time = 0;
            Destroy(gameObject);
        }
    }

}
