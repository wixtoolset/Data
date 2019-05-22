// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data
{
    using WixToolset.Data.Tuples;

    public static partial class TupleDefinitions
    {
        public static readonly IntermediateTupleDefinition Condition = new IntermediateTupleDefinition(
            TupleDefinitionType.Condition,
            new[]
            {
                new IntermediateFieldDefinition(nameof(ConditionTupleFields.FeatureRef), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(ConditionTupleFields.Level), IntermediateFieldType.Number),
                new IntermediateFieldDefinition(nameof(ConditionTupleFields.Condition), IntermediateFieldType.String),
            },
            typeof(ConditionTuple));
    }
}

namespace WixToolset.Data.Tuples
{
    public enum ConditionTupleFields
    {
        FeatureRef,
        Level,
        Condition,
    }

    public class ConditionTuple : IntermediateTuple
    {
        public ConditionTuple() : base(TupleDefinitions.Condition, null, null)
        {
        }

        public ConditionTuple(SourceLineNumber sourceLineNumber, Identifier id = null) : base(TupleDefinitions.Condition, sourceLineNumber, id)
        {
        }

        public IntermediateField this[ConditionTupleFields index] => this.Fields[(int)index];

        public string FeatureRef
        {
            get => (string)this.Fields[(int)ConditionTupleFields.FeatureRef];
            set => this.Set((int)ConditionTupleFields.FeatureRef, value);
        }

        public int Level
        {
            get => (int)this.Fields[(int)ConditionTupleFields.Level];
            set => this.Set((int)ConditionTupleFields.Level, value);
        }

        public string Condition
        {
            get => (string)this.Fields[(int)ConditionTupleFields.Condition];
            set => this.Set((int)ConditionTupleFields.Condition, value);
        }
    }
}