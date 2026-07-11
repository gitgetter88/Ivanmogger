using UnityEngine;
using TMPro;
public class scoreboard : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public int score;
    public GameObject gj;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        
        score = 0;
        myText.text = "Score: " +score;
        gj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 25){
            gj.SetActive(true);
        }
        
    }
    void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.CompareTag("coin")){
           score = score +1;
            myText.text = "Score: " +score;

            if (score % 10 == 0){
            Time.timeScale = Time.timeScale + 0.05f;
        }
        }
    }

}
