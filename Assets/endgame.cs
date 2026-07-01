using UnityEngine;

public class endgame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collider){
        if (collider.gameObject.CompareTag("enemy")){
            Debug.Log("contact enemy");
            Time.timeScale = 0f;
        }
    }
     void OnTriggerEnter2D(Collider2D collider){
        if (collider.gameObject.CompareTag("enemy")){
            Debug.Log("contact enemy");
            Time.timeScale = 0f;
        }
    }
}
