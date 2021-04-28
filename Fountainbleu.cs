using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Fountainbleu : MonoBehaviour
{
    [SerializeField] UnityEvent fClicked;

    //Invoke action
    private void OnMouseDown(){
        fClicked.Invoke();
    }
    
    //open link
    public void EventClick(){
        Application.OpenURL("https://www.fontainebleau.com/");
    }
}