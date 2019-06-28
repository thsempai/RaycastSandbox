using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWithRange : MonoBehaviour
{
    public float viewRange = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Color color = Color.green;

        if (Physics.Raycast(transform.position, transform.forward, viewRange)){
            Debug.Log("There something...");
            color = Color.red;
        }
        Debug.DrawRay(transform.position, transform.forward * viewRange, color);
    }
}
