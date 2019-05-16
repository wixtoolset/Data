// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data
{
    using WixToolset.Data.Tuples;

    public static partial class TupleDefinitions
    {
        public static readonly IntermediateTupleDefinition Class = new IntermediateTupleDefinition(
            TupleDefinitionType.Class,
            new[]
            {
                new IntermediateFieldDefinition(nameof(ClassTupleFields.CLSID), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(ClassTupleFields.Context), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(ClassTupleFields.Component_), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(ClassTupleFields.ProgId_Default), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(ClassTupleFields.Description), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(ClassTupleFields.AppId_), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(ClassTupleFields.FileTypeMask), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(ClassTupleFields.Icon_), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(ClassTupleFields.IconIndex), IntermediateFieldType.Number),
                new IntermediateFieldDefinition(nameof(ClassTupleFields.DefInprocHandler), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(ClassTupleFields.Argument), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(ClassTupleFields.Feature_), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(ClassTupleFields.RelativePath), IntermediateFieldType.Bool),
            },
            typeof(ClassTuple));
    }
}

namespace WixToolset.Data.Tuples
{
    public enum ClassTupleFields
    {
        CLSID,
        Context,
        Component_,
        ProgId_Default,
        Description,
        AppId_,
        FileTypeMask,
        Icon_,
        IconIndex,
        DefInprocHandler,
        Argument,
        Feature_,
        RelativePath,
    }

    public class ClassTuple : IntermediateTuple
    {
        public ClassTuple() : base(TupleDefinitions.Class, null, null)
        {
        }

        public ClassTuple(SourceLineNumber sourceLineNumber, Identifier id = null) : base(TupleDefinitions.Class, sourceLineNumber, id)
        {
        }

        public IntermediateField this[ClassTupleFields index] => this.Fields[(int)index];

        public string CLSID
        {
            get => (string)this.Fields[(int)ClassTupleFields.CLSID];
            set => this.Set((int)ClassTupleFields.CLSID, value);
        }

        public string Context
        {
            get => (string)this.Fields[(int)ClassTupleFields.Context];
            set => this.Set((int)ClassTupleFields.Context, value);
        }

        public string Component_
        {
            get => (string)this.Fields[(int)ClassTupleFields.Component_];
            set => this.Set((int)ClassTupleFields.Component_, value);
        }

        public string ProgId_Default
        {
            get => (string)this.Fields[(int)ClassTupleFields.ProgId_Default];
            set => this.Set((int)ClassTupleFields.ProgId_Default, value);
        }

        public string Description
        {
            get => (string)this.Fields[(int)ClassTupleFields.Description];
            set => this.Set((int)ClassTupleFields.Description, value);
        }

        public string AppId_
        {
            get => (string)this.Fields[(int)ClassTupleFields.AppId_];
            set => this.Set((int)ClassTupleFields.AppId_, value);
        }

        public string FileTypeMask
        {
            get => (string)this.Fields[(int)ClassTupleFields.FileTypeMask];
            set => this.Set((int)ClassTupleFields.FileTypeMask, value);
        }

        public string Icon_
        {
            get => (string)this.Fields[(int)ClassTupleFields.Icon_];
            set => this.Set((int)ClassTupleFields.Icon_, value);
        }

        public int IconIndex
        {
            get => (int)this.Fields[(int)ClassTupleFields.IconIndex];
            set => this.Set((int)ClassTupleFields.IconIndex, value);
        }

        public string DefInprocHandler
        {
            get => (string)this.Fields[(int)ClassTupleFields.DefInprocHandler];
            set => this.Set((int)ClassTupleFields.DefInprocHandler, value);
        }

        public string Argument
        {
            get => (string)this.Fields[(int)ClassTupleFields.Argument];
            set => this.Set((int)ClassTupleFields.Argument, value);
        }

        public string Feature_
        {
            get => (string)this.Fields[(int)ClassTupleFields.Feature_];
            set => this.Set((int)ClassTupleFields.Feature_, value);
        }

        public bool RelativePath
        {
            get => this.Fields[(int)ClassTupleFields.RelativePath].AsBool();
            set => this.Set((int)ClassTupleFields.RelativePath, value);
        }
    }
}