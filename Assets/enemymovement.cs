using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public Movement movement;
    public Vector3 pos;
    public Vector3 Direction;
    public Vector3 move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Direction = movement.trans - pos;
        move = new Vector3(Mathf.Sign(Direction.x), Mathf.Sign(Direction.y),0);
      
        pos = transform.position;
        transform.Translate(move) ;
    }
}
