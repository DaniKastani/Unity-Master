using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class XRRigMove : MonoBehaviour
{

    public GameObject myXRRig; 

    public InputActionReference changePosition = null;

    bool locationChange = false;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
        {

             changePosition.action.started += Move;
        }

        private void onDestroy()
            {

                changePosition.action.started += Move; 
            }


    // Update is called once per frame
    void Update()
    {
        
    }

      private void Move (InputAction.CallbackContext move)
    {

      
        if (!locationChange){
            myXRRig.transform.position = new Vector3(-13.77f, 0f, 5.4f);
            locationChange = true;
            Debug.Log("location2");
        } else {
            myXRRig.transform.position = new Vector3(-13.81f, 0f ,25.04f);
            locationChange = false;
            Debug.Log("locaiton1");
       
        }
     
    }
}
