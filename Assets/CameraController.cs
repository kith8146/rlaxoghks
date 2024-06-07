using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 deltaPosition;
    public Vector3 deltaRotation;
    public GameObject PlayerObject;

    void Awake()
    {
        deltaPosition = new Vector3(0, 7, -10);
    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerObject.transform.position + deltaPosition;
        
    }
}
