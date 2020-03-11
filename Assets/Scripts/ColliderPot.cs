using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPot : MonoBehaviour
{
    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Healthy")
        {
            Debug.Log("healthy");
            Destroy(theCollision.gameObject);
        }
        else
        {
            Debug.Log("unhealthy");
            Destroy(theCollision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
