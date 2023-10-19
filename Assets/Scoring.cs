using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{

    public static Scoring Instance;
    public TMP_Text scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        ShowScore();
        Instance = this;
    }

    public  void AddScore(int addedScore){
        score += addedScore;
        ShowScore();
    }

    private void ShowScore() => scoreText.text = score.ToString();
}
