using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BlazorDemo {
    public static class DataUtils {
        public static HashSet<string> ApplyModifiedFields<T>(T from, T to, IEnumerable<string> fieldNamesToWatch = null) where T: class {
            HashSet<string> modifiedFields = new();
            ForEachFieldOf<T>(fieldProperty => {
                var sourceValue = fieldProperty.GetValue(to);
                var value = fieldProperty.GetValue(from);
                if(!Equals(value, sourceValue)) {
                    fieldProperty.SetValue(to, value);
                    modifiedFields.Add(fieldProperty.Name);
                }
            }, fieldNamesToWatch);
            return modifiedFields;
        }
        static void ForEachFieldOf<T>(Action<PropertyDescriptor> func, IEnumerable<string> fieldNames = null) {
            var properties = TypeDescriptor.GetProperties(typeof(T));
            if(fieldNames == null)
                fieldNames = properties.OfType<PropertyDescriptor>().Select(x => x.Name);
            foreach(string field in fieldNames) {
                var fieldProperty = properties[field];
                func(fieldProperty);
            }
        }
    }
}
