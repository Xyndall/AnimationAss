using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTrigger : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(TreeDied());
        
    }

    IEnumerator TreeDied()
    {
        transform.Rotate(new Vector3(0, 0, 45) , Space.Self);
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

}
