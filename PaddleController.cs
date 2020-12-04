using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 50f * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();

        if (player != null)
        {
            float rotationZ = transform.rotation.eulerAngles.z;
            float force = 700f;
            Debug.Log(rotationZ);
            if (rotationZ >= 0 && rotationZ < 90)
            {
                player.PushBack(force, "left");
            }

            else if (rotationZ >= 90 && rotationZ <= 180)
            {
                player.PushBack(force, "down");
            }

            else if (rotationZ > 180 && rotationZ < 270)
            {
                player.PushBack(force, "right");
            }

            else 
            {
                player.PushBack(force, "up");
            }
        }
    }
}
