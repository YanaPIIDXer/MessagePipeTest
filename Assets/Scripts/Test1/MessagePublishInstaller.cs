using UnityEngine;
using Zenject;
using MessagePipe;

namespace Test1
{
    public class MessagePublishInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            var Opt = Container.BindMessagePipe();
            Container.BindMessageBroker<Message>(Opt);
        }
    }
}
