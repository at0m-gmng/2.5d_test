using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapBorder : MonoBehaviour
{
    [SerializeField] private float max_x;
    [SerializeField] private float min_x;
    [SerializeField] private float max_y;
    [SerializeField] private float min_y;
    private void Update() 
    {

        if (this.transform.localPosition.x > max_x)
            this.transform.localPosition = new Vector3(max_x, this.transform.localPosition.y, this.transform.localPosition.z);
        //Debug.Log("Выход за границы!");

        if (this.transform.localPosition.x < min_x)
                this.transform.localPosition = new Vector3(min_x, this.transform.localPosition.y, this.transform.localPosition.z);
        //Debug.Log("Выход за границы!");

        if (this.transform.localPosition.y > max_y)
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, max_y, this.transform.localPosition.z);
        //Debug.Log("Выход за границы!");

        if (this.transform.localPosition.y < min_y)
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, min_y, this.transform.localPosition.z);
        //Debug.Log("Выход за границы!");
    }
}
