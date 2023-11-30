using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleONOFF : MonoBehaviour
{
    // Start is called before the first frame update
    public void Toggle()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
