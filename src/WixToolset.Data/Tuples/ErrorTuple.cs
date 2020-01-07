// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data
{
    using WixToolset.Data.Tuples;

    public static partial class TupleDefinitions
    {
        public static readonly IntermediateTupleDefinition Error = new IntermediateTupleDefinition(
            TupleDefinitionType.Error,
            new[]
            {
                new IntermediateFieldDefinition(nameof(ErrorTupleFields.Message), IntermediateFieldType.String),
            },
            typeof(ErrorTuple));
    }
}

namespace WixToolset.Data.Tuples
{
    public enum ErrorTupleFields
    {
        Message,
    }

    public class ErrorTuple : IntermediateTuple
    {
        public ErrorTuple() : base(TupleDefinitions.Error, null, null)
        {
        }

        public ErrorTuple(SourceLineNumber sourceLineNumber, Identifier id = null) : base(TupleDefinitions.Error, sourceLineNumber, id)
        {
        }

        public IntermediateField this[ErrorTupleFields index] => this.Fields[(int)index];

        public string Message
        {
            get => (string)this.Fields[(int)ErrorTupleFields.Message];
            set => this.Set((int)ErrorTupleFields.Message, value);
        }
    }
}