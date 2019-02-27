namespace SBA.ETRANObligation.Definition.ETRAN {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ws.elend",@"Originate3")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Originate3"})]
    public sealed class SBAETranOriginate3Request : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://ws.elend"" targetNamespace=""http://ws.elend"" id=""Originate3Request"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Originate3"">
    <xs:annotation>
      <xs:documentation>Wrapper element for message ""Originate3Request"" of RPC operation ""Originate3"".</xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""username"" type=""xs:string"" />
        <xs:element name=""password"" type=""xs:string"" />
        <xs:element name=""email"" type=""xs:string"" />
        <xs:element name=""loanappxml"" type=""xs:string"" />
        <xs:element name=""respfrmt"" type=""xs:string"" />
        <xs:element name=""softwarevendorname"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SBAETranOriginate3Request() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Originate3";
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
