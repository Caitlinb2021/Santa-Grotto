using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchRaycast : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    private LightSwitchController interactiveObj;

    private void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out RaycastHit hit, rayLength))
        {
            var raycastObj = hit.collider.gameObject.GetComponent<LightSwitchController>();
            if (raycastObj != null)
            {
                interactiveObj = raycastObj;
            }
            else
            {
                ClearInteraction();
            }
        }
        else
        {
            ClearInteraction();
        }
        if(interactiveObj != null)
            {
                if(Input.GetMouseButtonDown(0))
                {
                    interactiveObj.InteractSwitch();
                }
            }
        }
    private void ClearInteraction()
    {
        if (interactiveObj != null)
        {
            interactiveObj = null;
        }
    }
}
