using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateAndBoxScripy : MonoBehaviour
{
    [SerializeField]
    UnityEngine.Object destructableRef;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.name=="Saw")
            ExplodeThisGameObject();
    }

    private void ExplodeThisGameObject(){
        
        GameObject destructable = (GameObject)Instantiate(destructableRef);
        destructable.transform.position = transform.position;

        Destroy(gameObject);
    }
}
