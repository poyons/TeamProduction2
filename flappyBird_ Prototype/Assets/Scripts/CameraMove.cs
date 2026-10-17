using System;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private float CameraSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(CameraSpeed, 0, 0) * Time.deltaTime);
    }
}
