using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sofi : MonoBehaviour
{
    public float healt;
    [SerializeField] private string m_myName;
    public Vector3 direction;
    public float speed;
    public float damage;
    [SerializeField] private sofimepega sofimepega;
    // Start is called before the first frame update
    void Start()
    {
        sofimepega.healht -= damage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
