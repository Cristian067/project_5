using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToEndless : MonoBehaviour
{

    //[SerializeField] private GameObject main;
    [SerializeField] private GameObject optionsW;

    public Button options;

    [SerializeField] private Button select;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = options.GetComponent<Button>();
        //Transform mainTransform = main.GetComponent<RectTransform>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("SampleScene");




    }



}
