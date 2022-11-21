using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByeBullet : MonoBehaviour
{

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    public class bull : MonoBehaviour
    {
        public float timeToLiveBullets = 2f;

        void Start()
        {
            Destroy(gameObject, timeToLiveBullets);
        }
    }
}