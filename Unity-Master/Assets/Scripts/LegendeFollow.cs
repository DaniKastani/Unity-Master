using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegendeFollow : MonoBehaviour
{

    [SerializeField] private Transform cameraTransform; 
    [SerializeField] private float distance = 3.0f;

    private bool isCentered = false;

    public float offsetX;
    public float offsetY;
    public float offsetZ;
     
       private Vector3 correctPosition;
       private Vector3 offset;

     private Transform currentPosition;
     
         void Start()
    {
        offset = new Vector3(offsetX, offsetY, offsetZ);
    }

    private void OnBecameInvisible(){
        isCentered = false;
    }

    // Update is called once per frame
    void Update()
    {

        

       if(!isCentered)
        {
            Vector3 targetPosition = FindTargetPosition();
        
            MoveTowards(targetPosition);

            if (ReachedPosition(targetPosition))
            {
                isCentered = true;
            }
        }
    }


    private Vector3 FindTargetPosition()
    {
        return cameraTransform.position + ((cameraTransform.forward + offset) * distance);
    }

    private void MoveTowards(Vector3 targetPosition)
    {
        transform.position += (targetPosition - transform.position)* 0.025f;
    }

    private bool ReachedPosition(Vector3 targetPosition)
    {
        return Vector3.Distance(targetPosition, transform.position) < 0.1f;
    }

   
    
}
