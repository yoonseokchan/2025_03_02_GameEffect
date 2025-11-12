using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererController : MonoBehaviour
{
    [SerializeField] List<LineRenderer> linerenderers = new List<LineRenderer>();

    public void SetPosition(Transform startPos, Transform endPos)
    {
        if(linerenderers.Count > 0)
        {
            for(int i = 0; i < linerenderers.Count; i++)
            {
                if(linerenderers[i].positionCount >= 2)
                {
                    linerenderers[i].SetPosition(0, startPos.position);
                    linerenderers[i].SetPosition(1, endPos.position);
                }
            }
        }
    }
   
}
