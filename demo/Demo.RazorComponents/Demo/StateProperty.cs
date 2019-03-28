using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.RazorComponents.Model
{
    public class StateProperty
    {
        public static Action OnChanged { get; set; }
    }
    public class StateProperty<T> : StateProperty
    {
        T v;
        public T Value {
            get => v;
            set {
                v = value;
                try { 
                    OnChanged?.Invoke();
                } catch { }
            }
        }

        public StateProperty() { }
        public StateProperty(T initValue)
        {
            this.v = initValue;
        }
    }
}
