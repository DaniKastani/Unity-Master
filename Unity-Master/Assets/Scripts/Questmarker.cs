using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questmarker : MonoBehaviour
{
    public GameObject iconPrefab;
    List <Questmarker> questMarkers = new List<Questmarker>();

    public Image image;
    public Sprite icon;

    public Vector2 position{
        get { return new Vector2(transform.position.x, transform.position.z);}
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
