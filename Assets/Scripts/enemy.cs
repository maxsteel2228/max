using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float damage;
    public float heal;
    [SerializeField] private Vector3 move;
    [SerializeField] private string characterName;
    [SerializeField] private script1 script1;
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    public Vector3 scale;
    // Start is called before the first frame update
    void Start()
    {
        script1.health -= damage - script1.defence;
        script1.health += heal;
        transform.localScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += move;
        transform.position += speed * direction;
    }
}
