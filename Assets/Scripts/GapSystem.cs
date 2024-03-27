using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class GapSystem : MonoBehaviour
{
    private GameObject gaps;
    public int number;

    public int level;

    public Image frame;
    // Start is called before the first frame update
    void Start()
    {
        gaps = GameObject.Find("Gaps");
        transform.SetParent(gaps.transform);
        transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
        if(level == 1)
        {
            if (number == 1)
            {
                transform.localPosition = new Vector3(-228, 0, 0);
            }
            else if (number == 2)
            {
                transform.localPosition = new Vector3(0, 0, 0);
            }
            else if (number == 3)
            {
                transform.localPosition = new Vector3(228, 0, 0);
            }
            DOTween.Sequence()
                .Append(transform.DOScale(3f, 0.5f))
                .Append(transform.DOScale(2f, 0.5f))
                .Append(transform.DOScale(2.5f, 0.5f));
        }
        else if(level == 2)
        {
            if (number == 1)
            {
                transform.localPosition = new Vector3(228, 0, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                transform.DOLocalMoveY(119, 1);
            }
            else if (number == 2)
            {
                transform.localPosition = new Vector3(0, 0, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                transform.DOLocalMoveY(119, 1);
            }
            else if (number == 3)
            {
                transform.localPosition = new Vector3(-228, 0, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                transform.DOLocalMoveY(119, 1);
            }
            else if (number == 4)
            {
                transform.localPosition = new Vector3(-228, 0, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                transform.DOLocalMoveY(-119, 1);
            }
            else if (number == 5)
            {
                transform.localPosition = new Vector3(0, 0, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                transform.DOLocalMoveY(-119, 1);
            }
            else if (number == 6)
            {
                transform.localPosition = new Vector3(228, 0, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                transform.DOLocalMoveY(-119, 1);
            }
        }
        else if (level == 3)
        {
            if (number == 1)
            {
                transform.localPosition = new Vector3(-228, 119, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                transform.DOLocalMoveY(228, 1);
            }
            else if (number == 2)
            {
                transform.localPosition = new Vector3(0, 119, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                transform.DOLocalMoveY(228, 1);
            }
            else if (number == 3)
            {
                transform.localPosition = new Vector3(228, 119, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                transform.DOLocalMoveY(228, 1);
            }
            else if (number == 4)
            {
                transform.localPosition = new Vector3(-228, 0, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            }
            else if (number == 5)
            {
                transform.localPosition = new Vector3(0, 0, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            }
            else if (number == 6)
            {
                transform.localPosition = new Vector3(228, 0, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            }
            else if (number == 7)
            {
                transform.localPosition = new Vector3(-228, -119, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                transform.DOLocalMoveY(-228, 1);
            }
            else if (number == 8)
            {
                transform.localPosition = new Vector3(0, -119, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                transform.DOLocalMoveY(-228, 1);
            }
            else if (number == 9)
            {
                transform.localPosition = new Vector3(228, -119, 0);
                transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
                transform.DOLocalMoveY(-228, 1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
