using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;
using UnityEngine.XR.WSA.Persistence;

[CreateAssetMenu(fileName = "NewFloat", menuName = "AR/FloatData")]
public class FloatData : ScriptableObject
{

    public float value;

    public virtual float Value
    {
        get{ return value;}
        
    }
    
}
