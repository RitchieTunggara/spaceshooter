using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 8f;       
    }

    // Update is called once per frame
    void Update()
    {
        //mengambil posisi bullet yg sekarang
        // Vector2 position = transform.position;

        // //menghitung bullet posisi yang baru
        // position = new Vector2 (position.x, position.y + speed * Time.deltaTime);

        // //update posisi bullet
        // transform.position = position;

        // Vector2 max = Camera.main.ViewportToworlsPoint (new Vector2 (1, 1));

        // //menghapus bullet yg keluar layar
        // if (transform.position.y > max.y)
        // {
        //     Destroy(gameObject);
        // }
    }
}
