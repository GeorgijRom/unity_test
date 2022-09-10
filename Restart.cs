using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    public Text score;
    private ScoreManager sm;

    void Start()
    {
        sm = GameObject.Find("ScoreManager").GetComponentInChildren<ScoreManager>();
        score.text = "Kills: " + sm.score;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
