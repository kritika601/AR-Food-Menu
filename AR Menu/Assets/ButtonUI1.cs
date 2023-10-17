using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject samosa_nutri;
    public void Trigger(){
        if(samosa_nutri.activeInHierarchy==false){
            samosa_nutri.SetActive(true);
        }
        else{
            samosa_nutri.SetActive(false);
        }
    }
}
