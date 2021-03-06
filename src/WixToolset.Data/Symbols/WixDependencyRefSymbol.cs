// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data
{
    using WixToolset.Data.Symbols;

    public static partial class SymbolDefinitions
    {
        public static readonly IntermediateSymbolDefinition WixDependencyRef = new IntermediateSymbolDefinition(
            SymbolDefinitionType.WixDependencyRef,
            new[]
            {
                new IntermediateFieldDefinition(nameof(WixDependencyRefSymbolFields.WixDependencyProviderRef), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(WixDependencyRefSymbolFields.WixDependencyRef), IntermediateFieldType.String),
            },
            typeof(WixDependencyRefSymbol));
    }
}

namespace WixToolset.Data.Symbols
{
    public enum WixDependencyRefSymbolFields
    {
        WixDependencyProviderRef,
        WixDependencyRef,
    }

    public class WixDependencyRefSymbol : IntermediateSymbol
    {
        public WixDependencyRefSymbol() : base(SymbolDefinitions.WixDependencyRef, null, null)
        {
        }

        public WixDependencyRefSymbol(SourceLineNumber sourceLineNumber, Identifier id = null) : base(SymbolDefinitions.WixDependencyRef, sourceLineNumber, id)
        {
        }

        public IntermediateField this[WixDependencyRefSymbolFields index] => this.Fields[(int)index];

        public string WixDependencyProviderRef
        {
            get => this.Fields[(int)WixDependencyRefSymbolFields.WixDependencyProviderRef].AsString();
            set => this.Set((int)WixDependencyRefSymbolFields.WixDependencyProviderRef, value);
        }

        public string WixDependencyRef
        {
            get => this.Fields[(int)WixDependencyRefSymbolFields.WixDependencyRef].AsString();
            set => this.Set((int)WixDependencyRefSymbolFields.WixDependencyRef, value);
        }
    }
}
