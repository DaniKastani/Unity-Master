using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazyFollow2 : MonoBehaviour
{
       public Transform player;
       public float offsetX;
       public float offsetY;
       public float offsetZ;
       private Vector3 offset = new Vector3(0f, 0f, -10f);
       private float smoothTime = 0.25f;
       private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 targetPosition = new Vector3(player.transform.position.x + offsetX, player.transform.position.y + offsetY , player.transform.position.z + offsetZ);
       transform. position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        
    }
}
