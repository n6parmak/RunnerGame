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
        
        if (Input.GetKeyDown("right"))
        {
            switch(_lane){
                case Lane.first:
                transform.position+= new Vector3(2,0,0);
                _lane = Lane.second;
                print("2");
                break;

                case Lane.second:
                transform.position+= new Vector3(2,0,0);
                _lane = Lane.third;
                print("3");
                break;

                case Lane.third:
                print("3");
                break;

            }

        }

        if (Input.GetKeyDown("left"))
        {
            switch(_lane){
                case Lane.first:
                print("1");
                break;

                case Lane.second:
                transform.position-= new Vector3(2,0,0);
                _lane = Lane.first;
                print("1");
                break;

                case Lane.third:
                transform.position-= new Vector3(2,0,0);
                _lane = Lane.second;
                print("2");
                break;

            }

        }
    }
}
