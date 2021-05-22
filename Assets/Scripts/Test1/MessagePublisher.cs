using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MessagePipe;
using Zenject;
using UniRx;
using System;

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

        void Awake()
        {
            Observable.Interval(TimeSpan.FromSeconds(3.0))
                .Subscribe((_) => Publisher.Publish(new Message("Test")))
                .AddTo(gameObject);
        }
    }
}
