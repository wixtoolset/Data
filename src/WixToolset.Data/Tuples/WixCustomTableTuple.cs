// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data
{
    using WixToolset.Data.Tuples;

    public static partial class TupleDefinitions
    {
        public static readonly IntermediateTupleDefinition WixCustomTable = new IntermediateTupleDefinition(
            TupleDefinitionType.WixCustomTable,
            new[]
            {
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.ColumnCount), IntermediateFieldType.Number),
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.ColumnNames), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.ColumnTypes), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.PrimaryKeys), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.MinValues), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.MaxValues), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.KeyTables), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.KeyColumns), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.Categories), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.Sets), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.Descriptions), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.Modularizations), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(WixCustomTableTupleFields.Unreal), IntermediateFieldType.Number),
            },
            typeof(WixCustomTableTuple));
    }
}

namespace WixToolset.Data.Tuples
{
    public enum WixCustomTableTupleFields
    {
        ColumnCount,
        ColumnNames,
        ColumnTypes,
        PrimaryKeys,
        MinValues,
        MaxValues,
        KeyTables,
        KeyColumns,
        Categories,
        Sets,
        Descriptions,
        Modularizations,
        Unreal,
    }

    public class WixCustomTableTuple : IntermediateTuple
    {
        public WixCustomTableTuple() : base(TupleDefinitions.WixCustomTable, null, null)
        {
        }

        public WixCustomTableTuple(SourceLineNumber sourceLineNumber, Identifier id = null) : base(TupleDefinitions.WixCustomTable, sourceLineNumber, id)
        {
        }

        public IntermediateField this[WixCustomTableTupleFields index] => this.Fields[(int)index];

        public int ColumnCount
        {
            get => (int)this.Fields[(int)WixCustomTableTupleFields.ColumnCount];
            set => this.Set((int)WixCustomTableTupleFields.ColumnCount, value);
        }

        public string ColumnNames
        {
            get => (string)this.Fields[(int)WixCustomTableTupleFields.ColumnNames];
            set => this.Set((int)WixCustomTableTupleFields.ColumnNames, value);
        }

        public string ColumnTypes
        {
            get => (string)this.Fields[(int)WixCustomTableTupleFields.ColumnTypes];
            set => this.Set((int)WixCustomTableTupleFields.ColumnTypes, value);
        }

        public string PrimaryKeys
        {
            get => (string)this.Fields[(int)WixCustomTableTupleFields.PrimaryKeys];
            set => this.Set((int)WixCustomTableTupleFields.PrimaryKeys, value);
        }

        public string MinValues
        {
            get => (string)this.Fields[(int)WixCustomTableTupleFields.MinValues];
            set => this.Set((int)WixCustomTableTupleFields.MinValues, value);
        }

        public string MaxValues
        {
            get => (string)this.Fields[(int)WixCustomTableTupleFields.MaxValues];
            set => this.Set((int)WixCustomTableTupleFields.MaxValues, value);
        }

        public string KeyTables
        {
            get => (string)this.Fields[(int)WixCustomTableTupleFields.KeyTables];
            set => this.Set((int)WixCustomTableTupleFields.KeyTables, value);
        }

        public string KeyColumns
        {
            get => (string)this.Fields[(int)WixCustomTableTupleFields.KeyColumns];
            set => this.Set((int)WixCustomTableTupleFields.KeyColumns, value);
        }

        public string Categories
        {
            get => (string)this.Fields[(int)WixCustomTableTupleFields.Categories];
            set => this.Set((int)WixCustomTableTupleFields.Categories, value);
        }

        public string Sets
        {
            get => (string)this.Fields[(int)WixCustomTableTupleFields.Sets];
            set => this.Set((int)WixCustomTableTupleFields.Sets, value);
        }

        public string Descriptions
        {
            get => (string)this.Fields[(int)WixCustomTableTupleFields.Descriptions];
            set => this.Set((int)WixCustomTableTupleFields.Descriptions, value);
        }

        public string Modularizations
        {
            get => (string)this.Fields[(int)WixCustomTableTupleFields.Modularizations];
            set => this.Set((int)WixCustomTableTupleFields.Modularizations, value);
        }

        public bool Unreal
        {
            get => (bool)this.Fields[(int)WixCustomTableTupleFields.Unreal];
            set => this.Set((int)WixCustomTableTupleFields.Unreal, value);
        }
    }
}
