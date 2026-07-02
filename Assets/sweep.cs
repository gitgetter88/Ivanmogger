/*using UnityEngine;

public class sweep : MonoBehaviour
{
    public scoreboard Scoreboard;
    public int Switch;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
    if (Scoreboard.score >= 50)
    {
        if (Switch <= 800)
        {
            transform.Translate(new Vector3(1, -1, 0) * Time.deltaTime);
            Switch += 1;
        }
        else if (Switch > 800 && Switch <= 1600)
        {
            transform.Translate(new Vector3(-1, 1, 0) * Time.deltaTime);
            Switch += 1;
        }
        else
        {
            Switch = 0;
        }
    }
}
}*/ 
using UnityEngine;

public class DVDBounce : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 direction = new Vector2(1, 1);

    private Rigidbody2D rb;

    

    void Awake(){
        transform.position = new Vector3(Random.Range(-7,7),Random.Range(-4,4),0);
    }


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = direction.normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 normal = collision.contacts[0].normal;
        direction = Vector2.Reflect(direction, normal);
    }
}
