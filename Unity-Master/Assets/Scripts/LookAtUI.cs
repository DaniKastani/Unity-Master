using UnityEngine;
using TMPro;  // Import the TextMeshPro namespace

public class VRRaycast : MonoBehaviour
{
    public Transform vrCamera;  // Assign your VR camera here
    public float maxDistance = 100.0f;
    public Color rayColor = Color.red;

    private GameObject target;

    void Update()
    {
        // Create a ray from the VR camera
        Ray ray = new Ray(vrCamera.position, vrCamera.forward);
        RaycastHit hit;

        // Perform the raycast
        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            // Draw the ray in the scene view
            Debug.DrawRay(vrCamera.position, vrCamera.forward * hit.distance, rayColor);
            if (hit.collider.tag == "CompassCollider")
            {
                Debug.Log("hit");
                
                target = hit.transform.gameObject;
                target.transform.GetChild(0).gameObject.SetActive(true);
       
            } 
            else 
            {
             Debug.Log("no hit");
                 if(target != null)
                 {
                      target.transform.GetChild(0).gameObject.SetActive(false);
                      target = null;
                 } 
            }
        }
        else
        {
            // Draw the ray to the max distance
            Debug.DrawRay(vrCamera.position, vrCamera.forward * maxDistance, rayColor);
        }
    }
}