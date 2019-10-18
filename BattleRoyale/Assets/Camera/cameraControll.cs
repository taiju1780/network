using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControll : MonoBehaviour
{
    public GameObject player;

    //カメラとプレイヤーとの差分
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
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        transform.position = player.transform.position + offset; 

        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");

        verRot.transform.Rotate(0, -X_Rotation, 0);
        horRot.transform.Rotate(-Y_Rotation, 0, 0);
    }
}
