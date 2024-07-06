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

        }


        [SerializeField]
        List<Switch> m_CompassList = new List<Switch>();

        public InputActionReference switchCompass = null;

        int m_CurrentStepIndex = 0;

     
        
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
    m_CompassList[m_CurrentStepIndex].compassObject.SetActive(false);
    m_CurrentStepIndex = (m_CurrentStepIndex + 1) % m_CompassList.Count;
    m_CompassList[m_CurrentStepIndex].compassObject.SetActive(true);
    }

       
  
    }

}
