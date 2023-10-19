using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Chicken : MonoBehaviour
{

    public int score;
    private void OnMouseDown(){
        Destroy(gameObject);
        Scoring.Instance.AddScore(score);
    }
}
