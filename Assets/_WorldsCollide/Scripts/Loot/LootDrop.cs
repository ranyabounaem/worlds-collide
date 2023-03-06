using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootDrop : MonoBehaviour
{
    [field: SerializeField]
    public Item Item { get; set; }

    Rigidbody2D _rigidbody;
    SpriteRenderer _spriteRenderer;
    BoxCollider2D _boxCollider;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    public void Drop()
    {
        var randomX = Random.Range(-2, 2);
        var randomY = Random.Range(1, 3);
        _rigidbody.AddForce(new Vector2(randomX, randomY) * 200f);
        _rigidbody.AddTorque(randomX * 10f);
        _spriteRenderer.sprite = Item.Sprite;
        _boxCollider.size = new Vector2(0.5f, 0.5f);


    }
}
