﻿using System;
using Plugins;
namespace RedStone
{
    public class ProxyBase
    {
        public virtual ClientNetworkManager network
        {
            get { return null; }
        }

        public T GetProxy<T>() where T : ProxyBase
        {
            return ProxyManager.instance.GetProxy<T>();
        }

        public void SendEvent(string eventName, object obj = null)
        {
            GF.Send(eventName, obj);
        }


        public virtual void SendMessage<T>(T msg)
        {
            network.Send(msg);
        }

        public virtual void SendMessage<TSend, TReply>(TSend msg, Action<TReply> action)
        {
            network.Send(msg, action);
        }

        public virtual void OnInit()
        {

        }

        public virtual void OnUpdate()
        {

        }

        public virtual void OnDestroy()
        {

        }
    }
}
