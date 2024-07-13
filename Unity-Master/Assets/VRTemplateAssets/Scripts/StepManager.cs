using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Unity.VRTemplate
{
    /// <summary>
    /// Controls the steps in the in coaching card.
    /// </summary>

 

    public class StepManager : MonoBehaviour
    {
        [Serializable]
        class Step
        {
            [SerializeField]
            public GameObject stepObject;

            [SerializeField]
            public string buttonText;
        }

        [SerializeField]
        public TextMeshProUGUI m_StepButtonTextField;

        [SerializeField]
        List<Step> m_StepList = new List<Step>();

        int m_CurrentStepIndex = 0;

        public GameObject map;
        public GameObject compass;
        public GameObject fov;
       

        public void Next()
        {
            m_StepList[m_CurrentStepIndex].stepObject.SetActive(false);
            m_CurrentStepIndex = (m_CurrentStepIndex + 1) % m_StepList.Count;
            m_StepList[m_CurrentStepIndex].stepObject.SetActive(true);
            m_StepButtonTextField.text = m_StepList[m_CurrentStepIndex].buttonText;

            if(this.gameObject.name == "Map_Tutorial"){
                if(m_CurrentStepIndex == 5){
                    gameObject.SetActive(false);
                    map.SetActive(true);
                 }
            }
            
            if(this.gameObject.name == "FoV_Tutorial"){
                if(m_CurrentStepIndex == 6){
                    gameObject.SetActive(false);
                    fov.SetActive(true);
                 }
            }

            if(this.gameObject.name == "Compass_Tutorial"){
                if(m_CurrentStepIndex == 6){
                    gameObject.SetActive(false);
                    compass.SetActive(true);
                 }
            }
        }
    }
}
