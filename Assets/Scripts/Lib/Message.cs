using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;


public class Message {

    public delegate void MessageCallback(params object[] args);

    public Dictionary<string, List<MessageCallback>> messages;

    public Message() {
        messages = new Dictionary<string, List<MessageCallback>>();
    }

    public Message emit(string name, params object[] args)
    {
        if (messages.ContainsKey(name)){
            foreach( var func in messages[name])
            {
                func(args);
            }
        }

        return this;
    }

    public Message on(string name, MessageCallback callback)
    {
        if(messages.ContainsKey(name))
        {
            messages[name] = null;
        }
        else 
        {
            messages.Add(name, new List<MessageCallback>());
        }

        messages[name].Add(callback);

        return this;
    }
}
