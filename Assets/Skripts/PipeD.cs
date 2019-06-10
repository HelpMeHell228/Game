
using UnityEngine;

public class PipeD : MonoBehaviour {

    private Character character;

    //Это нужно для инициализации
    void Start()
    {
        character = FindObjectOfType<Character>();
        Destroy(gameObject, 15f);

    }

    // Update вызывается один раз на кадр
    void Update()
    {
        

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            character.Death();
        }

    }

}