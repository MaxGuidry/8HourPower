using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cat : MonoBehaviour
{
    public GameObject laser1, laser2;
    public UnityEngine.UI.Text over;
    public UnityEngine.UI.Text winLose;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            if (other.GetComponent<PlayerController>().skettiCount == 4)
            {
                winLose.text = "Thank you my child for bringing me all of the sketti.\nI will now take on my true form....";
                gameObject.AddComponent<AssumeTrueForm>();
                over.text = "You win!.. the game will now restart.";
                gameObject.AddComponent<Restart>().timer = 3;
            }
            else
            {
                winLose.text = "WHAT... you didnt bring me all the sketti...... DIE!!!!!";
                laser1.SetActive(true);
                laser2.SetActive(true);
                gameObject.AddComponent<Restart>().timer = 1;
            }

    }

}
