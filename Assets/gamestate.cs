using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gamestate : MonoBehaviour
{
    public GameObject endcanvas;
    public Button restart;
    public Button menu;
   
   
   
    void Awake(){
        endcanvas.SetActive(false);
    }
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endcanvas.SetActive(false);
        restart.onClick.AddListener(restartclicked);
        menu.onClick.AddListener(menuclicked);

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0f){
            endcanvas.SetActive(true);
        }
    }
    
    void restartclicked (){
        Debug.Log("restart is clicked");
        Time.timeScale = 1;
        endcanvas.SetActive(false);
        SceneManager.LoadScene("Play");

    }
    void menuclicked (){
        Debug.Log("menu was pressed");
        Time.timeScale = 1;
        endcanvas.SetActive(false);
        SceneManager.LoadScene("Menu");


    }
}
