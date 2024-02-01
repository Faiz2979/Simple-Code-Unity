using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // public float TimeSpeed()
    public void Zawarudo(){
        Time.timeScale=0;
    }
    public void ReverseZawarudo(){
        Time.timeScale=1;
    }
    // void Update(){
    //     Time.timeScale=TimeSpeed;
    // }
}
