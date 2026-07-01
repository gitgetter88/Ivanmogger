using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movespeed;
    
    public Vector2 Direction;
    public Vector3  trans;
    float moveTimer = 0f;
    public float moveInterval = 0.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) Direction = Vector2.up;
        if (Input.GetKeyDown(KeyCode.A)) Direction = Vector2.left;
        if (Input.GetKeyDown(KeyCode.S))  Direction = Vector2.down;
        if (Input.GetKeyDown(KeyCode.D))  Direction = Vector2.right;

       moveTimer += Time.deltaTime;
       
        if (moveTimer >= moveInterval)
        {
            
            
            transform.Translate(Direction * movespeed);
            moveTimer = 0f;

        }
         trans = transform.position;
    }
   
}

