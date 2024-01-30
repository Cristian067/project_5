using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GoToOptions : MonoBehaviour
{

    [SerializeField] private GameObject main;
    [SerializeField] private GameObject optionsW;

    public Button options;

    [SerializeField] private Button select;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = options.GetComponent<Button>();
        Transform mainTransform = main.GetComponent<RectTransform>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        //Debug.Log("You have clicked the button!");

        main.SetActive(false);

        optionsW.SetActive(true);

        
        
        select.Select();




    }



}
