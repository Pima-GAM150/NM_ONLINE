using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{

    public Transform[] courses;
    public Transform player;
    public int nextHole;

    void Start()
    {
        //courses = FindObjectsOfType<StartPoint>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnColliderEnter(Collider other)
    {
        if (other.CompareTag("Ball")) 
        {
            Debug.Log("Hole completed");
            nextHole = Random.Range(0, courses.Length - 1);

            player.position = courses[nextHole].position;
            
        
        }
    }


}
