using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class enemys : MonoBehaviour
{
    private Sequence sequence;
    [SerializeField] private float scaleMultiplier = 1.2f;
    [SerializeField] private float scaleTime = .2f;
    [SerializeField] private GameObject playerPref;

    //private void Update()
    //{
    //    Debug.Log(gameObject.name);
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sequence = DOTween.Sequence();
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "farmer")
        {
            sequence.Append(transform.DOScale(1.1f * transform.localScale, scaleTime))
                    .Append(transform.DOScale(1.3f * transform.localScale, scaleTime))
                    .Append(transform.DOScale(1.5f * transform.localScale, scaleTime))
                    .Append(transform.DOScale(1.7f * transform.localScale, scaleTime));

            Destroy(gameObject, scaleTime * 4);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "farmer")
        {
            Destroy(collision.gameObject, scaleTime * 4);
        }
    }


}
