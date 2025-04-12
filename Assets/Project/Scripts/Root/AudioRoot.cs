using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Scripts.Root
{
    public class AudioRoot : MonoBehaviour
    {
        [SerializeField]private AudioMixer _audioMixer;

        private Dictionary<ChannelEnum,string> _channelDictionary;

        public void Initialization()
        {
            _channelDictionary = new Dictionary<ChannelEnum, string>();

            _channelDictionary[ChannelEnum.sfx] = "_sfx";
            _channelDictionary[ChannelEnum.ambient] = "_ambient";
            _channelDictionary[ChannelEnum.music] = "_music";
        }
    }


    public enum ChannelEnum
    {
        sfx,
        ambient,
        music
    }
}