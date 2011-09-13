﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.4927
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace Proxy.ProxyPaqueteFinanciero
{ // 
// This source code was auto-generated by wsdl, Version=2.0.50727.3038.
// 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServicioPaqueteFinancieroSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Entidad))]
    public partial class ServicioPaqueteFinanciero : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
        private System.Threading.SendOrPostCallback AgregarPaqueteFinancieroOperationCompleted;
    
        /// <remarks/>
        public ServicioPaqueteFinanciero() {
            this.Url = "http://192.168.1.109/ServiciosCeclimi/ServicioPaqueteFinanciero.asmx";
        }
    
        /// <remarks/>
        public event AgregarPaqueteFinancieroCompletedEventHandler AgregarPaqueteFinancieroCompleted;
    
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AgregarPaqueteFinanciero", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AgregarPaqueteFinanciero(PaqueteFinanciero paqueteFinanciero) {
            object[] results = this.Invoke("AgregarPaqueteFinanciero", new object[] {
                                                                                        paqueteFinanciero});
            return ((int)(results[0]));
        }
    
        /// <remarks/>
        public System.IAsyncResult BeginAgregarPaqueteFinanciero(PaqueteFinanciero paqueteFinanciero, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AgregarPaqueteFinanciero", new object[] {
                                                                                 paqueteFinanciero}, callback, asyncState);
        }
    
        /// <remarks/>
        public int EndAgregarPaqueteFinanciero(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
    
        /// <remarks/>
        public void AgregarPaqueteFinancieroAsync(PaqueteFinanciero paqueteFinanciero) {
            this.AgregarPaqueteFinancieroAsync(paqueteFinanciero, null);
        }
    
        /// <remarks/>
        public void AgregarPaqueteFinancieroAsync(PaqueteFinanciero paqueteFinanciero, object userState) {
            if ((this.AgregarPaqueteFinancieroOperationCompleted == null)) {
                this.AgregarPaqueteFinancieroOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAgregarPaqueteFinancieroOperationCompleted);
            }
            this.InvokeAsync("AgregarPaqueteFinanciero", new object[] {
                                                                          paqueteFinanciero}, this.AgregarPaqueteFinancieroOperationCompleted, userState);
        }
    
        private void OnAgregarPaqueteFinancieroOperationCompleted(object arg) {
            if ((this.AgregarPaqueteFinancieroCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AgregarPaqueteFinancieroCompleted(this, new AgregarPaqueteFinancieroCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
    
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class PaqueteFinanciero : Entidad {
    
        private System.DateTime fechaPaqueteField;
    
        private System.DateTime fechaLimiteField;
    
        private Paciente pacienteField;
    
        /// <comentarios/>
        public System.DateTime FechaPaquete {
            get {
                return this.fechaPaqueteField;
            }
            set {
                this.fechaPaqueteField = value;
            }
        }
    
        /// <comentarios/>
        public System.DateTime FechaLimite {
            get {
                return this.fechaLimiteField;
            }
            set {
                this.fechaLimiteField = value;
            }
        }
    
        /// <comentarios/>
        public Paciente Paciente {
            get {
                return this.pacienteField;
            }
            set {
                this.pacienteField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Paciente : Persona {
    
        private System.DateTime fechaIngresoField;
    
        private string telefonoMovilField;
    
        /// <comentarios/>
        public System.DateTime FechaIngreso {
            get {
                return this.fechaIngresoField;
            }
            set {
                this.fechaIngresoField = value;
            }
        }
    
        /// <comentarios/>
        public string TelefonoMovil {
            get {
                return this.telefonoMovilField;
            }
            set {
                this.telefonoMovilField = value;
            }
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Paciente))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Persona : Entidad {
    
        private long cedulaField;
    
        private string segundoNombreField;
    
        private string primerApellidoField;
    
        private string segundoApellidoField;
    
        private string telefonoField;
    
        private string correoField;
    
        /// <comentarios/>
        public long Cedula {
            get {
                return this.cedulaField;
            }
            set {
                this.cedulaField = value;
            }
        }
    
        /// <comentarios/>
        public string SegundoNombre {
            get {
                return this.segundoNombreField;
            }
            set {
                this.segundoNombreField = value;
            }
        }
    
        /// <comentarios/>
        public string PrimerApellido {
            get {
                return this.primerApellidoField;
            }
            set {
                this.primerApellidoField = value;
            }
        }
    
        /// <comentarios/>
        public string SegundoApellido {
            get {
                return this.segundoApellidoField;
            }
            set {
                this.segundoApellidoField = value;
            }
        }
    
        /// <comentarios/>
        public string Telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
            }
        }
    
        /// <comentarios/>
        public string Correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
            }
        }
    }

    /// <comentarios/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Persona))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Paciente))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PaqueteFinanciero))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class Entidad {
    
        private long idField;
    
        private string nombreField;
    
        /// <comentarios/>
        public long Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <comentarios/>
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void AgregarPaqueteFinancieroCompletedEventHandler(object sender, AgregarPaqueteFinancieroCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AgregarPaqueteFinancieroCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
        private object[] results;
    
        internal AgregarPaqueteFinancieroCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
            this.results = results;
            }
    
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}