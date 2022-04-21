using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardLogic : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public ShoppingCart sc;
    public SlotLogic sl, sl1, sl2, sl3, sl4;
    private int cvalue;
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasgroup;
    public Vector2 pos, spawnpos;
    public bool TeveDrop;

    void Start()
    {
        spawnpos = transform.position;
        pos = spawnpos;
    }
    public void SetCValue(int valor)
    {
        cvalue = valor;
    }
    public int GetCValue()
    {
        return cvalue;
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasgroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasgroup.blocksRaycasts = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        TeveDrop = false;
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");

        canvasgroup.blocksRaycasts = true;
        
        if (TeveDrop == false || (TeveDrop == true && (sc.GetTotal() > 1500)))
        {
            FuncoesPeloAmorDeDeus();
        }
        sc.SetTotal();
        sc.SetSub();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    public void FuncoesPeloAmorDeDeus()
    {
        if (pos == sl.slotpos)
        {
            sl.SetSValue(0);
        }
        else if (pos == sl1.slotpos)
        {
            sl1.SetSValue(0);
        }
        else if (pos == sl2.slotpos)
        {
            sl2.SetSValue(0);
        }
        else if (pos == sl3.slotpos)
        {
            sl3.SetSValue(0);
        }
        else if (pos == sl4.slotpos)
        {
            sl4.SetSValue(0);
        }
        pos = spawnpos;
        transform.position = spawnpos;
    }
}
