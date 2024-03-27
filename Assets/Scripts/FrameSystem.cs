using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class FrameSystem : MonoBehaviour, IPointerClickHandler
{
    public GameObject Particle;
    private PanelsSystem cnv;
    // Start is called before the first frame update
    void Start()
    {
        cnv = GameObject.Find("Canvas").GetComponent<PanelsSystem>();

        gameObject.GetComponent<Image>().SetNativeSize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData pointerData)
    {
        if(cnv.isCanClick == true)
        {
            if (GameObject.Find("Canvas").GetComponent<PanelsSystem>().toFind == gameObject.GetComponent<Image>().sprite)
            {
                transform.DOPause();
                DOTween.Sequence()
                    .Append(transform.DOScale(0.24f, 0.5f))
                    .Append(transform.DOScale(0.12f, 0.5f))
                    .Append(transform.DOScale(0.16f, 0.5f));
                StartCoroutine(waitSpawn());
                Particle.SetActive(true);
                GameObject.Find("Canvas").GetComponent<PanelsSystem>().toFind = null;
            }
            else
            {
                transform.localPosition = new Vector3(0, 0, 0);
                transform.DOPause();
                transform.DOPunchPosition(new Vector3(10, 0, 0), 1f).SetEase(Ease.InBounce);

            }
        }
    }

    IEnumerator waitSpawn()
    {
        cnv.isCanClick = false;
        yield return new WaitForSeconds(1.5f);
        cnv.ClearArray();

        if (cnv.framesCount == 3)
        {
            cnv.framesCount = 6;
            cnv.SpawnGaps();
        }
        else if (cnv.framesCount == 6)
        {
            cnv.framesCount = 9;
            cnv.SpawnGaps();
        }
        else if(cnv.framesCount == 9)
        {
            cnv.restartPanel.SetActive(true);
            cnv.restartPanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        }
        cnv.isCanClick = true;
    }
}
