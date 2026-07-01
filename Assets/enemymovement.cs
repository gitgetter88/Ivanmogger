using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public Movement movement;
    public Vector3 pos;
    public Vector3 Direction;
    public Vector3 move;

    public float speed = 5f;

    void Update()
    {
        pos = transform.position;

        Direction = movement.trans - pos;
        move = new Vector3(Direction.x, Direction.y, 0);

        transform.Translate(move.normalized * speed * Time.deltaTime);
    }
}