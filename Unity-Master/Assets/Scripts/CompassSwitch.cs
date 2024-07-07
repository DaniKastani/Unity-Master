using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Unity.VRTemplate
{
  public class CompassSwitch : MonoBehaviour
    {
        [Serializable]
        class Switch
        {
            [SerializeField]
            public GameObject compassObject;

            [SerializeField]
            public string text;
        }

        [SerializeField]
        public TextMeshProUGUI m_StepButtonTextField1;
        public TextMeshProUGUI m_StepButtonTextField2;

        [SerializeField]
        List<Switch> m_CompassList = new List<Switch>();

        [SerializeField]
        List<Switch> m_CompassList2 = new List<Switch>();

        public InputActionReference switchCompass = null;

        int m_CurrentStepIndex = 0;

       
       CollitionBoolean collitionScript;

       void Start() {
       
       collitionScript = GameObject.FindGameObjectWithTag("PlayerCollider").GetComponent<CollitionBoolean>();

       }

        private void Awake()
        {

             switchCompass.action.started += Change;
        }

        private void onDestroy()
            {

                switchCompass.action.started += Change; 
            }


  



    private void Change (InputAction.CallbackContext context)
    {

        if(collitionScript.secondLocation){
            //m_CompassList2[m_CurrentStepIndex].compassObject.SetActive(false);
            m_CompassList[m_CurrentStepIndex].compassObject.SetActive(false);
            m_CurrentStepIndex = (m_CurrentStepIndex + 1) % m_CompassList.Count;
            m_CompassList[m_CurrentStepIndex].compassObject.SetActive(true);
    
        } else {
           // m_CompassList[m_CurrentStepIndex].compassObject.SetActive(false);
            m_CompassList2[m_CurrentStepIndex].compassObject.SetActive(false);
            m_CurrentStepIndex = (m_CurrentStepIndex + 1) % m_CompassList2.Count;
            m_CompassList2[m_CurrentStepIndex].compassObject.SetActive(true);


        }
     m_StepButtonTextField1.text = m_CompassList[m_CurrentStepIndex].text;
     m_StepButtonTextField2.text = m_CompassList[m_CurrentStepIndex].text;
  
    }

       
  
    }

}
