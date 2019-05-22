// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data
{
    using WixToolset.Data.Tuples;

    public static partial class TupleDefinitions
    {
        public static readonly IntermediateTupleDefinition ModuleIgnoreTable = new IntermediateTupleDefinition(
            TupleDefinitionType.ModuleIgnoreTable,
            new IntermediateFieldDefinition[0],
            typeof(ModuleIgnoreTableTuple));
    }
}

namespace WixToolset.Data.Tuples
{
    public enum ModuleIgnoreTableTupleFields
    {
    }

    public class ModuleIgnoreTableTuple : IntermediateTuple
    {
        public ModuleIgnoreTableTuple() : base(TupleDefinitions.ModuleIgnoreTable, null, null)
        {
        }

        public ModuleIgnoreTableTuple(SourceLineNumber sourceLineNumber, Identifier id = null) : base(TupleDefinitions.ModuleIgnoreTable, sourceLineNumber, id)
        {
        }

        public IntermediateField this[ModuleIgnoreTableTupleFields index] => this.Fields[(int)index];
   }
}