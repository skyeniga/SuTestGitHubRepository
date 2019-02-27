namespace Application_Import_Logic.Debts_Expenses__c {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Application_Import_Definition.HomeDisasterLoanApplicationCanonical", typeof(global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Salesforce_Application_Import_Definition_XSD.CDataServiceDebts_Expenses__c+parameters", typeof(global::Salesforce_Application_Import_Definition_XSD.CDataServiceDebts_Expenses__c.parameters))]
    public sealed class MakeSalesForceDebts_Expenses__cRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://SBA.ODA.Gov/CanonicalApplication"" xmlns:ns0=""http://sba-oda/DLAP/Debts_Expenses__c"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Application"" />
  </xsl:template>
  <xsl:template match=""/s0:Application"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringSize(string(Debts/RentedProperty/ARE_LANDLORD_NAME/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalGt(string($var:v1) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringSize(string(Debts/RentedProperty/MailingAddress/MAR_ADDRESS1/text()))"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:LogicalGt(string($var:v3) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringSize(string(Debts/RentedProperty/MailingAddress/MAR_ADDRESS2/text()))"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalGt(string($var:v5) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringSize(string(Debts/RentedProperty/MailingAddress/MAR_CITY/text()))"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:LogicalGt(string($var:v7) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v9"" select=""userCSharp:StringSize(string(Debts/RentedProperty/MailingAddress/MAR_STATE_CD/text()))"" />
    <xsl:variable name=""var:v10"" select=""userCSharp:LogicalGt(string($var:v9) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v11"" select=""userCSharp:StringSize(string(Debts/RentedProperty/MailingAddress/MAR_ZIP/text()))"" />
    <xsl:variable name=""var:v12"" select=""userCSharp:LogicalGt(string($var:v11) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v13"" select=""userCSharp:StringSize(string(Debts/RentedProperty/MailingAddress/MAR_COUNTY/text()))"" />
    <xsl:variable name=""var:v14"" select=""userCSharp:LogicalGt(string($var:v13) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v15"" select=""userCSharp:LogicalOr(string($var:v2) , string($var:v4) , string($var:v6) , string($var:v8) , string($var:v10) , string($var:v12) , string($var:v14))"" />
    <xsl:variable name=""var:v83"" select=""userCSharp:LogicalExistence(boolean(Debts/NoDebts))"" />
    <xsl:variable name=""var:v84"" select=""userCSharp:StringLowerCase(string(Debts/NoDebts/text()))"" />
    <xsl:variable name=""var:v85"" select=""userCSharp:LogicalEq(string($var:v84) , &quot;true&quot;)"" />
    <xsl:variable name=""var:v86"" select=""string(Debts/NoDebts/text())"" />
    <xsl:variable name=""var:v87"" select=""userCSharp:StringSize($var:v86)"" />
    <xsl:variable name=""var:v88"" select=""userCSharp:LogicalGt(string($var:v87) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v89"" select=""userCSharp:LogicalAnd(string($var:v83) , string($var:v85) , string($var:v88))"" />
    <ns0:parameters>
      <ns0:sync>
        <xsl:if test=""$var:v15"">
          <xsl:variable name=""var:v16"" select=""userCSharp:LogicalExistence(boolean(Debts/RentedProperty/ARE_LANDLORD_NAME))"" />
          <xsl:variable name=""var:v18"" select=""userCSharp:LogicalExistence(boolean(Debts/RentedProperty/MailingAddress/MAR_ADDRESS1))"" />
          <xsl:variable name=""var:v30"" select=""userCSharp:LogicalExistence(boolean(Debts/RentedProperty/MailingAddress/MAR_CITY))"" />
          <xsl:variable name=""var:v32"" select=""userCSharp:LogicalExistence(boolean(Debts/RentedProperty/MailingAddress/MAR_STATE_CD))"" />
          <xsl:variable name=""var:v34"" select=""userCSharp:LogicalExistence(boolean(Debts/RentedProperty/MailingAddress/MAR_ZIP))"" />
          <xsl:variable name=""var:v36"" select=""userCSharp:LogicalExistence(boolean(Debts/RentedProperty/MailingAddress/MAR_COUNTY))"" />
          <xsl:variable name=""var:v38"" select=""userCSharp:LogicalExistence(boolean(Debts/RentedProperty/ARE_RENTLEASE_AMT))"" />
          <xsl:variable name=""var:v40"" select=""string(Debts/RentedProperty/ARE_LANDLORD_NAME/text())"" />
          <xsl:variable name=""var:v41"" select=""userCSharp:StringSize($var:v40)"" />
          <xsl:variable name=""var:v42"" select=""userCSharp:LogicalGt(string($var:v41) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v43"" select=""string(Debts/RentedProperty/MailingAddress/MAR_ADDRESS1/text())"" />
          <xsl:variable name=""var:v44"" select=""userCSharp:StringSize($var:v43)"" />
          <xsl:variable name=""var:v45"" select=""userCSharp:LogicalGt(string($var:v44) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v46"" select=""string(Debts/RentedProperty/MailingAddress/MAR_ADDRESS2/text())"" />
          <xsl:variable name=""var:v47"" select=""userCSharp:StringSize($var:v46)"" />
          <xsl:variable name=""var:v48"" select=""userCSharp:LogicalGt(string($var:v47) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v49"" select=""string(Debts/RentedProperty/MailingAddress/MAR_CITY/text())"" />
          <xsl:variable name=""var:v50"" select=""userCSharp:StringSize($var:v49)"" />
          <xsl:variable name=""var:v51"" select=""userCSharp:LogicalGt(string($var:v50) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v52"" select=""string(Debts/RentedProperty/MailingAddress/MAR_STATE_CD/text())"" />
          <xsl:variable name=""var:v53"" select=""userCSharp:StringSize($var:v52)"" />
          <xsl:variable name=""var:v54"" select=""userCSharp:LogicalGt(string($var:v53) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v55"" select=""string(Debts/RentedProperty/MailingAddress/MAR_ZIP/text())"" />
          <xsl:variable name=""var:v56"" select=""userCSharp:StringSize($var:v55)"" />
          <xsl:variable name=""var:v57"" select=""userCSharp:LogicalGt(string($var:v56) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v58"" select=""string(Debts/RentedProperty/MailingAddress/MAR_COUNTY/text())"" />
          <xsl:variable name=""var:v59"" select=""userCSharp:StringSize($var:v58)"" />
          <xsl:variable name=""var:v60"" select=""userCSharp:LogicalGt(string($var:v59) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v61"" select=""userCSharp:LogicalOr(string($var:v42) , string($var:v45) , string($var:v48) , string($var:v51) , string($var:v54) , string($var:v57) , string($var:v60))"" />
          <xsl:variable name=""var:v62"" select=""userCSharp:LogicalEq(string($var:v38) , string($var:v61))"" />
          <ns0:after>
            <ns0:Debts_Expenses__c>
              <xsl:attribute name=""Application__c"">
                <xsl:value-of select=""SalesForceApplication__cID/text()"" />
              </xsl:attribute>
              <xsl:if test=""string($var:v16)='true'"">
                <xsl:variable name=""var:v17"" select=""Debts/RentedProperty/ARE_LANDLORD_NAME/text()"" />
                <xsl:attribute name=""Landlord_Name__c"">
                  <xsl:value-of select=""$var:v17"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""string($var:v18)='true'"">
                <xsl:variable name=""var:v19"" select=""string(Debts/RentedProperty/MailingAddress/MAR_ADDRESS1/text())"" />
                <xsl:variable name=""var:v20"" select=""userCSharp:StringTrimRight($var:v19)"" />
                <xsl:variable name=""var:v21"" select=""userCSharp:LogicalExistence(boolean(Debts/RentedProperty/MailingAddress/MAR_ADDRESS2))"" />
                <xsl:if test=""string($var:v21)='true'"">
                  <xsl:variable name=""var:v22"" select=""Debts/RentedProperty/MailingAddress/MAR_ADDRESS2/text()"" />
                  <xsl:variable name=""var:v23"" select=""userCSharp:StringConcat(string($var:v20) , &quot; &quot; , string($var:v22))"" />
                  <xsl:variable name=""var:v24"" select=""userCSharp:StringSize(string($var:v23))"" />
                  <xsl:variable name=""var:v25"" select=""userCSharp:LogicalGt(string($var:v24) , &quot;2&quot;)"" />
                  <xsl:if test=""string($var:v25)='true'"">
                    <xsl:variable name=""var:v26"" select=""boolean(Debts/RentedProperty/MailingAddress/MAR_ADDRESS1)"" />
                    <xsl:variable name=""var:v27"" select=""userCSharp:LogicalExistence($var:v26)"" />
                    <xsl:if test=""string($var:v27)='true'"">
                      <xsl:variable name=""var:v28"" select=""boolean(Debts/RentedProperty/MailingAddress/MAR_ADDRESS2)"" />
                      <xsl:variable name=""var:v29"" select=""userCSharp:LogicalExistence($var:v28)"" />
                      <xsl:if test=""string($var:v29)='true'"">
                        <xsl:attribute name=""Rental_Property_Address__c"">
                          <xsl:value-of select=""$var:v23"" />
                        </xsl:attribute>
                      </xsl:if>
                    </xsl:if>
                  </xsl:if>
                </xsl:if>
              </xsl:if>
              <xsl:if test=""string($var:v30)='true'"">
                <xsl:variable name=""var:v31"" select=""Debts/RentedProperty/MailingAddress/MAR_CITY/text()"" />
                <xsl:attribute name=""City__c"">
                  <xsl:value-of select=""$var:v31"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""string($var:v32)='true'"">
                <xsl:variable name=""var:v33"" select=""Debts/RentedProperty/MailingAddress/MAR_STATE_CD/text()"" />
                <xsl:attribute name=""State__c"">
                  <xsl:value-of select=""$var:v33"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""string($var:v34)='true'"">
                <xsl:variable name=""var:v35"" select=""Debts/RentedProperty/MailingAddress/MAR_ZIP/text()"" />
                <xsl:attribute name=""Zip_Code__c"">
                  <xsl:value-of select=""$var:v35"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""string($var:v36)='true'"">
                <xsl:variable name=""var:v37"" select=""Debts/RentedProperty/MailingAddress/MAR_COUNTY/text()"" />
                <xsl:attribute name=""County__c"">
                  <xsl:value-of select=""$var:v37"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""string($var:v38)='true'"">
                <xsl:variable name=""var:v39"" select=""Debts/RentedProperty/ARE_RENTLEASE_AMT/text()"" />
                <xsl:attribute name=""Monthly_Payment__c"">
                  <xsl:value-of select=""$var:v39"" />
                </xsl:attribute>
              </xsl:if>
              <xsl:if test=""string($var:v62)='true'"">
                <xsl:variable name=""var:v63"" select=""&quot;Rent&quot;"" />
                <xsl:attribute name=""Type_of_Debt__c"">
                  <xsl:value-of select=""$var:v63"" />
                </xsl:attribute>
              </xsl:if>
            </ns0:Debts_Expenses__c>
          </ns0:after>
        </xsl:if>
        <xsl:for-each select=""Debts/RealEstateTax"">
          <xsl:variable name=""var:v64"" select=""userCSharp:StringSize(string(Frequency/text()))"" />
          <xsl:variable name=""var:v65"" select=""userCSharp:LogicalGt(string($var:v64) , &quot;1&quot;)"" />
          <xsl:variable name=""var:v66"" select=""userCSharp:StringSize(string(Amount/text()))"" />
          <xsl:variable name=""var:v67"" select=""userCSharp:LogicalGt(string($var:v66) , &quot;1&quot;)"" />
          <xsl:variable name=""var:v68"" select=""userCSharp:LogicalOr(string($var:v65) , string($var:v67))"" />
          <xsl:if test=""$var:v68"">
            <xsl:variable name=""var:v69"" select=""string(Frequency/text())"" />
            <xsl:variable name=""var:v70"" select=""userCSharp:LogicalEq($var:v69 , &quot;ANNUALLY&quot;)"" />
            <xsl:variable name=""var:v73"" select=""userCSharp:LogicalNot(string($var:v70))"" />
            <xsl:variable name=""var:v75"" select=""userCSharp:StringSize($var:v69)"" />
            <xsl:variable name=""var:v76"" select=""userCSharp:LogicalGt(string($var:v75) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v77"" select=""string(Amount/text())"" />
            <xsl:variable name=""var:v78"" select=""userCSharp:StringSize($var:v77)"" />
            <xsl:variable name=""var:v79"" select=""userCSharp:LogicalGt(string($var:v78) , &quot;1&quot;)"" />
            <xsl:variable name=""var:v80"" select=""userCSharp:LogicalOr(string($var:v76) , string($var:v79))"" />
            <ns0:after>
              <ns0:Debts_Expenses__c>
                <xsl:attribute name=""Application__c"">
                  <xsl:value-of select=""../../SalesForceApplication__cID/text()"" />
                </xsl:attribute>
                <xsl:if test=""string($var:v70)='true'"">
                  <xsl:variable name=""var:v71"" select=""Amount/text()"" />
                  <xsl:variable name=""var:v72"" select=""userCSharp:MathDivide(string($var:v71) , &quot;12&quot;)"" />
                  <xsl:attribute name=""Monthly_Payment__c"">
                    <xsl:value-of select=""$var:v72"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v73)='true'"">
                  <xsl:variable name=""var:v74"" select=""Amount/text()"" />
                  <xsl:attribute name=""Monthly_Payment__c"">
                    <xsl:value-of select=""$var:v74"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v80)='true'"">
                  <xsl:variable name=""var:v81"" select=""&quot;Real Estate Taxes&quot;"" />
                  <xsl:attribute name=""Type_of_Debt__c"">
                    <xsl:value-of select=""$var:v81"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v80)='true'"">
                  <xsl:variable name=""var:v82"" select=""&quot;true&quot;"" />
                  <xsl:attribute name=""Active__c"">
                    <xsl:value-of select=""$var:v82"" />
                  </xsl:attribute>
                </xsl:if>
              </ns0:Debts_Expenses__c>
            </ns0:after>
          </xsl:if>
        </xsl:for-each>
        <xsl:if test=""$var:v89"">
          <xsl:variable name=""var:v90"" select=""boolean(Debts/NoDebts)"" />
          <xsl:variable name=""var:v91"" select=""userCSharp:LogicalExistence($var:v90)"" />
          <xsl:variable name=""var:v92"" select=""userCSharp:StringLowerCase($var:v86)"" />
          <xsl:variable name=""var:v93"" select=""userCSharp:LogicalEq(string($var:v92) , &quot;true&quot;)"" />
          <xsl:variable name=""var:v94"" select=""userCSharp:LogicalAnd(string($var:v91) , string($var:v93) , string($var:v88))"" />
          <ns0:after>
            <ns0:Debts_Expenses__c>
              <xsl:attribute name=""Application__c"">
                <xsl:value-of select=""SalesForceApplication__cID/text()"" />
              </xsl:attribute>
              <xsl:if test=""string($var:v94)='true'"">
                <xsl:variable name=""var:v95"" select=""Debts/NoDebts/text()"" />
                <xsl:attribute name=""No_Debts__c"">
                  <xsl:value-of select=""$var:v95"" />
                </xsl:attribute>
              </xsl:if>
            </ns0:Debts_Expenses__c>
          </ns0:after>
        </xsl:if>
        <xsl:for-each select=""Debts/HazardInsurance"">
          <xsl:variable name=""var:v96"" select=""string(Amount/text())"" />
          <xsl:variable name=""var:v97"" select=""userCSharp:StringSize($var:v96)"" />
          <xsl:variable name=""var:v98"" select=""userCSharp:LogicalGt(string($var:v97) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v99"" select=""string(Frequency/text())"" />
          <xsl:variable name=""var:v100"" select=""userCSharp:StringSize($var:v99)"" />
          <xsl:variable name=""var:v101"" select=""userCSharp:LogicalGt(string($var:v100) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v102"" select=""userCSharp:LogicalOr(string($var:v98) , string($var:v101))"" />
          <xsl:if test=""$var:v102"">
            <xsl:variable name=""var:v103"" select=""userCSharp:LogicalEq($var:v99 , &quot;ANNUALLY&quot;)"" />
            <xsl:variable name=""var:v106"" select=""userCSharp:LogicalNot(string($var:v103))"" />
            <ns0:after>
              <ns0:Debts_Expenses__c>
                <xsl:attribute name=""Application__c"">
                  <xsl:value-of select=""../../SalesForceApplication__cID/text()"" />
                </xsl:attribute>
                <xsl:if test=""string($var:v103)='true'"">
                  <xsl:variable name=""var:v104"" select=""Amount/text()"" />
                  <xsl:variable name=""var:v105"" select=""userCSharp:MathDivide(string($var:v104) , &quot;12&quot;)"" />
                  <xsl:attribute name=""Monthly_Payment__c"">
                    <xsl:value-of select=""$var:v105"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v106)='true'"">
                  <xsl:variable name=""var:v107"" select=""Amount/text()"" />
                  <xsl:attribute name=""Monthly_Payment__c"">
                    <xsl:value-of select=""$var:v107"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v102)='true'"">
                  <xsl:variable name=""var:v108"" select=""&quot;Hazard Insurance&quot;"" />
                  <xsl:attribute name=""Type_of_Debt__c"">
                    <xsl:value-of select=""$var:v108"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v102)='true'"">
                  <xsl:variable name=""var:v109"" select=""&quot;true&quot;"" />
                  <xsl:attribute name=""Active__c"">
                    <xsl:value-of select=""$var:v109"" />
                  </xsl:attribute>
                </xsl:if>
              </ns0:Debts_Expenses__c>
            </ns0:after>
          </xsl:if>
        </xsl:for-each>
        <xsl:for-each select=""Debts/CondoHoaFee"">
          <xsl:variable name=""var:v110"" select=""string(Amount/text())"" />
          <xsl:variable name=""var:v111"" select=""userCSharp:StringSize($var:v110)"" />
          <xsl:variable name=""var:v112"" select=""userCSharp:LogicalGt(string($var:v111) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v113"" select=""string(Frequency/text())"" />
          <xsl:variable name=""var:v114"" select=""userCSharp:StringSize($var:v113)"" />
          <xsl:variable name=""var:v115"" select=""userCSharp:LogicalGt(string($var:v114) , &quot;0&quot;)"" />
          <xsl:variable name=""var:v116"" select=""userCSharp:LogicalOr(string($var:v112) , string($var:v115))"" />
          <xsl:if test=""$var:v116"">
            <xsl:variable name=""var:v117"" select=""userCSharp:LogicalEq($var:v113 , &quot;ANNUALLY&quot;)"" />
            <xsl:variable name=""var:v120"" select=""userCSharp:LogicalNot(string($var:v117))"" />
            <ns0:after>
              <ns0:Debts_Expenses__c>
                <xsl:attribute name=""Application__c"">
                  <xsl:value-of select=""../../SalesForceApplication__cID/text()"" />
                </xsl:attribute>
                <xsl:if test=""string($var:v117)='true'"">
                  <xsl:variable name=""var:v118"" select=""Amount/text()"" />
                  <xsl:variable name=""var:v119"" select=""userCSharp:MathDivide(string($var:v118) , &quot;12&quot;)"" />
                  <xsl:attribute name=""Monthly_Payment__c"">
                    <xsl:value-of select=""$var:v119"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v120)='true'"">
                  <xsl:variable name=""var:v121"" select=""Amount/text()"" />
                  <xsl:attribute name=""Monthly_Payment__c"">
                    <xsl:value-of select=""$var:v121"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v116)='true'"">
                  <xsl:variable name=""var:v122"" select=""&quot;Condo/Assoc Fee&quot;"" />
                  <xsl:attribute name=""Type_of_Debt__c"">
                    <xsl:value-of select=""$var:v122"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v116)='true'"">
                  <xsl:variable name=""var:v123"" select=""&quot;true&quot;"" />
                  <xsl:attribute name=""Active__c"">
                    <xsl:value-of select=""$var:v123"" />
                  </xsl:attribute>
                </xsl:if>
              </ns0:Debts_Expenses__c>
            </ns0:after>
          </xsl:if>
        </xsl:for-each>
        <xsl:for-each select=""Debts/OtherDebtColl"">
          <xsl:for-each select=""OtherDebt"">
            <xsl:variable name=""var:v124"" select=""userCSharp:StringSize(string(APB_LIABILITY_TYPE_CD/text()))"" />
            <xsl:variable name=""var:v125"" select=""userCSharp:LogicalGt(string($var:v124) , &quot;0&quot;)"" />
            <xsl:variable name=""var:v126"" select=""userCSharp:StringSize(string(APB_PMT_AMT/text()))"" />
            <xsl:variable name=""var:v127"" select=""userCSharp:LogicalGt(string($var:v126) , &quot;0&quot;)"" />
            <xsl:variable name=""var:v128"" select=""userCSharp:StringSize(string(APB_BALANCE_AMT/text()))"" />
            <xsl:variable name=""var:v129"" select=""userCSharp:LogicalGt(string($var:v128) , &quot;0&quot;)"" />
            <xsl:variable name=""var:v130"" select=""userCSharp:StringSize(string(APB_SECURED_INFO/text()))"" />
            <xsl:variable name=""var:v131"" select=""userCSharp:LogicalGt(string($var:v130) , &quot;0&quot;)"" />
            <xsl:variable name=""var:v132"" select=""userCSharp:StringSize(string(APB_CREDITOR_NAME/text()))"" />
            <xsl:variable name=""var:v133"" select=""userCSharp:LogicalGt(string($var:v132) , &quot;0&quot;)"" />
            <xsl:variable name=""var:v134"" select=""userCSharp:LogicalOr(string($var:v125) , string($var:v127) , string($var:v129) , string($var:v131) , string($var:v133))"" />
            <xsl:if test=""$var:v134"">
              <xsl:variable name=""var:v135"" select=""userCSharp:LogicalExistence(boolean(APB_CREDITOR_NAME))"" />
              <xsl:variable name=""var:v137"" select=""userCSharp:LogicalExistence(boolean(APB_PMT_AMT))"" />
              <xsl:variable name=""var:v139"" select=""userCSharp:LogicalExistence(boolean(APB_BALANCE_AMT))"" />
              <xsl:variable name=""var:v141"" select=""userCSharp:LogicalExistence(boolean(APB_SECURED_INFO))"" />
              <xsl:variable name=""var:v143"" select=""string(APB_LIABILITY_TYPE_CD/text())"" />
              <xsl:variable name=""var:v144"" select=""userCSharp:StringSize($var:v143)"" />
              <xsl:variable name=""var:v145"" select=""userCSharp:LogicalGt(string($var:v144) , &quot;0&quot;)"" />
              <ns0:after>
                <ns0:Debts_Expenses__c>
                  <xsl:attribute name=""Application__c"">
                    <xsl:value-of select=""../../../SalesForceApplication__cID/text()"" />
                  </xsl:attribute>
                  <xsl:if test=""string($var:v135)='true'"">
                    <xsl:variable name=""var:v136"" select=""APB_CREDITOR_NAME/text()"" />
                    <xsl:attribute name=""Name"">
                      <xsl:value-of select=""$var:v136"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v137)='true'"">
                    <xsl:variable name=""var:v138"" select=""APB_PMT_AMT/text()"" />
                    <xsl:attribute name=""Monthly_Payment__c"">
                      <xsl:value-of select=""$var:v138"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v139)='true'"">
                    <xsl:variable name=""var:v140"" select=""APB_BALANCE_AMT/text()"" />
                    <xsl:attribute name=""Balance__c"">
                      <xsl:value-of select=""$var:v140"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v141)='true'"">
                    <xsl:variable name=""var:v142"" select=""APB_SECURED_INFO/text()"" />
                    <xsl:attribute name=""How_Secured__c"">
                      <xsl:value-of select=""$var:v142"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v145)='true'"">
                    <xsl:variable name=""var:v146"" select=""APB_LIABILITY_TYPE_CD/text()"" />
                    <xsl:variable name=""var:v147"" select=""userCSharp:OtherDebits(string($var:v146))"" />
                    <xsl:attribute name=""Type_of_Debt__c"">
                      <xsl:value-of select=""$var:v147"" />
                    </xsl:attribute>
                  </xsl:if>
                </ns0:Debts_Expenses__c>
              </ns0:after>
            </xsl:if>
          </xsl:for-each>
        </xsl:for-each>
        <xsl:for-each select=""ExtraExpenseColl"">
          <xsl:for-each select=""Apl_Ext_Expense"">
            <xsl:variable name=""var:v148"" select=""userCSharp:StringSize(string(AEE_AMOUNT/text()))"" />
            <xsl:variable name=""var:v149"" select=""userCSharp:LogicalGt(string($var:v148) , &quot;0&quot;)"" />
            <xsl:variable name=""var:v150"" select=""userCSharp:StringSize(string(AEE_DESCRIPTION/text()))"" />
            <xsl:variable name=""var:v151"" select=""userCSharp:LogicalGt(string($var:v150) , &quot;0&quot;)"" />
            <xsl:variable name=""var:v152"" select=""userCSharp:LogicalOr(string($var:v149) , string($var:v151))"" />
            <xsl:if test=""$var:v152"">
              <xsl:variable name=""var:v153"" select=""userCSharp:LogicalExistence(boolean(AEE_AMOUNT))"" />
              <xsl:variable name=""var:v155"" select=""userCSharp:LogicalExistence(boolean(AEE_DESCRIPTION))"" />
              <xsl:variable name=""var:v157"" select=""string(AEE_DESCRIPTION/text())"" />
              <xsl:variable name=""var:v158"" select=""userCSharp:StringSize($var:v157)"" />
              <xsl:variable name=""var:v159"" select=""userCSharp:LogicalGt(string($var:v158) , &quot;0&quot;)"" />
              <ns0:after>
                <ns0:Debts_Expenses__c>
                  <xsl:attribute name=""Application__c"">
                    <xsl:value-of select=""../../SalesForceApplication__cID/text()"" />
                  </xsl:attribute>
                  <xsl:if test=""string($var:v153)='true'"">
                    <xsl:variable name=""var:v154"" select=""AEE_AMOUNT/text()"" />
                    <xsl:attribute name=""Monthly_Payment__c"">
                      <xsl:value-of select=""$var:v154"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v155)='true'"">
                    <xsl:variable name=""var:v156"" select=""AEE_DESCRIPTION/text()"" />
                    <xsl:attribute name=""Extraordinary_Expense_Description__c"">
                      <xsl:value-of select=""$var:v156"" />
                    </xsl:attribute>
                  </xsl:if>
                  <xsl:if test=""string($var:v159)='true'"">
                    <xsl:variable name=""var:v160"" select=""AEE_DESCRIPTION/text()"" />
                    <xsl:variable name=""var:v161"" select=""userCSharp:EXOtherDebits(string($var:v160))"" />
                    <xsl:attribute name=""Type_of_Debt__c"">
                      <xsl:value-of select=""$var:v161"" />
                    </xsl:attribute>
                  </xsl:if>
                </ns0:Debts_Expenses__c>
              </ns0:after>
            </xsl:if>
          </xsl:for-each>
        </xsl:for-each>
      </ns0:sync>
    </ns0:parameters>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public bool LogicalAnd(string param0, string param1, string param2)
{
	return ValToBool(param0) && ValToBool(param1) && ValToBool(param2);
	return false;
}


public bool LogicalExistence(bool val)
{
	return val;
}


public string StringLowerCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToLower(System.Globalization.CultureInfo.InvariantCulture);
}


public bool LogicalGt(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 > d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) > 0;
	}
	return ret;
}


public int StringSize(string str)
{
	if (str == null)
	{
		return 0;
	}
	return str.Length;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string StringTrimRight(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimEnd(null);
}


public bool LogicalOr(string param0, string param1, string param2, string param3, string param4, string param5, string param6)
{
	return ValToBool(param0) || ValToBool(param1) || ValToBool(param2) || ValToBool(param3) || ValToBool(param4) || ValToBool(param5) || ValToBool(param6);
	return false;
}


public bool LogicalOr(string param0, string param1)
{
	return ValToBool(param0) || ValToBool(param1);
	return false;
}


public string MathDivide(string val1, string val2)
{
	string retval = """";
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		if (d2 != 0)
		{
			double ret = d1 / d2;
			retval = ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
		}
	}
	return retval;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public bool LogicalOr(string param0, string param1, string param2, string param3, string param4)
{
	return ValToBool(param0) || ValToBool(param1) || ValToBool(param2) || ValToBool(param3) || ValToBool(param4);
	return false;
}


public string OtherDebits(string APB_LIABILITY_TYPE_CD)
    {          

                if (APB_LIABILITY_TYPE_CD == ""CREDIT_CARD_ODA"")
                { return ""Credit Card""; }
				
	else if (APB_LIABILITY_TYPE_CD == ""LOAN_ODA"")
                { return ""Loan""; }
				
	else if (APB_LIABILITY_TYPE_CD == ""I"")
                { return ""Installment""; }
				
	else if (APB_LIABILITY_TYPE_CD == ""U"")
                { return ""Unknown""; }

                else
                { return """"; }
    }




public string EXOtherDebits(string AEE_DESCRIPTION)
    {          

                if (AEE_DESCRIPTION == ""A_ODA"")
                { return ""Alimony""; }
				
	else if (AEE_DESCRIPTION == ""C_ODA"")
                { return ""Child Care""; }
				
	else if (AEE_DESCRIPTION == ""S_ODA"")
                { return ""Child Support""; }
				
	else if (AEE_DESCRIPTION == ""D_ODA"")
                { return ""Medical Costs""; }
				
	else if (AEE_DESCRIPTION == ""TUIT_MEDICAL_SCHOOL_ODA"")
                { return ""Tuition for schools required by medical disability""; }

                else
                { return """"; }
    }


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
        
        private const global::Application_Import_Definition.HomeDisasterLoanApplicationCanonical _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Salesforce_Application_Import_Definition_XSD.CDataServiceDebts_Expenses__c+parameters";
        
        private const global::Salesforce_Application_Import_Definition_XSD.CDataServiceDebts_Expenses__c.parameters _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Application_Import_Definition.HomeDisasterLoanApplicationCanonical";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Salesforce_Application_Import_Definition_XSD.CDataServiceDebts_Expenses__c+parameters";
                return _TrgSchemas;
            }
        }
    }
}
