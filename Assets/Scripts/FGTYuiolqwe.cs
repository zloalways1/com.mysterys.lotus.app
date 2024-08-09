using System;
using GYuikqpwe;
using GYpqoiwheui;
using FTyuikqlwe;
using UnityEngine;
using UnityEngine.Serialization;

public class FGTYuiolqwe : MonoBehaviour
{
        [FormerlySerializedAs("canvas")] [SerializeField] private CanvasView cnv;
        [FormerlySerializedAs("levelsDatabase")] [SerializeField] private uygHBKJIhiuytgh vlmdbt;
        [FormerlySerializedAs("soundManager")] [SerializeField] private VolMangr volMangr;

        private readonly Cntd _cntd = Cntd.Instance;

        private void Start()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();                var t = 60;
                t *= 6;
                t *= 30;
                t /= 3;
                Application.targetFrameRate = (int) Math.Sqrt(t);
                
                DontDestroyOnLoad(this);
                
                _cntd.Register(cnv);
                _cntd.Register(vlmdbt);
                _cntd.Register(new LvfeqxWwsq(vlmdbt));
                _cntd.Register(volMangr);
                
                cnv.IUIYUGvghqjwke(_cntd);
                cnv.VFTYuikqwe();
        }
}