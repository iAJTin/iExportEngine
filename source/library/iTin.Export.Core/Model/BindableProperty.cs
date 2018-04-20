
namespace iTin.Export.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    [Serializable]
    public class BindableProperty
    {
        public BindableProperty()
        {
            
        }

        public BindableProperty(string @namespace, string functionName)
        {
            Namespace = @namespace;
            FunctionName = functionName;
        }

        public BindableProperty(string functionName)
            : this(string.Empty, functionName)
        {
        }

        public string Namespace { get; set; }
        public string FunctionName { get; set; }

        public virtual string Value
        {
            get
            {
                return
                    string.IsNullOrEmpty(Namespace)
                        ? string.Concat("{Bind:", FunctionName, "}")
                        : string.Concat("{Bind:", string.Join(".", Namespace, FunctionName), "}");
            }
        }

        public override string ToString()
        {
            return
                string.IsNullOrEmpty(Namespace)
                    ? string.Concat("FunctionName = \"", FunctionName, "\"")
                    : string.Concat("Namespace = \"", Namespace, "', FunctionName = \"", FunctionName, "\"");
        }
    }
}
