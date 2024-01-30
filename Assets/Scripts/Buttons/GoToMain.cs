using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class GoToMain : MonoBehaviour
{

    [SerializeField] private GameObject main;
    [SerializeField] private GameObject optionsW;

    public Button back;

    [SerializeField] private Button select;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = back.GetComponent<Button>();
        Transform mainTransform = main.GetComponent<RectTransform>();
        btn.onClick.AddListener(TaskOnClick);
        //optionsW = GameObject.Find("OptionsWindow");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        //Debug.Log("You have clicked the button!");

        main.SetActive(true);

        optionsW.SetActive(false);

        select.Select();




    }
}
