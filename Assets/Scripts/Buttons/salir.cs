using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class salir : MonoBehaviour
{

    //public Button boton;

    // Start is called before the first frame update
    void Start()
    {
        

        //Button btn = boton.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Exit()
    {
        //Debug.Log("You have clicked the button!");

        Debug.Log("a");
        Application.Quit();




    }




}
