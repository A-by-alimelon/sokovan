using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody playerRigidbody;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // 화면이 한 번 깜빡일 때, 한 번 실행
    // 1초에 대략 60번 단, 사양에 따라 다르다
    // 몇 번 실행되는 지는 정해져 있지 않다. 
    void Update()
    {
        if(gameManager.isGameOver==true){
            return;
        }
        //유저 입력을 넣자
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        float fallSpeed = playerRigidbody.velocity.y;

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity = velocity * speed;
        velocity.y = fallSpeed;

        playerRigidbody.velocity = velocity;
    }
}
