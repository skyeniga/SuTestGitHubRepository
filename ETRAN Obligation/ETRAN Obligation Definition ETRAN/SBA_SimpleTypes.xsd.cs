namespace SBA.ETRANObligation.Definition.ETRAN {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    public sealed class SBA_SimpleTypes : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:simpleType name=""SBA_ACHAcctType"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
      <xs:enumeration value="""" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""G"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionInsertOnly"">
    <xs:restriction base=""xs:string"">
      <xs:minLength value=""6"" />
      <xs:maxLength value=""6"" />
      <xs:enumeration value=""insert"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionsAll"">
    <xs:restriction base=""xs:string"">
      <xs:minLength value=""4"" />
      <xs:maxLength value=""6"" />
      <xs:enumeration value=""delete"" />
      <xs:enumeration value=""insert"" />
      <xs:enumeration value=""save"" />
      <xs:enumeration value=""update"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionsInsertOrUpdate"">
    <xs:restriction base=""xs:string"">
      <xs:minLength value=""4"" />
      <xs:maxLength value=""6"" />
      <xs:enumeration value=""insert"" />
      <xs:enumeration value=""save"" />
      <xs:enumeration value=""update"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ActionUpdateOnly"">
    <xs:restriction base=""xs:string"">
      <xs:minLength value=""6"" />
      <xs:maxLength value=""6"" />
      <xs:enumeration value=""update"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_AppraisedOrBookValue"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
      <xs:enumeration value="""" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_BusPerInd"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_CountyCode"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""(\d{3})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Dec3v2"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,3}[.]{0,1}\d{0,2}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Dec3v3"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,3}[.]{0,1}\d{0,3}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ExactNum1"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(\d{1})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ExactNum2"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(\d{2})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ExactNum3"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(\d{3})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ExactNum4"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(\d{4})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ExactNum5"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(\d{5})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ExactNum6"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(\d{6})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ExactNum7"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(\d{7})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ExactNum8"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(\d{8})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ExactNum9"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(\d{9})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ExactNum10"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(\d{10})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_FixVarInd"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
      <xs:enumeration value="""" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""V"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Gender"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
      <xs:enumeration value="""" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""F"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ListAlpha"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""([A-Za-z]+(,[A-Za-z]+)*){0,1}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ListAlpha1"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""([A-Za-z](,[A-Za-z])*){0,1}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ListAlpha2"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""([A-Za-z]{2}(,[A-Za-z]{2})*){0,1}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ListNum"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""(\d+(,\d+)*){0,1}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ListNum1"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""(\d(,\d)*){0,1}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ListNum2"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""(\d{2}(,\d{2})*){0,1}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Num"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d*"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Num1"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,1}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Num2"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,2}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Num3"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,3}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Num4"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,4}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Num5"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,5}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Num6"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,6}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Num7"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,7}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Num8"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,8}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Num9"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,9}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Num10"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,10}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Money"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""(-?\d+(.\d{2})?)?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_PaymentType"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
      <xs:enumeration value="""" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_RuralUrbanInd"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
      <xs:enumeration value="""" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_StateCode"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""2"" />
      <xs:enumeration value="""" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""AK"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""AZ"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""FL"" />
      <xs:enumeration value=""GA"" />
      <xs:enumeration value=""GU"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IL"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""KS"" />
      <xs:enumeration value=""KY"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MH"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""FM"" />
      <xs:enumeration value=""MN"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NV"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""NJ"" />
      <xs:enumeration value=""NM"" />
      <xs:enumeration value=""NY"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""ND"" />
      <xs:enumeration value=""OH"" />
      <xs:enumeration value=""OK"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""UT"" />
      <xs:enumeration value=""VT"" />
      <xs:enumeration value=""VI"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WV"" />
      <xs:enumeration value=""WI"" />
      <xs:enumeration value=""WY"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str1"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str2"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""2"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str3"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""3"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str4"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""4"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str5"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""5"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str6"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""6"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str7"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""7"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str8"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""8"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str9"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str10"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""10"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str12"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""12"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str16"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""16"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str20"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""20"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str24"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""24"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str30"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""30"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str40"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""40"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str50"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""50"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str60"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""60"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str80"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""80"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str150"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""150"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str160"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""160"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Str255"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""255"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_TaxId"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[0-1]{1}\d{9}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_TaxIdNew"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""[0-2]{1}\d{9}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ToBeDetermined"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""0"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_UnsignedByte"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{0,3}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_Year"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""(\d{4})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_YesNoInd"">
    <xs:restriction base=""xs:string"">
      <xs:maxLength value=""1"" />
      <xs:enumeration value="""" />
      <xs:enumeration value=""Y"" />
      <xs:enumeration value=""N"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ZipCode"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(\d{5})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_ZipPlus4"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""(\d{4})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandACHAcctType"">
    <xs:restriction base=""SBA_ACHAcctType"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandDec3v3"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{1,3}[.]{0,1}\d{0,3}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandDec"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{1,15}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandExactNum1"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{1}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandExactNum2"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{2}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandExactNum3"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{3}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandExactNum4"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{4}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandExactNum5"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{5}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandExactNum6"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{6}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandExactNum7"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{7}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandExactNum8"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{8}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandExactNum9"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{9}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandExactNum10"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{10}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandFixVarInd"">
    <xs:restriction base=""SBA_FixVarInd"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandGender"">
    <xs:restriction base=""SBA_Gender"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandInt"">
    <xs:restriction base=""xs:int"">
      <xs:pattern value=""\d{1,10}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandListAlpha"">
    <xs:restriction base=""SBA_ListAlpha"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandListAlpha1"">
    <xs:restriction base=""SBA_ListAlpha1"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandListAlpha2"">
    <xs:restriction base=""SBA_ListAlpha2"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandListNum"">
    <xs:restriction base=""SBA_ListNum"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandListNum1"">
    <xs:restriction base=""SBA_ListNum1"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandListNum2"">
    <xs:restriction base=""SBA_ListNum2"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandMoney"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""-?\d+(.\d{2})?"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandNum"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d+"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandNum1"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{1,1}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandNum2"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{1,2}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandNum3"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{1,3}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandNum4"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{1,4}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandNum5"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{1,5}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandNum6"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{1,6}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandNum7"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{1,7}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandNum8"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{1,8}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandNum9"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{1,9}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandNum10"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{1,10}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandRuralUrbanInd"">
    <xs:restriction base=""SBA_RuralUrbanInd"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandPaymentType"">
    <xs:restriction base=""SBA_PaymentType"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandShort"">
    <xs:restriction base=""xs:short"">
      <xs:pattern value=""\d{1,5}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStateCode"">
    <xs:restriction base=""SBA_StateCode"">
      <xs:minLength value=""2"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr"">
    <xs:restriction base=""xs:string"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr1"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr2"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""2"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr3"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""3"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr4"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""4"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr5"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""5"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr6"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""6"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr7"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""7"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr8"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""8"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr9"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr10"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""10"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr12"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""12"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr20"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""20"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr24"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""24"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr30"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""30"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr40"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""40"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr50"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""50"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr60"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""60"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr80"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""80"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr150"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""150"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr160"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""160"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandStr255"">
    <xs:restriction base=""SBA_MandStr"">
      <xs:maxLength value=""255"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandTaxId"">
    <xs:restriction base=""SBA_TaxId"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandTaxIdNew"">
    <xs:restriction base=""SBA_TaxIdNew"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandText"">
    <xs:restriction base=""xs:string"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandUnsignedByte"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{1,3}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandYear"">
    <xs:restriction base=""xs:string"">
      <xs:pattern value=""\d{4}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandYesNoInd"">
    <xs:restriction base=""SBA_YesNoInd"">
      <xs:minLength value=""1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandZipCode"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{5}"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""SBA_MandZipPlus4"">
    <xs:restriction base=""xs:decimal"">
      <xs:pattern value=""\d{4}"" />
    </xs:restriction>
  </xs:simpleType>
</xs:schema>";
        
        public SBA_SimpleTypes() {
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
