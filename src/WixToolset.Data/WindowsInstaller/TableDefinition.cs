// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data.WindowsInstaller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    /// <summary>
    /// Definition of a table in a database.
    /// </summary>
    public sealed class TableDefinition : IComparable<TableDefinition>
    {
        /// <summary>
        /// Tracks the maximum number of columns supported in a real table.
        /// This is a Windows Installer limitation.
        /// </summary>
        public const int MaxColumnsInRealTable = 32;

        /// <summary>
        /// Creates a table definition.
        /// </summary>
        /// <param name="name">Name of table to create.</param>
        /// <param name="columns">Column definitions for the table.</param>
        /// <param name="unreal">Flag if table is unreal.</param>
        public TableDefinition(string name, IEnumerable<ColumnDefinition> columns, bool unreal = false)
        {
            this.Name = name;
            this.TupleDefinitionName = name;
            this.Unreal = unreal;
            this.Columns = columns.ToArray();
        }

        /// <summary>
        /// Creates a table definition.
        /// </summary>
        /// <param name="name">Name of table to create.</param>
        /// <param name="tupleDefinitionName">Optional name of tuple definition for this table.</param>
        /// <param name="columns">Column definitions for the table.</param>
        /// <param name="unreal">Flag if table is unreal.</param>
        public TableDefinition(string name, string tupleDefinitionName, IEnumerable<ColumnDefinition> columns, bool unreal = false) : this(name, columns, unreal)
        {
            this.TupleDefinitionName = tupleDefinitionName ?? name;
        }

        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>Name of the table.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the name of the tuple definition associated with this table.
        /// </summary>
        /// <value>Name of the tuple definition.</value>
        public string TupleDefinitionName { get; private set; }

        /// <summary>
        /// Gets if the table is unreal.
        /// </summary>
        /// <value>Flag if table is unreal.</value>
        public bool Unreal { get; private set; }

        /// <summary>
        /// Gets the collection of column definitions for this table.
        /// </summary>
        /// <value>Collection of column definitions for this table.</value>
        public ColumnDefinition[] Columns { get; private set; }

        /// <summary>
        /// Gets the column definition in the table by index.
        /// </summary>
        /// <param name="columnIndex">Index of column to locate.</param>
        /// <value>Column definition in the table by index.</value>
        public ColumnDefinition this[int columnIndex] => this.Columns[columnIndex];

        /// <summary>
        /// Compares this table definition to another table definition.
        /// </summary>
        /// <remarks>
        /// Only Windows Installer traits are compared, allowing for updates to WiX-specific table definitions.
        /// </remarks>
        /// <param name="updated">The updated <see cref="TableDefinition"/> to compare with this target definition.</param>
        /// <returns>0 if the tables' core properties are the same; otherwise, non-0.</returns>
        public int CompareTo(TableDefinition updated)
        {
            // by definition, this object is greater than null
            if (null == updated)
            {
                return 1;
            }

            // compare the table names
            var ret = String.Compare(this.Name, updated.Name, StringComparison.Ordinal);

            // compare the column count
            if (0 == ret)
            {
                // transforms can only add columns
                ret = Math.Min(0, updated.Columns.Length - this.Columns.Length);

                // compare name, type, and length of each column
                for (var i = 0; 0 == ret && this.Columns.Length > i; i++)
                {
                    var thisColumnDef = this.Columns[i];
                    var updatedColumnDef = updated.Columns[i];

                    // Igmore unreal columns when comparing table definitions.
                    if (thisColumnDef.Unreal || updatedColumnDef.Unreal)
                    {
                        continue;
                    }

                    ret = thisColumnDef.CompareTo(updatedColumnDef);
                }
            }

            return ret;
        }

        /// <summary>
        /// Parses table definition from xml reader.
        /// </summary>
        /// <param name="reader">Reader to get data from.</param>
        /// <returns>The TableDefintion represented by the Xml.</returns>
        internal static TableDefinition Read(XmlReader reader)
        {
            var empty = reader.IsEmptyElement;
            string name = null;
            string tupleDefinitionName = null;
            var unreal = false;
            var bootstrapperApplicationData = false;

            while (reader.MoveToNextAttribute())
            {
                switch (reader.LocalName)
                {
                    case "name":
                        name = reader.Value;
                        break;
                    case "tupleDefinitionName":
                        tupleDefinitionName = reader.Value;
                        break;
                    case "unreal":
                        unreal = reader.Value.Equals("yes");
                        break;
                }
            }

            if (null == name)
            {
                throw new XmlException();
            }

            var columns = new List<ColumnDefinition>();
            var hasPrimaryKeyColumn = false;

            // parse the child elements
            if (!empty)
            {
                var done = false;

                while (!done && reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            switch (reader.LocalName)
                            {
                                case "columnDefinition":
                                    var columnDefinition = ColumnDefinition.Read(reader);
                                    columns.Add(columnDefinition);

                                    if (columnDefinition.PrimaryKey)
                                    {
                                        hasPrimaryKeyColumn = true;
                                    }
                                    break;
                                default:
                                    throw new XmlException();
                            }
                            break;
                        case XmlNodeType.EndElement:
                            done = true;
                            break;
                    }
                }

                if (!unreal && !bootstrapperApplicationData && !hasPrimaryKeyColumn)
                {
                    throw new WixException(ErrorMessages.RealTableMissingPrimaryKeyColumn(SourceLineNumber.CreateFromUri(reader.BaseURI), name));
                }

                if (!done)
                {
                    throw new XmlException();
                }
            }

            return new TableDefinition(name, tupleDefinitionName, columns.ToArray(), unreal);
        }

        /// <summary>
        /// Persists an output in an XML format.
        /// </summary>
        /// <param name="writer">XmlWriter where the Output should persist itself as XML.</param>
        internal void Write(XmlWriter writer)
        {
            writer.WriteStartElement("tableDefinition", TableDefinitionCollection.XmlNamespaceUri);

            writer.WriteAttributeString("name", this.Name);

            if (this.Unreal)
            {
                writer.WriteAttributeString("unreal", "yes");
            }

            foreach (var columnDefinition in this.Columns)
            {
                columnDefinition.Write(writer);
            }

            writer.WriteEndElement();
        }
    }
}
