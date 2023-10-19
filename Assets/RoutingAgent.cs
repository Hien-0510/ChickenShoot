using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RoutingAgent : MonoBehaviour
{
    public Route route;
    void Start()
    {

        int n = route.waypoints.Length;
        Sequence seq = DOTween.Sequence();
            for(int i = 1; i < n; i++){
                seq.Append(transform
                    .DOMove(route[i],2)
                    .From(route[i-1])
        );
            }
        seq.Append(transform
                    .DOMove(route[0],2)
                    .From(route[n-1])
        );
        seq.SetLoops(-1);
    }
}
