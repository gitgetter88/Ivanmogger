using UnityEngine;
using TMPro;
public class scoreboard : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.CompareTag("coin")){
           score = score +1;
            myText.text = "Score" +score;
        }
    }
}
