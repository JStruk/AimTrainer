using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Statistics : MonoBehaviour
{
    public static int score;
    public static float timer;

    public GameObject gameOverPanel;
    public TMP_Text scoreText, timeText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        scoreText.text = "Score: " + score;
        timeText.text = "Time: " + timer;

        gameOverPanel.SetActive(timer > TargetShooter.desiredTime);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        timer = 0f;
        score = 0;
        string sceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene(sceneName);
    }
}
