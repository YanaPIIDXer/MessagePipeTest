using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test1
{
    /// <summary>
    /// メッセージ
    /// </summary>
    public class Message
    {
        /// <summary>
        /// 送信メッセージ
        /// </summary>
        public string SendMessage { get; private set; } = "";

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="SendMessage">送信メッセージ</param>
        public Message(string SendMessage)
        {
            this.SendMessage = SendMessage;
        }
    }
}
