using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace FTyuikqlwe.odjhuqwopoe
{
    public class JIOqwneOInoiqwe : BasCreen
    {
        [FormerlySerializedAs("musicIcon")] [SerializeField] private Image qqwopewj;
        [FormerlySerializedAs("soundIcon")] [SerializeField] private Image qpojhquiwireo;
        [FormerlySerializedAs("soundToggle")] [SerializeField] private Toggle qwoihuivbntr;
        [FormerlySerializedAs("musicToggle")] [SerializeField] private Toggle pqwiehv;
        [FormerlySerializedAs("musicSlider")] [SerializeField] private Slider qwpojhbvotr;
        [FormerlySerializedAs("soundSlider")] [SerializeField] private Slider qpweiivtrp;
        [FormerlySerializedAs("musicSprite")] [SerializeField] private Sprite qwpoejvnty;
        [FormerlySerializedAs("soundSprite")] [SerializeField] private Sprite qpqwmekmvjt;
        [FormerlySerializedAs("musicDisabledSprite")] [SerializeField] private Sprite qpwoejinvjt;
        [FormerlySerializedAs("soundDisabledSprite")] [SerializeField] private Sprite qwpvnylpwqiej;
        
        public void qweerfvrtrh34()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            VGHJklqdvwe();
        }

        /*
        public void ToggleMusic()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            _soundManager.OnButtonClick();
            _soundManager.IsMusicTurnedOn = !_soundManager.IsMusicTurnedOn;
            UpdateIcons();
        }

        public void ToggleSound()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            _soundManager.OnButtonClick();
            _soundManager.IsSoundTurnedOn = !_soundManager.IsSoundTurnedOn;
            UpdateIcons();
        }*/

        public void MKamwdqwkle()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            VolMangr.Asqw = (int)(qpweiivtrp.value * 100) - 100;
        }

        public void OINBhwdqwe()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            VolMangr.Mdfq = (int)(qwpojhbvotr.value * 100) - 100;
        }

        public void NBNJKlqqwenebhrv()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            VolMangr.MscMtd = !VolMangr.MscMtd;
            VolMangr.NHGUIdoqwe();
            VGHJklqdvwe();
        }

        public void KJHywhepoqwpe()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            VolMangr.SndMtdw = !VolMangr.SndMtdw;
            VolMangr.NHGUIdoqwe();
            VGHJklqdvwe();
        }

        private void VGHJklqdvwe()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            qpojhquiwireo.sprite = VolMangr.SndMtdw 
                ? qwpvnylpwqiej 
                : qpqwmekmvjt;
            qqwopewj.sprite = VolMangr.MscMtd
                ? qpwoejinvjt
                : qwpoejvnty;
            

            qpweiivtrp.value = (float)(VolMangr.Asqw + 100) / 100;
            qwpojhbvotr.value = (float)(VolMangr.Mdfq + 100) / 100;
        }
    }
}