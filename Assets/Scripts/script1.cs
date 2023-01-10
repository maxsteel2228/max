using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class script1 : MonoBehaviour
{

    public int age;
    public float health;
    public float damage;
    public float defence;
    [SerializeField]private string characterName;
    public Vector2 xy;
    public Vector3 xyz;
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    public Vector3 scale;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * direction;
    }
}

