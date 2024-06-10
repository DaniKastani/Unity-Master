using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
       public Transform player;
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
       Vector3 targetPosition = new Vector3(player.transform.position.x, player.transform.position.y + 0.15f , player.transform.position.z);
       transform. position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        
    }
}
