using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Email : MonoBehaviour
{
    public Text From,Date,To,Subject;
    public Transform Content;
    public string[] EmailDetail;
    public GameObject EmailName;
    public ScrollRect newScrollContent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void emailContent(){
    From.text=EmailDetail[0];
    Date.text=EmailDetail[1];
    To.text=EmailDetail[2];
    Subject.text=EmailDetail[3];
    if(Content.childCount!=0){
    Destroy(Content.GetChild(0).gameObject);
    }
    GameObject newContent=Instantiate(EmailName,Content);

    newScrollContent.content=newContent.GetComponent<RectTransform>();
}}
