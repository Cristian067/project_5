using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float time = 2f;

    [SerializeField] private int score = 10;


    private GameManager gameManager;

    [SerializeField] private GameObject particleSys;




    // Start is called before the first frame update
    void Start()
    {

        gameManager = FindObjectOfType<GameManager>();

        //particleSys = GetComponent<ParticleSystem>();

        Destroy(gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //particleSys.Play();
        Instantiate(particleSys, transform.position, Quaternion.identity);
        if (!gameManager.IsGameOver())
        {
            
            gameManager.UpdatePoints(score);

            if (gameObject.tag == "Bad")
            {
                gameManager.LoseLife();
            }


            Destroy(gameObject);
        }
        
    }

    private void OnDestroy()
    {
        gameManager.targetPositionsInScene.Remove(transform.position);
    }






}
