﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web.ServicioW {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioW.ServicioSoap")]
    public interface ServicioSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarCategoria", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarCategoria();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarCategoriaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarCiudad", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarCiudad();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarCiudad", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarCiudadAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarEstado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarEstado();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarEstado", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarEstadoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarTipo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarTipo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarTipo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarTipoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarPublicacion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarPublicacion(web.ServicioW.clPublicacion objPublica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarPublicacion", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarPublicacionAsync(web.ServicioW.clPublicacion objPublica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarPublicaciones2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarPublicaciones2(web.ServicioW.clPublicacion objPubli);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarPublicaciones2", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarPublicaciones2Async(web.ServicioW.clPublicacion objPubli);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarPublicacion", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int mtdRegistrarPublicacion(web.ServicioW.clPublicacion objPublicacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarPublicacion", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mtdRegistrarPublicacionAsync(web.ServicioW.clPublicacion objPublicacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int mtdRegistrarUsuario(web.ServicioW.clUsuario objUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdRegistrarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mtdRegistrarUsuarioAsync(web.ServicioW.clUsuario objUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Login(string usuario, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<int> LoginAsync(string usuario, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imagenes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int Imagenes(string usuario, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Imagenes", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ImagenesAsync(string usuario, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarRol", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet mtdListarRol();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtdListarRol", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> mtdListarRolAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class clPublicacion : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idPublicacionField;
        
        private string nombreField;
        
        private float precioField;
        
        private string descripcionField;
        
        private string telefonoField;
        
        private string estratoField;
        
        private string direccionField;
        
        private int habitacionesField;
        
        private int idUsuarioField;
        
        private int idTipoField;
        
        private int idEstadoField;
        
        private int idCiudadField;
        
        private int idCategoriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int IdPublicacion {
            get {
                return this.idPublicacionField;
            }
            set {
                this.idPublicacionField = value;
                this.RaisePropertyChanged("IdPublicacion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("Nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public float Precio {
            get {
                return this.precioField;
            }
            set {
                this.precioField = value;
                this.RaisePropertyChanged("Precio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("Descripcion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("Telefono");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Estrato {
            get {
                return this.estratoField;
            }
            set {
                this.estratoField = value;
                this.RaisePropertyChanged("Estrato");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("Direccion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int Habitaciones {
            get {
                return this.habitacionesField;
            }
            set {
                this.habitacionesField = value;
                this.RaisePropertyChanged("Habitaciones");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int IdUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
                this.RaisePropertyChanged("IdUsuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public int IdTipo {
            get {
                return this.idTipoField;
            }
            set {
                this.idTipoField = value;
                this.RaisePropertyChanged("IdTipo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public int IdEstado {
            get {
                return this.idEstadoField;
            }
            set {
                this.idEstadoField = value;
                this.RaisePropertyChanged("IdEstado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public int IdCiudad {
            get {
                return this.idCiudadField;
            }
            set {
                this.idCiudadField = value;
                this.RaisePropertyChanged("IdCiudad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public int IdCategoria {
            get {
                return this.idCategoriaField;
            }
            set {
                this.idCategoriaField = value;
                this.RaisePropertyChanged("IdCategoria");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class clUsuario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idUsuarioField;
        
        private string nombreField;
        
        private string apellidoField;
        
        private string emailField;
        
        private string telefonoField;
        
        private string ciudadField;
        
        private string ubicacionField;
        
        private string contrasenaField;
        
        private int idRolField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int IdUsuario {
            get {
                return this.idUsuarioField;
            }
            set {
                this.idUsuarioField = value;
                this.RaisePropertyChanged("IdUsuario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("Nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
                this.RaisePropertyChanged("Apellido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("Email");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("Telefono");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Ciudad {
            get {
                return this.ciudadField;
            }
            set {
                this.ciudadField = value;
                this.RaisePropertyChanged("Ciudad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Ubicacion {
            get {
                return this.ubicacionField;
            }
            set {
                this.ubicacionField = value;
                this.RaisePropertyChanged("Ubicacion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Contrasena {
            get {
                return this.contrasenaField;
            }
            set {
                this.contrasenaField = value;
                this.RaisePropertyChanged("Contrasena");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int IdRol {
            get {
                return this.idRolField;
            }
            set {
                this.idRolField = value;
                this.RaisePropertyChanged("IdRol");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioSoapChannel : web.ServicioW.ServicioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioSoapClient : System.ServiceModel.ClientBase<web.ServicioW.ServicioSoap>, web.ServicioW.ServicioSoap {
        
        public ServicioSoapClient() {
        }
        
        public ServicioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet mtdListarCategoria() {
            return base.Channel.mtdListarCategoria();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarCategoriaAsync() {
            return base.Channel.mtdListarCategoriaAsync();
        }
        
        public System.Data.DataSet mtdListarCiudad() {
            return base.Channel.mtdListarCiudad();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarCiudadAsync() {
            return base.Channel.mtdListarCiudadAsync();
        }
        
        public System.Data.DataSet mtdListarEstado() {
            return base.Channel.mtdListarEstado();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarEstadoAsync() {
            return base.Channel.mtdListarEstadoAsync();
        }
        
        public System.Data.DataSet mtdListarTipo() {
            return base.Channel.mtdListarTipo();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarTipoAsync() {
            return base.Channel.mtdListarTipoAsync();
        }
        
        public System.Data.DataSet mtdListarPublicacion(web.ServicioW.clPublicacion objPublica) {
            return base.Channel.mtdListarPublicacion(objPublica);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarPublicacionAsync(web.ServicioW.clPublicacion objPublica) {
            return base.Channel.mtdListarPublicacionAsync(objPublica);
        }
        
        public System.Data.DataSet mtdListarPublicaciones2(web.ServicioW.clPublicacion objPubli) {
            return base.Channel.mtdListarPublicaciones2(objPubli);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarPublicaciones2Async(web.ServicioW.clPublicacion objPubli) {
            return base.Channel.mtdListarPublicaciones2Async(objPubli);
        }
        
        public int mtdRegistrarPublicacion(web.ServicioW.clPublicacion objPublicacion) {
            return base.Channel.mtdRegistrarPublicacion(objPublicacion);
        }
        
        public System.Threading.Tasks.Task<int> mtdRegistrarPublicacionAsync(web.ServicioW.clPublicacion objPublicacion) {
            return base.Channel.mtdRegistrarPublicacionAsync(objPublicacion);
        }
        
        public int mtdRegistrarUsuario(web.ServicioW.clUsuario objUsuario) {
            return base.Channel.mtdRegistrarUsuario(objUsuario);
        }
        
        public System.Threading.Tasks.Task<int> mtdRegistrarUsuarioAsync(web.ServicioW.clUsuario objUsuario) {
            return base.Channel.mtdRegistrarUsuarioAsync(objUsuario);
        }
        
        public int Login(string usuario, string contrasena) {
            return base.Channel.Login(usuario, contrasena);
        }
        
        public System.Threading.Tasks.Task<int> LoginAsync(string usuario, string contrasena) {
            return base.Channel.LoginAsync(usuario, contrasena);
        }
        
        public int Imagenes(string usuario, string contrasena) {
            return base.Channel.Imagenes(usuario, contrasena);
        }
        
        public System.Threading.Tasks.Task<int> ImagenesAsync(string usuario, string contrasena) {
            return base.Channel.ImagenesAsync(usuario, contrasena);
        }
        
        public System.Data.DataSet mtdListarRol() {
            return base.Channel.mtdListarRol();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> mtdListarRolAsync() {
            return base.Channel.mtdListarRolAsync();
        }
    }
}
