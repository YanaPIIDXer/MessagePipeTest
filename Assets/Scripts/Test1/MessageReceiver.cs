using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using MessagePipe;

namespace Test1
{
    /// <summary>
    /// メッセージ受信側
    /// </summary>
    public class MessageReceiver : MonoBehaviour
    {
        /// <summary>
        /// メッセージ受信オブジェクト
        /// </summary>
        [Inject]
        private ISubscriber<Message> Subscriber = null;
    }
}
