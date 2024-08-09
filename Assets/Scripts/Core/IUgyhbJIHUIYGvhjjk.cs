using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace GYUikoqwlebh
{
    public class IUgyhbJIHUIYGvhjjk : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [FormerlySerializedAs("OnFixedUpdateHolding")] public UnityEvent UhoUIGIUgkuhgk;

        private bool HiuhYbqiHi = false;

        public void OnPointerDown(PointerEventData jioasjpd)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            HiuhYbqiHi = true;
        }

        public void OnPointerUp(PointerEventData asdqwe)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            HiuhYbqiHi = false;
        }

        private void FixedUpdate()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            if (HiuhYbqiHi)
            {
                UhoUIGIUgkuhgk.Invoke();
            }
        }
    }
}