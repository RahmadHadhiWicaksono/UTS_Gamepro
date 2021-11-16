using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score1,score2;
    public Text ScoreText1,ScoreText2;
    public GameObject Goal1,Goal2;
    // Start is called before the first frame update
    void Start()
    {
        score1 = 0;
        score2 = 0;
        ScoreText1.text = ""+score1;
        ScoreText2.text = ""+score2;
    } 

    // Update is called once per frame
    void Update()
    {
         
    }

    private void OnTriggerEnter2D(Collider2D goal1){
        if(goal1.tag == "gawang1"){
            score1++;
            ScoreText1.text = ""+score1;
        }
        else if (goal1.tag == "gawang2"){
            score2++;
            ScoreText2.text = ""+score2;
        }
    }

}
