using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI7 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gulab_nutri;
    public void Trigger(){
        if(gulab_nutri.activeInHierarchy==false){
            gulab_nutri.SetActive(true);
        }
        else{
            gulab_nutri.SetActive(false);
        }
    }
}
