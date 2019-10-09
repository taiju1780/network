using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControll : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    public Transform verRot;
    public Transform horRot;
    // Start is called before the first frame update
    void Start()
    {verRot = transform.parent;
        horRot = GetComponent<Transform>();
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset; 

        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");

        if(horRot.transform.rotation.eulerAngles.y > 75)
        {
            Y_Rotation = 75;
        } 
        if(horRot.transform.rotation.eulerAngles.y < -75)
        {
            Y_Rotation = -75;
        }
        verRot.transform.Rotate(0, -X_Rotation * 2, 0);
        horRot.transform.Rotate(-Y_Rotation * 2, 0, 0);
    }
}
