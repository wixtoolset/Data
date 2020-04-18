// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data.WindowsInstaller.Rows
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Specialization of a row for the Control table.
    /// </summary>
    public sealed class ControlRow : Row
    {
        /// <summary>
        /// Creates a Control row that belongs to a table.
        /// </summary>
        /// <param name="sourceLineNumbers">Original source lines for this row.</param>
        /// <param name="table">Table this Control row belongs to and should get its column definitions from.</param>
        public ControlRow(SourceLineNumber sourceLineNumbers, Table table) :
            base(sourceLineNumbers, table)
        {
        }

        public ControlRow(SourceLineNumber sourceLineNumbers, TableDefinition tableDefinition) :
            base(sourceLineNumbers, tableDefinition)
        {
        }

        /// <summary>
        /// Gets or sets the dialog of the Control row.
        /// </summary>
        /// <value>Primary key of the Control row.</value>
        public string Dialog
        {
            get { return (string)this.Fields[0].Data; }
            set { this.Fields[0].Data = value; }
        }

        /// <summary>
        /// Gets or sets the identifier for this Control row.
        /// </summary>
        /// <value>Identifier for this Control row.</value>
        public string Control
        {
            get { return (string)this.Fields[1].Data; }
            set { this.Fields[1].Data = value; }
        }

        /// <summary>
        /// Gets or sets the type of the control.
        /// </summary>
        /// <value>Name of the control.</value>
        [SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
        public string Type
        {
            get { return (string)this.Fields[2].Data; }
            set { this.Fields[2].Data = value; }
        }

        /// <summary>
        /// Gets or sets the X location of the control.
        /// </summary>
        /// <value>X location of the control.</value>
        public string X
        {
            get { return this.Fields[3].AsString(); }
            set { this.Fields[3].Data = value; }
        }

        /// <summary>
        /// Gets or sets the Y location of the control.
        /// </summary>
        /// <value>Y location of the control.</value>
        public string Y
        {
            get { return this.Fields[4].AsString(); }
            set { this.Fields[4].Data = value; }
        }

        /// <summary>
        /// Gets or sets the width of the control.
        /// </summary>
        /// <value>Width of the control.</value>
        public string Width
        {
            get { return this.Fields[5].AsString(); }
            set { this.Fields[5].Data = value; }
        }

        /// <summary>
        /// Gets or sets the height of the control.
        /// </summary>
        /// <value>Height of the control.</value>
        public string Height
        {
            get { return this.Fields[6].AsString(); }
            set { this.Fields[6].Data = value; }
        }

        /// <summary>
        /// Gets or sets the attributes for the control.
        /// </summary>
        /// <value>Attributes for the control.</value>
        public int Attributes
        {
            get { return (int)this.Fields[7].Data; }
            set { this.Fields[7].Data = value; }
        }

        /// <summary>
        /// Gets or sets the Property associated with the control.
        /// </summary>
        /// <value>Property associated with the control.</value>
        public string Property
        {
            get { return (string)this.Fields[8].Data; }
            set { this.Fields[8].Data = value; }
        }

        /// <summary>
        /// Gets or sets the text of the control.
        /// </summary>
        /// <value>Text of the control.</value>
        public string Text
        {
            get { return (string)this.Fields[9].Data; }
            set { this.Fields[9].Data = value; }
        }

        /// <summary>
        /// Gets or sets the next control.
        /// </summary>
        /// <value>Next control.</value>
        public string Next
        {
            get { return (string)this.Fields[10].Data; }
            set { this.Fields[10].Data = value; }
        }

        /// <summary>
        /// Gets or sets the help for the control.
        /// </summary>
        /// <value>Help for the control.</value>
        public string Help
        {
            get { return (string)this.Fields[11].Data; }
            set { this.Fields[11].Data = value; }
        }
    }
}
