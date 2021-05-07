using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickURL : MonoBehaviour
{
    public string Url;

    public void OnMouseDown(){
        Application.OpenURL(Url);
    }
}
