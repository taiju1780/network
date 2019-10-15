using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private CharacterController charaCon;
    private Vector3 moveheight;
    private Vector3 moveDir;
   
    private void Start()
    {
        charaCon = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (charaCon.isGrounded)
        {
            if (Input.GetKey("x"))
            {
                moveheight.y = 20;
            }
        }

        //重力
        moveDir.y -= 10 * Time.deltaTime;

        if (Input.GetKey("w"))
        {
            moveDir.z = 5;
            charaCon.Move(moveDir);
        }
        if (Input.GetKey("s"))
        {
            moveDir.z = -5;
            charaCon.Move(moveDir);
        }
        if (Input.GetKey("d"))
        {
            moveDir.x = 5;
            charaCon.Move(moveDir);
        }
        if (Input.GetKey("a"))
        {
            moveDir.x = -5;
            charaCon.Move(moveDir);
        }
        charaCon.Move(moveheight * Time.deltaTime);
    }
}
