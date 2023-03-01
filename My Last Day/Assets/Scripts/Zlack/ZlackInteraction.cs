using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZlackInteraction : MonoBehaviour
{
    public GameObject MemberList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CheckMemberList(){
    MemberList.SetActive(true);
    }
    public void UnCheckMemberList(){
    MemberList.SetActive(false);
    }
}
