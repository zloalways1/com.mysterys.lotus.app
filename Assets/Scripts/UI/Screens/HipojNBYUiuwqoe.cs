using GYpqoiwheui;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace FTyuikqlwe.odjhuqwopoe
{
    public class HipojNBYUiuwqoe : BasCreen
    {
        [FormerlySerializedAs("levelButtons")] [SerializeField] private Button[] qlkjdiubqwope;
        
        private LvfeqxWwsq _lvfeqxWwsq;

        private void Start()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            for (int i = 0; i < qlkjdiubqwope.Length; ++i)
            {
                var t = i;
                qlkjdiubqwope[i].onClick.AddListener(() => HGYVIwuoepqpw(t));
            }
        }

        public void POHgwvyejqwpe(
            LvfeqxWwsq lvfeqxWwsq
        )
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            _lvfeqxWwsq = lvfeqxWwsq;
            
            IHUBwoiedqwjjpoei();
        }
        
        public void HGYVIwuoepqpw(int levelIndex)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            VolMangr.NHGUIdoqwe();
            _cvfw.ChdeDeqv<Jhubhqjwkqwe, OGbdqpwoek>(new OGbdqpwoek { qwihegbijver = levelIndex });
        }
        
        public override void MJIOnqwpeHUO()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            
            
            IHUBwoiedqwjjpoei();
            
            base.MJIOnqwpeHUO();
        }
        
        private void IHUBwoiedqwjjpoei()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            for (int i = 0; i < qlkjdiubqwope.Length; ++i)
            {
                qlkjdiubqwope[i].interactable = i <= _lvfeqxWwsq.JIOjHUIhhOI;
            }
        }
    }
}