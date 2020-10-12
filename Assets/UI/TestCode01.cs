using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode01 : MonoBehaviour
{
    public color_pick myColorInst;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("My color is " + myColorInst.lastcolor.ToString());    
    }

    // Update is called once per frame
    void Update()
    {
        //pen.color = myColorClass.lastcolor;
        //Debug.Log("My color is " + myColorInst.lastcolor.ToString());
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);

            Transform origin = transform;
            Vector3 pos = new Vector3(origin.position.x, origin.position.y - 0.5f, origin.position.z + 1);
            Debug.Log(origin.ToString());
            GameObject spawnedObject = Instantiate(m_PlacedPrefab, pos, Quaternion.identity);
            m_SessionOrigin.MakeContentAppearAt(spawnedObject.transform, spawnedObject.transform.position, Quaternion.identity);
            disablePlanes();
        }
    }
}
