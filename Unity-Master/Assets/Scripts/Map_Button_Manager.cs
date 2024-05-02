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
           m_MapList[2].mapObject.SetActive(true);
           m_MapList[0].mapObject.SetActive(true);
           gameObject.SetActive(false);
            
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

        public void retail()
        {
         m_MapList[0].mapObject.SetActive(true);
         m_MapList[1].mapObject.SetActive(false);
         m_MapList[2].mapObject.SetActive(false);
         m_MapList[3].mapObject.SetActive(false);
        
        }

        public void service()
        {
         m_MapList[0].mapObject.SetActive(false);
         m_MapList[1].mapObject.SetActive(false);
         m_MapList[2].mapObject.SetActive(true);
         m_MapList[3].mapObject.SetActive(false);
        }

        public void hospital()
        {
         m_MapList[0].mapObject.SetActive(false);
         m_MapList[1].mapObject.SetActive(false);
         m_MapList[2].mapObject.SetActive(false);
         m_MapList[3].mapObject.SetActive(true);
        }

        public void back()
        {
           m_MapList[0].mapObject.SetActive(true);
           m_MapList[2].mapObject.SetActive(false);
           m_MapList[1].mapObject.SetActive(true);
           m_MapList[3].mapObject.SetActive(false);
           gameObject.SetActive(false);

           Debug.Log("back");
        }
    }
}




