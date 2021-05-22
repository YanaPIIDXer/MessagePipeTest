using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MessagePipe;
using Zenject;

namespace Test1
{
    /// <summary>
    /// メッセージ送信側
    /// </summary>
    public class MessagePublisher : MonoBehaviour
    {
        /// <summary>
        /// メッセージ送信オブジェクト
        /// </summary>
        [Inject]
        private IPublisher<Message> Publisher = null;
    }
}
