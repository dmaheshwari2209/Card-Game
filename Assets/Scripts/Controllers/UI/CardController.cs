using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class CardController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private Image illustration;
    [SerializeField] private TextMeshProUGUI cardName, health, manaCost, damage;
    
    public Card card;

    private Transform originalParent;

    public void Initialize(Card card)
    {
        this.card = card;
        illustration.sprite = card.illustration;
        cardName.text = card.cardName;
        manaCost.text = card.manaCost.ToString();
        damage.text = card.damage.ToString();
        health.text = card.health.ToString();
        originalParent = transform.parent;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Entered");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.SetParent(transform.root);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.SetParent(originalParent);
        transform.localPosition = Vector3.zero;
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
}
