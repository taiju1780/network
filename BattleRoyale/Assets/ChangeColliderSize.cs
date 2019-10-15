using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColliderSize : MonoBehaviour
{
    CapsuleCollider area;
    float rad;
    public float timeOut;
    private float timeElapsed;

    bool timeflag;

    // Start is called before the first frame update
    void Start()
    {
        area = GetComponent<CapsuleCollider>();
        timeflag = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeflag == true)
        {
            area.radius -= 0.01f;

        }
        if (timeElapsed >= timeOut)
        {
            timeElapsed = 0.0f;
            timeflag = !timeflag;
        }
    }
}

