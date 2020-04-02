// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data
{
    public static class IntermediateSectionExtensions
    {
        public static T AddTuple<T>(this IntermediateSection section, T tuple)
            where T : IntermediateTuple
        {
            section.Tuples.Add(tuple);
            return tuple;
        }
    }
}
