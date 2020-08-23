using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isMovement = true;
    public Transform followTarget;
    public float moveSpeedCam;
    [SerializeField]
    private Vector3 MaxPosCam,MinPosCam;
    void Start()
    {
        this.transform.position = new Vector3(0, 0, -5f);
    }
    void LateUpdate()
    {
        if(isMovement)
        if(this.transform.position != followTarget.position)
        {
            Vector3 PosCamNew = new Vector3(followTarget.position.x, followTarget.position.y, this.transform.position.z);
            PosCamNew.x = Mathf.Clamp(PosCamNew.x, MinPosCam.x, MaxPosCam.x);
            PosCamNew.y = Mathf.Clamp(PosCamNew.y, MinPosCam.y, MaxPosCam.y);
            this.transform.position = Vector3.Lerp(this.transform.position, PosCamNew, moveSpeedCam) ;
           
        }
    }
  
    void Update()
    {
        
        
    }
  
}
