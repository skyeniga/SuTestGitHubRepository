namespace SBA.ETRANObligation.Definition.ETRAN {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ws.elend",@"CFCInvocationException")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CFCInvocationException"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SBA.ETRANObligation.Definition.ETRAN.SBAETranOriginate3Encoding", typeof(global::SBA.ETRANObligation.Definition.ETRAN.SBAETranOriginate3Encoding))]
    public sealed class SBAETranOriginate3CFCInvocationException : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns1=""http://ws.elend"" xmlns:ns0=""http://schemas.xmlsoap.org/soap/encoding/"" targetNamespace=""http://ws.elend"" xmlns=""http://www.w3.org/2001/XMLSchema"">
  <import schemaLocation=""SBA.ETRANObligation.Definition.ETRAN.SBAETranOriginate3Encoding"" namespace=""http://schemas.xmlsoap.org/soap/encoding/"" />
  <annotation>
    <appinfo>
      <b:references>
        <b:reference targetNamespace=""http://schemas.xmlsoap.org/soap/encoding/"" />
      </b:references>
    </appinfo>
  </annotation>
  <complexType name=""CFCInvocationException"">
    <sequence>
      <any />
    </sequence>
  </complexType>
  <element xmlns:q1=""http://ws.elend"" name=""CFCInvocationException"" type=""q1:CFCInvocationException"" />
</schema>";
        
        public SBAETranOriginate3CFCInvocationException() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CFCInvocationException";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
