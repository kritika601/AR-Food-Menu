using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject samosa_ingr;
    public void Trigger(){
        if(samosa_ingr.activeInHierarchy==false){
            samosa_ingr.SetActive(true);
        }
        else{
            samosa_ingr.SetActive(false);
        }
    }
}
