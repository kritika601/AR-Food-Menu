using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI5 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dal_cultural;
    public void Trigger(){
        if(dal_cultural.activeInHierarchy==false){
            dal_cultural.SetActive(true);
        }
        else{
            dal_cultural.SetActive(false);
        }
    }
}
