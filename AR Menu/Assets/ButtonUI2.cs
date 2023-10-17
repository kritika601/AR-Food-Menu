using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject samosa_cult;
    public void Trigger(){
        if(samosa_cult.activeInHierarchy==false){
            samosa_cult.SetActive(true);
        }
        else{
            samosa_cult.SetActive(false);
        }
    }
}
