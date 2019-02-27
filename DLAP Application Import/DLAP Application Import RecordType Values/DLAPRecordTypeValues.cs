// ------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
// ------------------------------------------------------------------------------

namespace DLAPApplicationImportRecordTypeValues
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Xml;
    using System.Collections.Generic;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://SBA.gov/DLAPApplicationImport.DLAPRecordTypeValues")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://SBA.gov/DLAPApplicationImport.DLAPRecordTypeValues", IsNullable = false)]
    public partial class RecordTypeValues
    {
        #region Private fields
        private string _business_Loan_Application;

        private string _eIDL_Application;

        private string _home_Loan_Application;

        private string _new_Read_Only_Application;

        private string _default_Applicant;

        private string _new_Read_Only_Applicant;

        private string _affiliate_Applicant;

        private string _business_Entity_Applicant;

        private string _business_Owner_Applicant;
        #endregion

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Business_Loan_Application
        {
            get
            {
                return this._business_Loan_Application;
            }
            set
            {
                this._business_Loan_Application = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EIDL_Application
        {
            get
            {
                return this._eIDL_Application;
            }
            set
            {
                this._eIDL_Application = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Home_Loan_Application
        {
            get
            {
                return this._home_Loan_Application;
            }
            set
            {
                this._home_Loan_Application = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string New_Read_Only_Application
        {
            get
            {
                return this._new_Read_Only_Application;
            }
            set
            {
                this._new_Read_Only_Application = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Default_Applicant
        {
            get
            {
                return this._default_Applicant;
            }
            set
            {
                this._default_Applicant = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string New_Read_Only_Applicant
        {
            get
            {
                return this._new_Read_Only_Applicant;
            }
            set
            {
                this._new_Read_Only_Applicant = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Affiliate_Applicant
        {
            get
            {
                return this._affiliate_Applicant;
            }
            set
            {
                this._affiliate_Applicant = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Business_Entity_Applicant
        {
            get
            {
                return this._business_Entity_Applicant;
            }
            set
            {
                this._business_Entity_Applicant = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Business_Owner_Applicant
        {
            get
            {
                return this._business_Owner_Applicant;
            }
            set
            {
                this._business_Owner_Applicant = value;
            }
        }
    }
}