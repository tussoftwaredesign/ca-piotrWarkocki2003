using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenBook:MonoBehaviour
{
    public GameObject Cover;
    public GameObject Hinge;
    // Start is called before the first frame update
    void Start()
    {
        var Hinge = Cover.GetComponent<HingeJoint>();

        Hinge.useMotor = false;
    }

    // Update is called once per frame
    
    public void OpenBookCover()
    {
        var Hinge = Cover.GetComponent<HingeJoint>();
        Hinge.useMotor =true;
        Debug.Log("motor should be true");
    }

}
