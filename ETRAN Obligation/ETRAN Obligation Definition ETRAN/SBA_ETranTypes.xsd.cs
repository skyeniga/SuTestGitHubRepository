namespace SBA.ETRANObligation.Definition.ETRAN {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    public sealed class SBA_ETranTypes : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:simpleType name=""SBA_1416Control"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{1,10}_\d{1,3}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionsLoanServicing"">
    <xs:restriction base=""xs:string"">
      <xs:minLength value=""6"" />
      <xs:maxLength value=""9"" />
      <xs:enumeration value=""cancel"" />
      <xs:enumeration value=""reinstate"" />
      <xs:enumeration value=""update"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionsLocate"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""locate"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionsLocateOrUpdate"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""locate"" />
      <xs:enumeration value=""update"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionsInsertOrDelete"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""insert"" />
      <xs:enumeration value=""delete"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionsInsertDeleteOrDeleteAllIfUpdatingAnExistingApp"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""insert"" />
      <xs:enumeration value=""delete"" />
      <xs:enumeration value=""deleteall"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionsInsertOrDeleteIfUpdatingAnExistingApp"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""insert"" />
      <xs:enumeration value=""delete"" />
      <xs:enumeration value=""deleteall"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionsInsertOrUpdateIfUpdatingAnExistingApp"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""insert"" />
      <xs:enumeration value=""update"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionsInsertUpdateDeleteOrDeleteAllIfUpdatingAnExistingApp"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""insert"" />
      <xs:enumeration value=""update"" />
      <xs:enumeration value=""delete"" />
      <xs:enumeration value=""deleteall"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionsInsertUpdateOrDeleteIfUpdatingAnExistingApp"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""insert"" />
      <xs:enumeration value=""update"" />
      <xs:enumeration value=""delete"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_DisbClosingCode"">
    <xs:restriction base=""xs:int"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ETranVersions"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""2.0"" />
      <xs:enumeration value=""2.3"" />
      <xs:enumeration value=""3.0"" />
      <xs:enumeration value=""3.2"" />
      <xs:enumeration value=""3.3"" />
      <xs:enumeration value=""3.3x"" />
      <xs:enumeration value=""3.4"" />
      <xs:enumeration value=""3.4c"" />
      <xs:enumeration value=""3.4i"" />
      <xs:enumeration value=""3.4p"" />
      <xs:enumeration value=""3.5"" />
      <xs:enumeration value=""3.6"" />
      <xs:enumeration value=""3.7"" />
      <xs:enumeration value=""3.8"" />
      <xs:enumeration value=""3.8i"" />
      <xs:enumeration value=""3.9"" />
      <xs:enumeration value=""4.0"" />
      <xs:enumeration value=""5.0"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_FreqCode"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
      <xs:enumeration value="""" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""X"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_FreqSchedule"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(0[1-9]){0,9}(1[0-2]){0,3}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_GntyFee"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{0,5}[.]{0,1}\d{0,2}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_OrigStatCd"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""2"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""FD"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""R1"" />
      <xs:enumeration value=""R2"" />
      <xs:enumeration value=""R3"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ServResultInd"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ServSchedNmbValue"">
    <xs:restriction base=""xs:int"" />
  </xs:simpleType>
  <xs:simpleType name=""SBA_ServStatCd"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d[.]\d"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_TermStartType"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
      <xs:enumeration value="""" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""N"" />
    </xs:restriction>
  </xs:simpleType>
</xs:schema>";
        
        public SBA_ETranTypes() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [0];
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
