using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] targets;


    private float startX = -3.75f;
    private float startY = -3.75f;
    private float disctanceBetween = 2.5f;

    private bool isGameOver;
    private float spawnRate = 1f;

    private int lives = 3;

    private Vector3 randomPos;
    public List<Vector3> targetPositionsInScene;

    private int points;

    private UiManager uiManager;

    private int time;
    private int maxTime = 60;

    private int highScore;

    private bool isPause;





    private void Awake()
    {
        targetPositionsInScene = new List<Vector3>();
        
    }

    void Start()
    {

        //Time.timeScale = 0;
        

        highScore = PlayerPrefs.GetInt("highScore");
        Debug.Log(highScore);
        uiManager = FindObjectOfType<UiManager>();
        uiManager.HidePausePanel();
        uiManager.UpdatePoints(0, highScore);
        
        uiManager.UpdateTime(maxTime);
        uiManager.HideGOPanel();
        //uiManager.HideMenuPanel();

        

    }

    public void StartGame(int difficulty)
    {
        uiManager.HideMenuPanel();


        points = 0; time = maxTime / difficulty;
        spawnRate /= difficulty;
        StartCoroutine(SpawnRandomTarget());
        StartCoroutine(Timer());
    }


    private Vector3 RandomPos()
    {
        float spawnPosX = startX + (disctanceBetween * Random.Range(0, 4));
        float spawnPosY = startY + (disctanceBetween * Random.Range(0, 4));

        return new Vector3(spawnPosX, spawnPosY, 0);

    }

    private IEnumerator SpawnRandomTarget()
    {

        while (!isGameOver)
        {
            yield return new WaitForSeconds(spawnRate);

            if(isGameOver )
            {
                break;
            }

            int random = Random.Range(0, targets.Length);

            randomPos = RandomPos();

            while (targetPositionsInScene.Contains(randomPos))
            {
                randomPos = RandomPos();
            }


            Instantiate(targets[random], randomPos, targets[random].transform.rotation);

            targetPositionsInScene.Add(randomPos);

            

            


        }

       
    }

    private IEnumerator Timer()
    {
        while (!isGameOver)
        {
            yield return new WaitForSeconds(1);

            UpdateTime();
            if (isGameOver )
            {
                break;
            }

            
            

        }
        
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if(!isPause)
            {
                //Time.timeScale = 0;
                isPause = true;
                uiManager.ShowPausePanel();

            }
            else if (isPause)
            {
                //Time.timeScale = 1;
                isPause = false;
                uiManager.HidePausePanel();
            }
            
        }
        
        
    }

    private void Spawn()
    {
        //Debug.Log("a");
        int random = Random.Range(0, targets.Length);

        Instantiate(targets[random], RandomPos(), Quaternion.identity);

    }

    private void UpdateTime()
    {
        time--;
        uiManager.UpdateTime(time);
        if (time <= 0 || lives <= 0)
        {


            if (points > highScore)
            {
                PlayerPrefs.SetInt("highScore", points);
                uiManager.UpdatePoints(points, highScore);
            }

            isGameOver = true;
            uiManager.ShowGOPanel();
        }
    }
    public void UpdatePoints(int newPoint)
    {

        points += newPoint;
        uiManager.UpdatePoints(points, highScore);
        


    }

    public bool IsGameOver()
    {
        return isGameOver;
    }

    public bool IsPause()
    {
        return isPause;
    }

    public void LoseLife()
    {
        lives--;
        if (lives <= 0)
        {
            isGameOver = true;
        }
    }



    public void Restart()
    {
        SceneManager.LoadScene("Challenge 5");
    }

    public void NotPause()
    {
        isPause = false;
    }




}
