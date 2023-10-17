using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dal_nutrients;
    public void Trigger(){
        if(dal_nutrients.activeInHierarchy==false){
            dal_nutrients.SetActive(true);
        }
        else{
            dal_nutrients.SetActive(false);
        }
    }
}
