using Assets.Source;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICC : MonoBehaviour
{
    PAR_detection Info_Rot;
    HPIR hpir;
    GameObject par;
    
    // Start is called before the first frame update
    void Start()
    {
         Info_Rot = GameObject.Find("PAR_BEAM").GetComponent<PAR_detection>();
         hpir = GameObject.Find("HPIR").GetComponent<HPIR>();
        par = GameObject.Find("PAR");
    }

    // Update is called once per frame
    void Update()
    {

        if (Info_Rot.rot)
        {
            Debug.Log(Info_Rot.Target.transform.position);
            hpir.rotateAnt(par.transform.rotation);
            hpir.locktgt();
            
        }
    }
}
