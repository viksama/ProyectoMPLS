﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace ProyectoMPLS.Data {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("dsUsuarios")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class dsUsuarios : global::System.Data.DataSet {
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public dsUsuarios() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected dsUsuarios(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            dsUsuarios cln = ((dsUsuarios)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars(bool initTable) {
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass() {
            this.DataSetName = "dsUsuarios";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/dsUsuarios.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            dsUsuarios ds = new dsUsuarios();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
    }
}
namespace ProyectoMPLS.Data.dsUsuariosTableAdapters {
    
    
    /// <summary>
    ///Represents the connection and commands used to retrieve and save data.
    ///</summary>
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public partial class Operaciones : global::System.ComponentModel.Component {
        
        private global::System.Data.IDbCommand[] _commandCollection;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected global::System.Data.IDbCommand[] CommandCollection {
            get {
                if ((this._commandCollection == null)) {
                    this.InitCommandCollection();
                }
                return this._commandCollection;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitCommandCollection() {
            this._commandCollection = new global::System.Data.IDbCommand[7];
            this._commandCollection[0] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Connection = new global::System.Data.SqlClient.SqlConnection(global::ProyectoMPLS.Properties.Settings.Default.ProyectoMPLSConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).CommandText = "dbo.spS_ExisteUsuario";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).CommandType = global::System.Data.CommandType.StoredProcedure;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[0])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cUserName", global::System.Data.SqlDbType.NVarChar, 30, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[1] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).Connection = new global::System.Data.SqlClient.SqlConnection(global::ProyectoMPLS.Properties.Settings.Default.ProyectoMPLSConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).CommandText = "dbo.spS_InsertarUsuario";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).CommandType = global::System.Data.CommandType.StoredProcedure;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cUserName", global::System.Data.SqlDbType.NVarChar, 30, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cEmail", global::System.Data.SqlDbType.NVarChar, 256, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@bEmailConfirmado", global::System.Data.SqlDbType.Bit, 1, global::System.Data.ParameterDirection.Input, 1, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[1])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cPasswordHash", global::System.Data.SqlDbType.NVarChar, 2147483647, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[2] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[2])).Connection = new global::System.Data.SqlClient.SqlConnection(global::ProyectoMPLS.Properties.Settings.Default.ProyectoMPLSConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[2])).CommandText = "dbo.spS_EsClaveValida";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[2])).CommandType = global::System.Data.CommandType.StoredProcedure;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[2])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[2])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cUserName", global::System.Data.SqlDbType.NVarChar, 30, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[2])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cPasswordHash", global::System.Data.SqlDbType.NVarChar, 2147483647, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[3] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[3])).Connection = new global::System.Data.SqlClient.SqlConnection(global::ProyectoMPLS.Properties.Settings.Default.ProyectoMPLSConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[3])).CommandText = "dbo.spT_BorrarProyecto";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[3])).CommandType = global::System.Data.CommandType.StoredProcedure;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[3])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[3])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@idProyecto", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.Input, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[4] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[4])).Connection = new global::System.Data.SqlClient.SqlConnection(global::ProyectoMPLS.Properties.Settings.Default.ProyectoMPLSConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[4])).CommandText = "dbo.spS_SelectHash";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[4])).CommandType = global::System.Data.CommandType.StoredProcedure;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[4])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[4])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cUserName", global::System.Data.SqlDbType.NVarChar, 30, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[5] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[5])).Connection = new global::System.Data.SqlClient.SqlConnection(global::ProyectoMPLS.Properties.Settings.Default.ProyectoMPLSConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[5])).CommandText = "dbo.spS_SelectEmail";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[5])).CommandType = global::System.Data.CommandType.StoredProcedure;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[5])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[5])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cUserName", global::System.Data.SqlDbType.NVarChar, 30, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            this._commandCollection[6] = new global::System.Data.SqlClient.SqlCommand();
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[6])).Connection = new global::System.Data.SqlClient.SqlConnection(global::ProyectoMPLS.Properties.Settings.Default.ProyectoMPLSConnectionString);
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[6])).CommandText = "dbo.spS_ActualizarUsuario";
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[6])).CommandType = global::System.Data.CommandType.StoredProcedure;
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[6])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@RETURN_VALUE", global::System.Data.SqlDbType.Int, 4, global::System.Data.ParameterDirection.ReturnValue, 10, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[6])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cUserName", global::System.Data.SqlDbType.NVarChar, 30, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[6])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cPasswordHash", global::System.Data.SqlDbType.NVarChar, 2147483647, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
            ((global::System.Data.SqlClient.SqlCommand)(this._commandCollection[6])).Parameters.Add(new global::System.Data.SqlClient.SqlParameter("@cEmail", global::System.Data.SqlDbType.NChar, 256, global::System.Data.ParameterDirection.Input, 0, 0, null, global::System.Data.DataRowVersion.Current, false, null, "", "", ""));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual object ExisteUsuario(string cUserName) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[0]));
            if ((cUserName == null)) {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[1].Value = ((string)(cUserName));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return null;
            }
            else {
                return ((object)(returnValue));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int InsertarUsuario(string cUserName, string cEmail, global::System.Nullable<bool> bEmailConfirmado, string cPasswordHash) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[1]));
            if ((cUserName == null)) {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[1].Value = ((string)(cUserName));
            }
            if ((cEmail == null)) {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[2].Value = ((string)(cEmail));
            }
            if ((bEmailConfirmado.HasValue == true)) {
                command.Parameters[3].Value = ((bool)(bEmailConfirmado.Value));
            }
            else {
                command.Parameters[3].Value = global::System.DBNull.Value;
            }
            if ((cPasswordHash == null)) {
                command.Parameters[4].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[4].Value = ((string)(cPasswordHash));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            int returnValue;
            try {
                returnValue = command.ExecuteNonQuery();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual object EsClaveValida(string cUserName, string cPasswordHash) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[2]));
            if ((cUserName == null)) {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[1].Value = ((string)(cUserName));
            }
            if ((cPasswordHash == null)) {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[2].Value = ((string)(cPasswordHash));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return null;
            }
            else {
                return ((object)(returnValue));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int BorrarProyecto(global::System.Nullable<int> idProyecto) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[3]));
            if ((idProyecto.HasValue == true)) {
                command.Parameters[1].Value = ((int)(idProyecto.Value));
            }
            else {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            int returnValue;
            try {
                returnValue = command.ExecuteNonQuery();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual object SelectHash(string cUserName) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[4]));
            if ((cUserName == null)) {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[1].Value = ((string)(cUserName));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return null;
            }
            else {
                return ((object)(returnValue));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual object SelectEmail(string cUserName) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[5]));
            if ((cUserName == null)) {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[1].Value = ((string)(cUserName));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return null;
            }
            else {
                return ((object)(returnValue));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
        public virtual int ActualizarUsuario(string cUserName, string cPasswordHash, string cEmail) {
            global::System.Data.SqlClient.SqlCommand command = ((global::System.Data.SqlClient.SqlCommand)(this.CommandCollection[6]));
            if ((cUserName == null)) {
                command.Parameters[1].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[1].Value = ((string)(cUserName));
            }
            if ((cPasswordHash == null)) {
                command.Parameters[2].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[2].Value = ((string)(cPasswordHash));
            }
            if ((cEmail == null)) {
                command.Parameters[3].Value = global::System.DBNull.Value;
            }
            else {
                command.Parameters[3].Value = ((string)(cEmail));
            }
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            int returnValue;
            try {
                returnValue = command.ExecuteNonQuery();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
    }
}

#pragma warning restore 1591