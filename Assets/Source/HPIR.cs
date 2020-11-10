using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class HPIR : MonoBehaviour
{
    //public Quaternion Angle;
    public void rotateAnt(Quaternion t)
    {
        //this.transform.rotation = t;
        Debug.Log(t);
        while (t == transform.rotation)
        {
            //TODO : transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);
        }
            
            
        //transform.rotation
    }
    public void locktgt()
    {
        Debug.Log("locktgt called");
        //this.transform.rotation = angle;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
