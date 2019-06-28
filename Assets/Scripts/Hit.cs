using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 100, Color.yellow);
        if (Physics.Raycast(transform.position, transform.forward)){
            Debug.Log("There something...");
        }
    }
}
