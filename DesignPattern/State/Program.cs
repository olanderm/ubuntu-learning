﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;

namespace State.Structural
{
    /// <summary>
    /// State Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            // Setup context in a state

            var context = new Context(new ConcreteStateA());

            // Issue requests, which toggles state

            context.Request();
            context.Request();
            context.Request();
            context.Request();

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'State' abstract class
    /// </summary>

    public abstract class State
    {
        public abstract void Handle(Context context);
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>

    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// </summary>

    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>

    public class Context
    {
        State state;

        // Constructor

        public Context(State state)
        {
            this.State = state;
        }

        // Gets or sets the state

        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State: " + state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}
