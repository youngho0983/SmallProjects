using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public float pickDistance = 2;
  

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit hitInfo = new RaycastHit();
            if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 200))
            {
                GameObject target = hitInfo.transform.gameObject;
                float distance = Vector3.Distance(target.transform.position, transform.position);
                float magnification = pickDistance / distance;

                target.transform.position = transform.position + new Vector3(target.transform.position.x - transform.position.x, target.transform.position.y - transform.position.y, target.transform.position.z - transform.position.z).normalized * pickDistance;
                
                target.transform.localScale *= magnification;
                
            }
        }
    }
}
