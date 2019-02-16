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

        rbody.AddForce(Vector3.forward * (power * 10) * Time.deltaTime, ForceMode.Impulse);
        rbody.AddForce(Vector3.right * direction * Time.deltaTime, ForceMode.Impulse);
        rbody.AddForce(Vector3.forward * (power * 20) * Time.deltaTime, ForceMode.Acceleration);
    }

}
