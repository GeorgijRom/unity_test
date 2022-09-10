using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Text coins;
    void Update()
    {
        scoreText.text = score + "";
        scoreText.text = score / 2 + "";
    }
    public void kill()
    {
        score++;
    }
}
