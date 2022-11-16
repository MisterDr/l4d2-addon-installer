using System;
using System.Runtime.CompilerServices;

namespace Left_4_Dead_2_Add_on_Installer
{
    public class ProtocolHandler
    {
        public delegate void ProtocolMessageDispatchEventHandler(string p);

        public string _ProtocolString;

        private ProtocolMessageDispatchEventHandler ProtocolMessageDispatchEvent;

        public string ProtocolString
        {
            get
            {
                return _ProtocolString;
            }
            set
            {
                _ProtocolString = value;
                ProtocolMessageDispatchEvent?.Invoke(value);
            }
        }

        public event ProtocolMessageDispatchEventHandler ProtocolMessageDispatch
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            add
            {
                ProtocolMessageDispatchEvent = (ProtocolMessageDispatchEventHandler)Delegate.Combine(ProtocolMessageDispatchEvent, value);
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            remove
            {
                ProtocolMessageDispatchEvent = (ProtocolMessageDispatchEventHandler)Delegate.Remove(ProtocolMessageDispatchEvent, value);
            }
        }

        public ProtocolHandler()
        {
            _ProtocolString = null;
        }
    }
}
