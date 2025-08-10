using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishingPlatform : MonoBehaviour
{
    private float vanishTime = 5f;
    private SpriteRenderer _SpriteRenderer;
    private bool _vanishing;
    // Start is called before the first frame update
    void Start()
    {
        _SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Vanish()
    {
       if (!_vanishing)
        {
            _vanishing = true;
            while(_SpriteRenderer.color.a > 0)
            {

                _SpriteRenderer.color = new Color(_SpriteRenderer.color.r,_SpriteRenderer.color.g)
                    _SpriteRenderer.color.b, _SpriteRenderer.color.a - 1 / 255f);
                yield return new WaitForSeconds(vanishTime / 255f);
            }
            transform.DetachChildren();
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (other.gameObject.CompareTag("player"))
            startCorout
    }
}
