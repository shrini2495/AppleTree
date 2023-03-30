using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManagement : MonoBehaviour
{
    public static ScoreManagement instance;
   public void Awake() => instance = this;
    public TMP_Text scoreUI;
    // Start is called before the first frame update
    void Start()
    {

        scoreUI = GetComponent<TMP_Text>();
        scoreUI.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ScoreIncrement()
    {
        int score = int.Parse(scoreUI.text);
        score += 10;
        scoreUI.text = score.ToString();
        if(score > HighScore.score)
        {
            HighScore.score = score;
        }
    }
}
