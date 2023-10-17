using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI6 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gulab_ingr;
    public void Trigger(){
        if(gulab_ingr.activeInHierarchy==false){
            gulab_ingr.SetActive(true);
        }
        else{
            gulab_ingr.SetActive(false);
        }
    }
}
