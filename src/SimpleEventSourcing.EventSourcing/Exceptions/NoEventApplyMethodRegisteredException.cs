﻿using System;
using SimpleEventSourcing.Messages;

namespace SimpleEventSourcing.EventSourcing.Exceptions
{
    [Serializable]
    public class NoEventApplyMethodRegisteredException : EventSourceException
    {
        public NoEventApplyMethodRegisteredException(IEvent evt, EventStream eventStream) 
            : base (string.Format("No Event Applier Registered For {0} on {1}", evt.GetType().Name, eventStream.Name))
        {
        }
    }
}