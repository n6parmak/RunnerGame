using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunnerController : MonoBehaviour
{
    [SerializeField] private float _firstline;
    [SerializeField] private float _secondline;
    [SerializeField] private float _thirdline;
    

    enum Lane {
        first,second,third
    }

    private Lane _lane;

    void Start()
    {
        _lane = Lane.second;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0){
            Touch touch  = Input.touches[0];
            print(touch.deltaPosition.Normalized);
        }
    }
}
