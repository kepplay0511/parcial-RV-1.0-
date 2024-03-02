using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private int Score; 
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0; 
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "barraEnergetica")
        {
            Score++;
                ScoreText.text = "Score : " + Score;
        }
    }

}


