using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sweetTransform : MonoBehaviour
{
    public GameObject originalSweet;
    public GameObject newSweet;
    void Update()
    {
        //When the "Space Key is pressed spawns a new sweet prefab and deletes the static sweet
        if (Input.GetKey(KeyCode.Space))
        {
            var transformedSweet = Instantiate(newSweet, new Vector3(originalSweet.transform.position.x, originalSweet.transform.position.y, 0), Quaternion.identity);
            Destroy(originalSweet);
        }
    }
}
