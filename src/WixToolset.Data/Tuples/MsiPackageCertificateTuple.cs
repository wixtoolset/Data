// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data
{
    using WixToolset.Data.Tuples;

    public static partial class TupleDefinitions
    {
        public static readonly IntermediateTupleDefinition MsiPackageCertificate = new IntermediateTupleDefinition(
            TupleDefinitionType.MsiPackageCertificate,
            new[]
            {
                new IntermediateFieldDefinition(nameof(MsiPackageCertificateTupleFields.PackageCertificate), IntermediateFieldType.String),
                new IntermediateFieldDefinition(nameof(MsiPackageCertificateTupleFields.DigitalCertificateRef), IntermediateFieldType.String),
            },
            typeof(MsiPackageCertificateTuple));
    }
}

namespace WixToolset.Data.Tuples
{
    public enum MsiPackageCertificateTupleFields
    {
        PackageCertificate,
        DigitalCertificateRef,
    }

    public class MsiPackageCertificateTuple : IntermediateTuple
    {
        public MsiPackageCertificateTuple() : base(TupleDefinitions.MsiPackageCertificate, null, null)
        {
        }

        public MsiPackageCertificateTuple(SourceLineNumber sourceLineNumber, Identifier id = null) : base(TupleDefinitions.MsiPackageCertificate, sourceLineNumber, id)
        {
        }

        public IntermediateField this[MsiPackageCertificateTupleFields index] => this.Fields[(int)index];

        public string PackageCertificate
        {
            get => (string)this.Fields[(int)MsiPackageCertificateTupleFields.PackageCertificate];
            set => this.Set((int)MsiPackageCertificateTupleFields.PackageCertificate, value);
        }

        public string DigitalCertificateRef
        {
            get => (string)this.Fields[(int)MsiPackageCertificateTupleFields.DigitalCertificateRef];
            set => this.Set((int)MsiPackageCertificateTupleFields.DigitalCertificateRef, value);
        }
    }
}