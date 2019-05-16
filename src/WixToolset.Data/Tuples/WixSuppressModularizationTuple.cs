// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data
{
    using WixToolset.Data.Tuples;

    public static partial class TupleDefinitions
    {
        public static readonly IntermediateTupleDefinition WixSuppressModularization = new IntermediateTupleDefinition(
            TupleDefinitionType.WixSuppressModularization,
            new[]
            {
                new IntermediateFieldDefinition(nameof(WixSuppressModularizationTupleFields.WixSuppressModularization), IntermediateFieldType.String),
            },
            typeof(WixSuppressModularizationTuple));
    }
}

namespace WixToolset.Data.Tuples
{
    public enum WixSuppressModularizationTupleFields
    {
        WixSuppressModularization,
    }

    public class WixSuppressModularizationTuple : IntermediateTuple
    {
        public WixSuppressModularizationTuple() : base(TupleDefinitions.WixSuppressModularization, null, null)
        {
        }

        public WixSuppressModularizationTuple(SourceLineNumber sourceLineNumber, Identifier id = null) : base(TupleDefinitions.WixSuppressModularization, sourceLineNumber, id)
        {
        }

        public IntermediateField this[WixSuppressModularizationTupleFields index] => this.Fields[(int)index];

        public string WixSuppressModularization
        {
            get => (string)this.Fields[(int)WixSuppressModularizationTupleFields.WixSuppressModularization];
            set => this.Set((int)WixSuppressModularizationTupleFields.WixSuppressModularization, value);
        }
    }
}