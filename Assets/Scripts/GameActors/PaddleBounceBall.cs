using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBounceBall : MonoBehaviour
{
    [SerializeField]
    BrickManager brickMan;

    private void OnCollisionEnter(Collision collision)
    {
        BallMovement ball = collision.collider.GetComponent<BallMovement>();

        if (ball)
        {
            ball.PaddleBounce(ball.transform.position.x - transform.position.x);
            brickMan.checkReset();
        }
    }

}
