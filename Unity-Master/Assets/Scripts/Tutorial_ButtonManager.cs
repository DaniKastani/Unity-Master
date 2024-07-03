using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Unity.VRTemplate
{
  public class TutorialManager : MonoBehaviour
    {
        [Serializable]
        class Tutorial
        {
            [SerializeField]
            public GameObject tutorialObject;

        }


        [SerializeField]
        List<Tutorial> m_TutorialList = new List<Tutorial>();


        public void map () {
           m_TutorialList[0].tutorialObject.SetActive(true);
           m_TutorialList[1].tutorialObject.SetActive(false);
           m_TutorialList[2].tutorialObject.SetActive(false);
           m_TutorialList[3].tutorialObject.SetActive(false);
           
        }

        public void fov () {
           m_TutorialList[0].tutorialObject.SetActive(false);
           m_TutorialList[1].tutorialObject.SetActive(true);
           m_TutorialList[2].tutorialObject.SetActive(false);
           m_TutorialList[3].tutorialObject.SetActive(false);
          
        }

          public void compass () {
           m_TutorialList[0].tutorialObject.SetActive(false);
           m_TutorialList[1].tutorialObject.SetActive(false);
           m_TutorialList[2].tutorialObject.SetActive(true);
           m_TutorialList[3].tutorialObject.SetActive(false);
          
        }
     }

}
