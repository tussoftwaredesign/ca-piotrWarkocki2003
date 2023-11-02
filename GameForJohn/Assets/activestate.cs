using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activestate : MonoBehaviour
{

    public GameObject painting;
    // Start is called before the first frame update
    void Start()
    {
        painting.SetActive(false);
    }

    
}
