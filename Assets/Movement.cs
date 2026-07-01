using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movespeed = 5f;

    public Vector2 Direction;
    public Vector3 trans;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) Direction = Vector2.up;
        if (Input.GetKeyDown(KeyCode.A)) Direction = Vector2.left;
        if (Input.GetKeyDown(KeyCode.S)) Direction = Vector2.down;
        if (Input.GetKeyDown(KeyCode.D)) Direction = Vector2.right;

        if (Time.timeScale != 0)
        {
            transform.Translate(Direction * movespeed * Time.deltaTime);
        }

        trans = transform.position;
    }
}