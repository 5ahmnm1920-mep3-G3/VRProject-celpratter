using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPot : MonoBehaviour
{
    [SerializeField]
    GameObject Topf;
    public Transform clipboard;
    public Transform clipPos;


    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Healthy")
        {
            Debug.Log("healthy");
            var TopfRenderer = Topf.GetComponent<Renderer>();
            TopfRenderer.material.SetColor("_Color", Color.green);
            StartCoroutine(ResetColor());
        }
        else if (theCollision.gameObject.tag == "Clipboard")
        {
            Debug.Log("clipboard");
            clipboard.position = clipPos.position;
        }
        else
        {
            Debug.Log("unhealthy");
            Destroy(theCollision.gameObject);
            var TopfRenderer = Topf.GetComponent<Renderer>();
            TopfRenderer.material.SetColor("_Color", Color.red);
            StartCoroutine(ResetColor());
        }
    }

    public IEnumerator ResetColor()
    {
        yield return new WaitForSeconds(0.5f);
        var TopfRenderer = Topf.GetComponent<Renderer>();
        TopfRenderer.material.SetColor("_Color", Color.white);
    }

    void Update()
    {

    }
}
