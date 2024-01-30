using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToPlayMenu : MonoBehaviour
{

    [SerializeField] private GameObject main;
    [SerializeField] private GameObject optionsW;

    [SerializeField] private Button select;


    // Start is called before the first frame update
    void Start()
    {
        //Button btn = options.GetComponent<Button>();
        //Transform mainTransform = main.GetComponent<RectTransform>();
        //btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToPlaymenu()
    {

        //SceneManager.LoadScene(0);

        main.SetActive(false);

        optionsW.SetActive(true);

        
        
        select.Select();




    }



}
