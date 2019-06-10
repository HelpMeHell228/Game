
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Player;

    public Vector3 offset;


    void Start()
    {
       // offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3 (Player.transform.position.x, 0, 0) + offset;
    }
}