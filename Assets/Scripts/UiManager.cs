using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class UiManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI pointsText;
    [SerializeField] private TextMeshProUGUI timeText;

    [SerializeField] private TextMeshProUGUI highscoreText;
    [SerializeField] private TextMeshProUGUI deathscoreText;

    [SerializeField] private RectTransform livesPanel;
    
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject pausePanel;
    

    private int points;

    private GameManager gameManager;

    [SerializeField] private Button eButton;
    [SerializeField] private Button mButton;
    [SerializeField] private Button hButton;
    [SerializeField] private Button pauseButton;

    //[SerializeField] private Button resumeButton;
    [SerializeField] private Button restartPausedButton;


    // Start is called before the first frame update
    void Start()
    {

        gameManager = FindObjectOfType<GameManager>();
        //panel.SetActive(false);

        eButton.onClick.AddListener(() => gameManager.StartGame(1));
        mButton.onClick.AddListener(() => gameManager.StartGame(2));
        hButton.onClick.AddListener(() => gameManager.StartGame(3));

        pauseButton.onClick.AddListener(() => HidePausePanel());
        pauseButton.onClick.AddListener(() => gameManager.NotPause() );
        restartPausedButton.onClick.AddListener(() => gameManager.Restart());

        LivesWidth();

        

        
        
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

    public void LivesWidth()
    {
        livesPanel.sizeDelta = new Vector2(livesPanel.sizeDelta.x/3, livesPanel.sizeDelta.y);

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

    public void ShowPausePanel()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        pauseButton.Select();

    }

    public void HidePausePanel()
    {
        Time.timeScale = 1;
        
        pausePanel.SetActive(false);

    }


}
