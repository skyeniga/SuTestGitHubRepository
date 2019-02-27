namespace DLAPEventsDefinition {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"STATUS")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"STATUS"})]
    public sealed class EventStatusResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""STATUS"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AppData"">
          <xs:complexType>
            <xs:sequence minOccurs=""1"" maxOccurs=""1"">
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""App_Nbr"" type=""xs:string"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Loan_Type"" type=""xs:string"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Disaster_Name"" type=""xs:string"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Requested_Document_Count"" type=""xs:integer"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Disaster_Deadline_Date"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AccountInformation"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Loan_Nbr"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""StatusData"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Short_Description"" type=""xs:string"" />
              <xs:element name=""Long_Description"" type=""xs:string"" />
              <xs:element name=""Status_Date"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public EventStatusResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "STATUS";
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
