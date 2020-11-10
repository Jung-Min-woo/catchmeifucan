using Assets.Source;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAR_detection : MonoBehaviour
{
    public GameObject Target;
    public bool rot = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Foe")
        {
            rot = true;
            Target = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Foe")
        {
            rot = false;
        }
    }
}
