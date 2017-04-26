using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    float speed = 3f;
    Vector2 movement;

    Rigidbody rb;

    [SerializeField]
    LivesCounter lives;

    float horizSpeedMultiplier = 1f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movement = new Vector2(speed, speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2f)
        {

            lives.LoseLife();
            if (lives.lives >= 0)
            {
                transform.position = new Vector3(0f, 1f, 0f);
                speed = 3f;
                horizSpeedMultiplier = 1f;
                movement = new Vector2(speed, speed);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        rb.velocity = movement;
    }


    public void Bounce(bool bounceHorizontal, int direction)
    {
        speed += 0.3f;
        if (bounceHorizontal)
        {
            movement = new Vector2(speed * direction * horizSpeedMultiplier, movement.y);
        }
        else
        {
            movement = new Vector2(movement.x, speed * direction);
        }
    }

    public void PaddleBounce(float newHorizMult)
    {
        horizSpeedMultiplier = newHorizMult;
        movement = new Vector2(speed * horizSpeedMultiplier, speed);
        horizSpeedMultiplier = Mathf.Abs(horizSpeedMultiplier);
    }
}