using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotLogic : MonoBehaviour, IDropHandler
{
    public ShoppingCart sc;
    public CardLogic c, c1, c2, c3, c4, c5, c6, c7, c8;
    public Vector2 slotpos;
    private int svalue;
    void Start()
    {
        slotpos = transform.position;
    }
    public void SetSValue(int valor) {
        svalue = valor;
    }

    public int GetSValue(){
        return svalue;
    }
    public void OnDrop(PointerEventData eventData)
    {

        if (sc.GetTotal() < 1500)
        {
            Debug.Log("OnDrop");
            if (eventData.pointerDrag != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            }

            string namee = eventData.pointerDrag.name;
            int index_card = 0;

            if (namee.Length == 4) index_card = 0;
            else 
            {
                index_card = namee[6] - 48;
            }

            switch (index_card) {
                case 0:
                    c.pos = transform.position;
                    c.TeveDrop = true;
                    break;
                case 1:
                    c1.pos = transform.position;
                    c1.TeveDrop = true;
                    break;
                case 2:
                    c2.pos = transform.position;
                    c2.TeveDrop = true;
                    break;
                case 3:
                    c3.pos = transform.position;
                    c3.TeveDrop = true;
                    break;
                case 4:
                    c4.pos = transform.position;
                    c4.TeveDrop = true;
                    break;
                case 5:
                    c5.pos = transform.position;
                    c5.TeveDrop = true;
                    break;
                case 6:
                    c6.pos = transform.position;
                    c6.TeveDrop = true;
                    break;
                case 7:
                    c7.pos = transform.position;
                    c7.TeveDrop = true;
                    break;
                case 8:
                    c8.pos = transform.position;
                    c8.TeveDrop = true;
                    break;
            }

            if (c.pos == slotpos && index_card == 0)
            {
                svalue = c.GetCValue();
            }
            else if (c1.pos == slotpos && index_card == 1)
            {
                svalue = c1.GetCValue();
            }
            else if (c2.pos == slotpos && index_card == 2)
            {

                svalue = c2.GetCValue();
            }
            else if (c3.pos == slotpos && index_card == 3)
            {

                svalue = c3.GetCValue();
            }
            else if (c4.pos == slotpos && index_card == 4)
            {

                svalue = c4.GetCValue();
            }
            else if (c5.pos == slotpos && index_card == 5)
            {

                svalue = c5.GetCValue();
            }
            else if (c6.pos == slotpos && index_card == 6)
            {

                svalue = c6.GetCValue();
            }
            else if (c7.pos == slotpos && index_card == 7)
            {

                svalue = c7.GetCValue();
            }
            else if (c8.pos == slotpos && index_card == 8)
            {

                svalue = c8.GetCValue();
            }
            else
            {
                svalue = 0;
                c.pos = c.spawnpos;
            }
            sc.SetTotal();
            sc.SetSub();
        }
    }

}
