using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI8 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gulab_cult;
    public void Trigger(){
        if(gulab_cult.activeInHierarchy==false){
            gulab_cult.SetActive(true);
        }
        else{
            gulab_cult.SetActive(false);
        }
    }
}
