using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Animal : MonoBehaviour
{

    public string name;
    public string sound;
    // Update is called once per frame
    public void PlaySound()
    {
        Debug.Log(name + " : " + sound);
    }
}
