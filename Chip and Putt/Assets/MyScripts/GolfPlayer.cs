using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfPlayer : MonoBehaviour
{

    Rigidbody rbody;
    GameObject UI;


    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        UI = FindObjectOfType<UIManager>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HitBall(float power, float direction)
    {

        rbody.AddForce(Vector3.forward * power * Time.deltaTime);
        rbody.AddRelativeTorque(Vector3.up * direction * Time.deltaTime);

    }

}
