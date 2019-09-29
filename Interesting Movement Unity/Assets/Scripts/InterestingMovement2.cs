using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterestingMovement2 : MonoBehaviour
{
    [SerializeField]
    float acceleration;

    [SerializeField]
    float maxSpeed;

    [SerializeField]
    Transform player;

    float speed;
    float left;
    float right;
    float up;
    float down;
    bool mTrueIFalse;

    private void Start()
    {
        speed = 0;
        left = 0;
        right = 0;
        up = 0;
        down = 0;
        mTrueIFalse = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("m"))
        {
            mTrueIFalse = true;
        }
        else if (Input.GetButtonDown("i"))
        {
            mTrueIFalse = false;
        }

        if (mTrueIFalse == true)
        {
            Momentum();
        }
        else if (mTrueIFalse == false)
        {
            Influenced();
        }
    }

    void Momentum()
    {
        if (Input.GetButton("w"))
        {
            if (speed + acceleration < maxSpeed)
            {
                speed = speed + acceleration;
            }

            player.position = new Vector3(player.position.x, player.position.y + speed, player.position.z);
        }
        else if (Input.GetButton("a"))
        {
            if (speed + acceleration < maxSpeed)
            {
                speed = speed + acceleration;
            }

            player.position = new Vector3(player.position.x + -speed, player.position.y, player.position.z);
        }
        else if (Input.GetButton("s"))
        {
            if (speed + acceleration < maxSpeed)
            {
                speed = speed + acceleration;
            }

            player.position = new Vector3(player.position.x, player.position.y + -speed, player.position.z);
        }
        else if (Input.GetButton("d"))
        {
            if (speed + acceleration < maxSpeed)
            {
                speed = speed + acceleration;
            }

            player.position = new Vector3(player.position.x + speed, player.position.y, player.position.z);
        }
        else
        {
            speed = 0;
        }
    }

    void Influenced()
    {
        if (Input.GetButton("w"))
        {
            if (speed + acceleration < maxSpeed)
            {
                speed = speed + acceleration;
            }

            if (speed + acceleration < maxSpeed)
            {
                up += speed;
            }
        }
        else if (Input.GetButton("a"))
        {
            if (speed + acceleration < maxSpeed)
            {
                speed = speed + acceleration;
            }

            if (left + acceleration < maxSpeed)
            {
                left += speed;
            }
        }
        else if (Input.GetButton("s"))
        {
            if (speed + acceleration < maxSpeed)
            {
                speed = speed + acceleration;
            }

            if (down + acceleration < maxSpeed)
            {
                down += speed;
            }
        }
        else if (Input.GetButton("d"))
        {
            if (speed + acceleration < maxSpeed)
            {
                speed = speed + acceleration;
            }

            if (right + acceleration < maxSpeed)
            {
                right += speed;
            }
        }
        else
        {
            up -= acceleration;
            down -= acceleration;
            left -= acceleration;
            right -= acceleration;
        }

        speed = 0; ;

        player.position = new Vector3(player.position.x + right - left, player.position.y + up - down, player.position.z);
    }
}
