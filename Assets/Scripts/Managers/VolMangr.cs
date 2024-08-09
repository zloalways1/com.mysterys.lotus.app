using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Serialization;

namespace GYpqoiwheui
{
    public class VolMangr : MonoBehaviour
    {
        private const string qwruhorev = "dqwefw";
        private const string mfninnbnire = "fewqweq";
        private const string jioqwjpeojg = "dqweffwqe";
        private const string jiojpioqhwie = "wqefvvrerqw";

        [FormerlySerializedAs("backgroundMusic")] [SerializeField] private AudioSource mel;
        [FormerlySerializedAs("buttonClick")] [SerializeField] private AudioSource bntCl;
        [FormerlySerializedAs("sphereClick")] [SerializeField] private AudioSource jiraClck;
        [FormerlySerializedAs("winSound")] [SerializeField] private AudioSource wS;
        [FormerlySerializedAs("coinCollect")] [SerializeField] private AudioSource cC;
        [FormerlySerializedAs("soundMixerGroup")] [SerializeField] private AudioMixerGroup smGsaq;
        [FormerlySerializedAs("musicMixerGroup")] [SerializeField] private AudioMixerGroup mMGrp;

        private int _asqw = 80;
        private int _mdfq = 80;

        public int Asqw
        {
            get => _asqw;
            set
            {
                _asqw = value;
                JIOhOIhwoqwe();
            }
        }

        public int Mdfq
        {
            get => _mdfq;
            set
            {
                _mdfq = value;
                JHubdqpwiuri();
            }
        }
        
        public bool SndMtdw { get; set; }

        public bool MscMtd
        {
            get => mel.mute;
            set => mel.mute = value;
        }

        private void Start()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            if (!PlayerPrefs.HasKey(qwruhorev))
                PlayerPrefs.SetInt(qwruhorev, _asqw);
            
            if (!PlayerPrefs.HasKey(mfninnbnire))
                PlayerPrefs.SetInt(mfninnbnire, _mdfq);
            
            if (!PlayerPrefs.HasKey(jioqwjpeojg))
                PlayerPrefs.SetInt(jioqwjpeojg, MscMtd ? 1 : 0);
            
            if (!PlayerPrefs.HasKey(jiojpioqhwie))
                PlayerPrefs.SetInt(jiojpioqhwie, SndMtdw ? 1 : 0);

            Asqw = PlayerPrefs.GetInt(qwruhorev);
            Mdfq = PlayerPrefs.GetInt(mfninnbnire);
            MscMtd = PlayerPrefs.GetInt(jioqwjpeojg) == 1;
            SndMtdw = PlayerPrefs.GetInt(jiojpioqhwie) == 1;
            
            JIOhOIhwoqwe();
            JHubdqpwiuri();
        }

        private void OnDestroy()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            PlayerPrefs.SetInt(qwruhorev, Asqw);
            PlayerPrefs.SetInt(mfninnbnire, Mdfq);
        }

        public void NHGUIdoqwe()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            if (SndMtdw)
                return;
            
            bntCl.Play();
        }

        public void IOHpdqwjepg()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            if (SndMtdw)
                return;

            jiraClck.Play();
        }

        public void JOIhdqiwe()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            if (SndMtdw)
                return;

            cC.Play();
        }

        public void NOHIoqwhep()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            if (SndMtdw)
                return;

            wS.Play();
        }

        public void MipejqwoJOeqwe()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            mel.Play();
        }

        private void JIOhOIhwoqwe()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            smGsaq.audioMixer.SetFloat("SoundVolume", _asqw);
        }

        private void JHubdqpwiuri()
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            mMGrp.audioMixer.SetFloat("MusicVolume", _mdfq);
        }
    }
}