using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Animal tom = new Animal();
        tom.name = "톰";
        tom.sound = "냐옹!";

        Animal jerry = new Animal();
        jerry.name = "제리";
        jerry.sound = "찍찍!";

        jerry = tom;
        jerry.name = "미키";

        tom.PlaySound();
        jerry.PlaySound();
    }

}
