using UnityEngine;

public class coin_collect : MonoBehaviour
{
   public GameObject thisprefab;
    public Vector3 Randpos;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Randpos = new Vector3(Random.Range(-4,4),Random.Range(-4,4), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  void  OnTriggerEnter2D(Collider2D collision){
    if (collision.gameObject.CompareTag("player")){
            Debug.Log("in contact with player");
            Instantiate(thisprefab, Randpos, Quaternion.identity);
            Destroy(gameObject);
            
    }
  }
}
