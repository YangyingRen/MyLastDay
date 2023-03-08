using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FilesInteraction : MonoBehaviour, IPointerClickHandler
{
    public Transform InfoContent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData){
    if(eventData.button==PointerEventData.InputButton.Right){
       transform.GetChild(0).gameObject.SetActive(true);
       transform.GetChild(0).SetParent(InfoContent);
    }
    }
}
