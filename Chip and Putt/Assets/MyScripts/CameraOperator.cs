using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOperator : MonoBehaviour
{

    public float moveSpeed;
    public float rotateSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    public void MoveCamera()
    {
        float horiz = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float vert = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float rotate = Input.GetAxis("Rotate") * Time.deltaTime * rotateSpeed;

        transform.Translate(horiz,0,vert);
        transform.Rotate(0, rotate, 0, 0);
    }

}
