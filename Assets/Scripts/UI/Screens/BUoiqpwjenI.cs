using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace FTyuikqlwe.odjhuqwopoe
{
    public class BUoiqpwjenI : BasCreen
    {
        [FormerlySerializedAs("progress")] [SerializeField] private Image jidqwioen;
        [FormerlySerializedAs("loadingDuration")] [SerializeField] private float poqwemwemfp = 1f;
        
        public void HOIeqnwp()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            StartCoroutine(KJIOodnqwpe());
        }

        private IEnumerator KJIOodnqwpe()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            var asdkjhqwyiej = 0f;
            jidqwioen.fillAmount = asdkjhqwyiej;
            
            while (asdkjhqwyiej < poqwemwemfp)
            {
                asdkjhqwyiej += Time.deltaTime;
                
                jidqwioen.fillAmount = asdkjhqwyiej / poqwemwemfp;
                
                yield return null;
            }
            
            VolMangr.MipejqwoJOeqwe();
            _cvfw.ChdeDeqv<NHUoipqweNOI>();
        }
    }
}