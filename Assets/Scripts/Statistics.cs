using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Statistics : MonoBehaviour
{
    public static int scoreInt;
    public static float timer;

    public GameObject gameOverPanel;
    public TMP_Text score, time;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        score.text = "Score: " + scoreInt;
        time.text = "Time: " + timer;

        gameOverPanel.SetActive(timer > TargetShooter.desiredTime);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        Statistics.timer = 0f;
        string sceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene(sceneName);
    }
}
