using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Vector3 desiredDirection = Vector3.Normalize(new Vector3(Camera.main.transform.forward.x, 0, Camera.main.transform.forward.z));
            transform.rotation = Quaternion.LookRotation(desiredDirection);
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log(transform.forward);
        }
    }
}
