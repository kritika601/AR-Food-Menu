using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dal_ingredients;
    public void Trigger(){
        if(dal_ingredients.activeInHierarchy==false){
            dal_ingredients.SetActive(true);
        }
        else{
            dal_ingredients.SetActive(false);
        }
    }
}
