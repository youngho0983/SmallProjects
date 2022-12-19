using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    float h;
    float v;
    float mx;
    float my;
    [SerializeField]
    GameObject face;

    [SerializeField]
    float moveSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        GetMouseDir();
    }
    private void GetInput()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
        Vector3 moveDirection = transform.forward * v + transform.right * h;
        rb.MovePosition(transform.position +  moveDirection * Time.deltaTime * moveSpeed);

    }
    
    private void GetMouseDir()
    {
        mx = Input.GetAxis("Mouse X");
        my = Input.GetAxis("Mouse Y");
        Debug.Log("mx : " + mx + "   my : " + my);
        
    }
    
    
}
