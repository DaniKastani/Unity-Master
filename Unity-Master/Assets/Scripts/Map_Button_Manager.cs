using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


namespace Unity.VRTemplate
{
   
    public class MapManager : MonoBehaviour
    {
        [Serializable]
        class Map
        {
            [SerializeField]
            public GameObject mapObject;

        }


        [SerializeField]
        List<Map> m_MapList = new List<Map>();

        int m_CurrentStepIndex = 0;

        public void economics()
        {
           m_MapList[1].mapObject.SetActive(false);
           m_MapList[2].mapObject.SetActive(false);
           m_MapList[0].mapObject.SetActive(true);
           Debug.Log("economics");
        }

        public void social()
        {
           m_MapList[0].mapObject.SetActive(false);
           m_MapList[2].mapObject.SetActive(false);
           m_MapList[1].mapObject.SetActive(true);
           Debug.Log("social");
        }

          public void cultural()
        {
           m_MapList[0].mapObject.SetActive(false);
           m_MapList[1].mapObject.SetActive(false);
           m_MapList[2].mapObject.SetActive(true);
           Debug.Log("culural");
        }
    }
}




