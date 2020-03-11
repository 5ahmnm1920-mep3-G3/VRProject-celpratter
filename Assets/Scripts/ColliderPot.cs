using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPot : MonoBehaviour
{
    [SerializeField]
    GameObject Topf;

    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Healthy")
        {
            Debug.Log("healthy");
            Destroy(theCollision.gameObject);
            var TopfRenderer = Topf.GetComponent<Renderer>();
            TopfRenderer.material.SetColor("_Color", Color.green);
        }
        else
        {
            Debug.Log("unhealthy");
            Destroy(theCollision.gameObject);
            var TopfRenderer = Topf.GetComponent<Renderer>();
            TopfRenderer.material.SetColor("_Color", Color.red);
        }
    }

    void Update()
    {

    }
}
