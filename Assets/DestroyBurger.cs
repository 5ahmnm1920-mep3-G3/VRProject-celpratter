using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBurger : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {

    // }

    void OnTriggerEnter(Collider theCollision) // C#, type first, name in second
    {
        if (theCollision.gameObject.tag == "PotTrigger")
        // By using {}, the condition apply to that entire scope, instead of the next line.
        {
            Debug.Log("trigger");
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
