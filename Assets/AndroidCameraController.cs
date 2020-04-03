using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidCameraController : MonoBehaviour
{
    public float speed = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
            Vector3 touchDeltaPos = Input.GetTouch(0).deltaPosition;
            transform.Translate (-touchDeltaPos.x * speed,-touchDeltaPos.y * speed  ,-touchDeltaPos.z * speed);

            
          

            transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x,-500.0f,600.0f),
                    Mathf.Clamp(transform.position.y,700.0f,800.0f),
                    Mathf.Clamp(transform.position.z,-500.0f,800.0f)
                );
            
        }

        
    

        if (Input.touchCount == 2){
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos ).magnitude;
            float touchDeltaMag  = (touchZero.position - touchOne.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            Camera.main.fieldOfView += deltaMagnitudeDiff * 0.1f;

            Camera.main.fieldOfView = Mathf.Clamp( Camera.main.fieldOfView, 30.0f,80.0f);

        }
        
    }
}
