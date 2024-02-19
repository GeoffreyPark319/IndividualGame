using System;
using UnityEngine;

public class Holster : MonoBehaviour
{
    public GameObject cameraAnchor;
    private float rotationSpeed = 50;

    void Update()
    {
        //Put holster halfway between on the body
        transform.position = new Vector3(cameraAnchor.transform.position.x, cameraAnchor.transform.position.y / 2, cameraAnchor.transform.position.z);

        var rotationDifference = Math.Abs(cameraAnchor.transform.eulerAngles.y - transform.eulerAngles.y);
        var finalRotationSpeed = rotationSpeed;
        //Make rotation speed faster if holster rotation is further away from central eye camera
        if(rotationDifference > 60)
        {
            finalRotationSpeed = rotationSpeed * 2;
        }else if(rotationDifference > 40 && rotationDifference < 60)
        {
            finalRotationSpeed = rotationSpeed;
        }else if(rotationDifference < 40 && rotationDifference > 20)
        {
            finalRotationSpeed = rotationSpeed / 2;
        }else if(rotationDifference < 20 && rotationDifference > 0)
        {
            finalRotationSpeed = rotationSpeed / 4;
        }
        //The step size is equal to speed times frame time
        var step = finalRotationSpeed * Time.deltaTime;

        //rotate our transform a step closer to the target's
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, cameraAnchor.transform.eulerAngles.y, 0), step);
    }
}
