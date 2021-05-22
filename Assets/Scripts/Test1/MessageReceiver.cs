using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using MessagePipe;
using System;

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

        /// <summary>
        /// Disposable
        /// </summary>
        private IDisposable Disposable = null;

        void Awake()
        {
            var d = DisposableBag.CreateBuilder();
            Subscriber.Subscribe((Message) => Debug.Log(Message.SendMessage)).AddTo(d);
            Disposable = d.Build();
        }

        void OnDestroy()
        {
            Disposable.Dispose();
        }
    }
}
