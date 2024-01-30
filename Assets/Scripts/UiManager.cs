using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI pointsText;
    [SerializeField] private TextMeshProUGUI timeText;

    [SerializeField] private TextMeshProUGUI highscoreText;
    [SerializeField] private TextMeshProUGUI deathscoreText;

    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject mainMenuPanel;

    private int points;

    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        //panel.SetActive(false);

        
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(gameManager.IsGameOver())
       // {
       //     panel.SetActive(true);
       // }
    }

    public void UpdatePoints(int score, int maxScore)
    {
        pointsText.text = $"Points: {score}";
        deathscoreText.text = $"Score:  {score}";
        highscoreText.text = $"HighScore: {maxScore}";
    }
    public void UpdateTime(int time)
    {
        timeText.text = $"Time:  {time}";
    }

    


    public void ShowGOPanel()
    {
        panel.SetActive(true);

    }

    public void HideGOPanel()
    {
        panel.SetActive(false);
    }
    
    
    public void ShowMenuPanel()
    {
        mainMenuPanel.SetActive(true);

    }

    public void HideMenuPanel()
    {
        mainMenuPanel.SetActive(false);
    }


}
