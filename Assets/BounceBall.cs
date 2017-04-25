using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBall: MonoBehaviour {

    [SerializeField]
    bool isHorizontal;
    [SerializeField]
    int direction;

    [SerializeField]
    GameObject destroyOnCollide;

    private void OnCollisionEnter(Collision collision)
    {
        bounce(collision.collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        bounce(other);
    }

    private void bounce(Collider other)
    {
        BallMovement ball = other.GetComponent<BallMovement>();

        if (ball)
        {
            ball.Bounce(isHorizontal, direction);
        }

        if (destroyOnCollide)
        {
            destroyOnCollide.SetActive(false);
        }
    }
}
