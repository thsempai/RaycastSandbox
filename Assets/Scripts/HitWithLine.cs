using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWithLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 lineBegin = transform.position;
        Vector3 lineEnd = transform.position + transform.forward * 10;
        Color color = Color.blue;
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit)){
            lineEnd = hit.point;
            color = Color.red;
        }

        LineRenderer line = GetComponent<LineRenderer>();
        line.positionCount = 2;

        /*Vector3[] positions = new Vector3[] { lineBegin, lineEnd };
        line.SetPositions(positions);*/
        line.SetPosition(0, lineBegin);
        line.SetPosition(1, lineEnd);
        line.endColor = color;
    }
}
