using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPot : MonoBehaviour
{
    [SerializeField]
    GameObject Topf;

    [SerializeField]
    GameObject Soup;

    public Transform clipboard;
    public Transform clipPos;
    public float score = 0;


    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;

    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Mushroom")
        {
            Destroy(theCollision.gameObject);
            var TopfRenderer = Topf.GetComponent<Renderer>();
            TopfRenderer.material.SetColor("_Color", Color.green);
            StartCoroutine(ResetColorTopf());
            Soup.GetComponent<Renderer>().material.color = new Color(0.858f, 0.7248f, 0.3847f);
            score++;
            Debug.Log("score= " + score);
        }
        else if (theCollision.gameObject.tag == "Carrot")
        {
            Destroy(theCollision.gameObject);
            var TopfRenderer = Topf.GetComponent<Renderer>();
            TopfRenderer.material.SetColor("_Color", Color.green);
            StartCoroutine(ResetColorTopf());
            Soup.GetComponent<Renderer>().material.color = new Color(1f, 0.639f, 0.1462f);
            score++;
            Debug.Log("score= " + score);
        }
        else if (theCollision.gameObject.tag == "Tomato")
        {
            Destroy(theCollision.gameObject);
            var TopfRenderer = Topf.GetComponent<Renderer>();
            TopfRenderer.material.SetColor("_Color", Color.green);
            StartCoroutine(ResetColorTopf());
            Soup.GetComponent<Renderer>().material.color = new Color(0.7547f, 0.1614f, 0.0818f);
            score++;
            Debug.Log("score= " + score);
        }
        else if (theCollision.gameObject.tag == "Onion")
        {
            Destroy(theCollision.gameObject);
            var TopfRenderer = Topf.GetComponent<Renderer>();
            TopfRenderer.material.SetColor("_Color", Color.green);
            StartCoroutine(ResetColorTopf());
            Soup.GetComponent<Renderer>().material.color = new Color(0.9f, 0.7f, 0.6f);
            score++;
            Debug.Log("score= " + score);
        }
        else if (theCollision.gameObject.tag == "Garlic")
        {
            Destroy(theCollision.gameObject);
            var TopfRenderer = Topf.GetComponent<Renderer>();
            TopfRenderer.material.SetColor("_Color", Color.green);
            StartCoroutine(ResetColorTopf());
            Soup.GetComponent<Renderer>().material.color = new Color(0.9f, 0.8f, 0.43f);
            score++;
            Debug.Log("score= " + score);
        }
        else if (theCollision.gameObject.tag == "Clipboard")
        {
            Debug.Log("clipboard");
            clipboard.position = clipPos.position;
        }
        else
        {
            Destroy(theCollision.gameObject);
            var TopfRenderer = Topf.GetComponent<Renderer>();
            TopfRenderer.material.SetColor("_Color", Color.red);
            StartCoroutine(ResetColorTopf());
            Soup.GetComponent<Renderer>().material.color = new Color(0.2f, 0.3f, 0.2f);
        }

        if (score == 5f)
        {
            Debug.Log("finished");
            light1.intensity = 0.5f;
            light2.intensity = 0.5f;
            light3.intensity = 0.5f;
            light4.color = new Color(0.0f, 0.8f, 0.0f);
            light4.intensity = 1.5f;
        }
    }

    public IEnumerator ResetColorTopf()
    {
        yield return new WaitForSeconds(0.5f);
        var TopfRenderer = Topf.GetComponent<Renderer>();
        TopfRenderer.material.SetColor("_Color", Color.white);
    }

    void Update()
    {

    }
}
