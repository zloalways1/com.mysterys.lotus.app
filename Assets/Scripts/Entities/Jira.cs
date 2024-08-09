using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace GYUIoqowieuyg
{
    public class Jira : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        [FormerlySerializedAs("id")] [SerializeField] private int jirai;
        [FormerlySerializedAs("deadZone")] [SerializeField] private float mveREfl;
        [FormerlySerializedAs("destroyScaling")] [SerializeField] private float scalDesrt = 0.85f;
        
        public int Jirai => jirai;

        private Vector2 _sdp1;
        private bool _mv3 = false;
        private bool _iDstr1 = false;
        private float _lDrstr12;

        public event Action<Jira> KJOIjOIqwe;
        public event Action<Jira, Vector2> JoiphHUIoqwe;


        public void JioqweJIOqweKpo(float drt2)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            _mv3 = true;
            _lDrstr12 = drt2;
            StartCoroutine(JOIPojOjPOIqwe(drt2));
        }

        private IEnumerator JOIPojOjPOIqwe(float drt2)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            Vector3 stp2 = transform.localPosition;
            float pdt120 = 0;

            while (pdt120 <= drt2)
            {
                pdt120 += Time.deltaTime;
                transform.localPosition = stp2 * (1 - pdt120 / drt2);

                yield return null;
            }

            transform.localPosition = Vector3.zero;
            _mv3 = false;
        }

        private void OnDisable()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            if (_iDstr1)
                Destroy(gameObject);
        }

        public void JIJHUIbjqnweuij(float JIOjidqwe)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            _iDstr1 = true;
            _lDrstr12 = JIOjidqwe;
            StartCoroutine(HOIUIbnPOIUbj(JIOjidqwe));
        }

        private IEnumerator HOIUIbnPOIUbj(float drt2)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            float pdt4 = 0;

            while (pdt4 <= drt2)
            {
                pdt4 += Time.deltaTime;
                transform.localScale = Vector3.one * (scalDesrt * pdt4 / drt2);

                yield return null;
            }
            
            Destroy(gameObject);
            _iDstr1 = false;
        }

        public void Svrwq()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            if (_mv3)
                JioqweJIOqweKpo(_lDrstr12);

            if (_iDstr1)
                JIJHUIbjqnweuij(_lDrstr12);
        }
        
        public void OnPointerClick(PointerEventData eventData)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            return;
            
            KJOIjOIqwe.Invoke(this);
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            _sdp1 = eventData.position;
        }

        public void OnDrag(PointerEventData eventData)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();        }

        public void OnEndDrag(PointerEventData eventData)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            Vector2 dgp34 = eventData.position - _sdp1;

            if (dgp34.magnitude <= mveREfl)
                return;
            
            JoiphHUIoqwe.Invoke(this, dgp34.normalized);
        }
    }
}