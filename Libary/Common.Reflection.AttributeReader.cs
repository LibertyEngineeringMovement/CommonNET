using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Common.Reflection;

namespace Common.Reflection
{
    public class AttributeReader<T> where T : System.Attribute
    {
        private TypeInfo ClassToBeTestedType;

        public AttributeReader(object InstanceToBeTested)
        {
            ClassToBeTestedType = InstanceToBeTested.GetType().GetTypeInfo();
        }

        public T GetClassAttribute()
        {
            return ClassToBeTestedType.GetCustomAttribute<T>();
        }

        public T GetMethodAttribute(string MethodName)
        {
            var MethodInfo = ClassToBeTestedType.DeclaredMethods.Where(n => n.Name == MethodName).FirstOrDefault();
            if (MethodInfo == null) throw new MethodNotFoundException();
            return MethodInfo.GetCustomAttribute<T>();
        }
        public T GetPropertyAttribute(string MethodName)
        {
            var MethodInfo = ClassToBeTestedType.DeclaredProperties.Where(n => n.Name == MethodName).FirstOrDefault();
            if (MethodInfo == null) throw new ParameterNotFoundException();
            return MethodInfo.GetCustomAttribute<T>();
        }
        public T GetEventsAttribute(string MethodName)
        {
            var MethodInfo = ClassToBeTestedType.DeclaredEvents.Where(n => n.Name == MethodName).FirstOrDefault();
            if (MethodInfo == null) throw new EventNotFoundException();
            return MethodInfo.GetCustomAttribute<T>();
        }
    }
    
    public class MethodNotFoundException : Exception {}
    public class MethodNotFoundException : Exception {}
    public class ParameterNotFoundException : Exception {}

}
