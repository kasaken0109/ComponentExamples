using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionController : MonoBehaviour
{
    ReflectionProbe reflectionProbe;
    // Start is called before the first frame update
    void Start()
    {
        this.reflectionProbe = GetComponent<ReflectionProbe>();
    }

    // Update is called once per frame
    void Update()
    {
        this.reflectionProbe.transform.position = new Vector3(
            Camera.main.transform.position.x,
            Camera.main.transform.position.y * -1,
            Camera.main.transform.position.z
            );

        reflectionProbe.RenderProbe();
    }
}
