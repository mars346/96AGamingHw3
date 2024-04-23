using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed = 5f;

    private Vector2 direction = Vector2.zero;
    
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        body.velocity = new Vector2(direction.x, direction.y);
    }
    
    private void Move(float x, float z)
    {
        body.velocity = new Vector3(x * speed, body.velocity.y, z * speed);
    }

}
