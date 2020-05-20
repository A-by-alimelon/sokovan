using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    private Renderer myRenderer;
    public Color touchColor;
    private Color originalColor;
    public bool isOveraped = false;
    
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //트리거인 콜라이더와 충돌했을 때 자동 실행
    //Enter 충돌을 한 그 순간
    void OnTriggerEnter(Collider other){
        if(other.tag == "EndPoint"){
            isOveraped = true;
            myRenderer.material.color = touchColor;
            
        }
        
    }

    //Eixt 붙어있다가 떼어질 때
    void OnTriggerExit(Collider other) {
        if(other.tag == "EndPoint"){
            isOveraped = false;
            myRenderer.material.color = originalColor;
            
        }
    }

    void OnTriggerStay(Collider other) {
        if(other.tag == "EndPoint"){
            isOveraped = true;
            myRenderer.material.color = touchColor;
            
        } 
    }

    //stay 충돌하고 있는 동안

    //일반 콜라이더와 충돌했을 때 자동 실행
    // void OnCollisionEnter(Collision other){

    // }
}
