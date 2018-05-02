
namespace iTin.Export.Model
{
    using System;

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


        public virtual string Value => string.IsNullOrEmpty(Namespace)
            ? string.Concat("{Bindable:", FunctionName, "}")
            : string.Concat("{Bindable:", string.Join(".", Namespace, FunctionName), "}");

        public override string ToString()
        {
            return
                string.IsNullOrEmpty(Namespace)
                    ? string.Concat("FunctionName = \"", FunctionName, "\"")
                    : string.Concat("Namespace = \"", Namespace, "', FunctionName = \"", FunctionName, "\"");
        }
    }
}
