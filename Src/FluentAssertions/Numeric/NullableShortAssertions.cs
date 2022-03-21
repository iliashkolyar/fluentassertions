﻿using System.Diagnostics;

namespace FluentAssertions.Numeric
{
    /// <summary>
    /// Contains a number of methods to assert that a nullable <see cref="short"/> is in the expected state.
    /// </summary>
    [DebuggerNonUserCode]
    public class NullableShortAssertions : NullableNumericAssertions<short>
    {
        public NullableShortAssertions(short? value)
            : base(value)
        {
        }

        private protected override short? CalculateDifferenceForFailureMessage(short expected) => (short?)(Subject - expected);

        private protected override short GetMinimalDifferenceThresholdForFailureMessage() => -10;

        private protected override short GetMaximalDifferenceThresholdForFailureMessage() => 10;
    }
}
