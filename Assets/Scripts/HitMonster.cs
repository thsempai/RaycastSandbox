using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitMonster : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {



        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit)) {
            Color color = Color.blue;
            if (hit.transform.tag == "Monstre") {
                Debug.Log("It's a Monster");
                color = new Color(1f, 0.5f, 0.5f);
            }

            Debug.DrawRay(transform.position, transform.forward * 100, color);
        }

    }
}
