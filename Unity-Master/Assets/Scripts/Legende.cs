using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Legende : MonoBehaviour
{
  
    public InputActionReference showLegende = null;

    public Image legende;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {

    showLegende.action.started += Toggle; 

    }

    private void onDestroy()
    {

    showLegende.action.started += Toggle; 

    }

    private void Toggle(InputAction.CallbackContext context)
    {
    Debug.Log("press erkannt");
    bool isActive = legende.gameObject.activeSelf;
    if( isActive){
    legende.gameObject.SetActive(false);
    Debug.Log("active");
    }
    else{
       legende.gameObject.SetActive(true);
       Debug.Log("not active");
    }
    
   
    }

}
